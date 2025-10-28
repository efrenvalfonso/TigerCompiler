using System.Collections.Generic;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigerCompiler.MyTypes;
using TigerCompiler.hierarchy.LanguageNode.DeclarationNode.VarDeclarationNode;
using TigerCompiler.hierarchy.LanguageNode.InstructionNode.AccesNode.ArrayAccessNode;
using TigerCompiler.hierarchy.LanguageNode.InstructionNode.AccesNode.FieldAccessNode;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode
{
    class AssignmentNode : InstructionNode
    {
        public AssignmentNode(IToken token)
            : base(token)
        {
        }

        private LanguageNode LeftValue
        {
            get { return (LanguageNode)GetChild(0); }
        }

        private LanguageNode Expression
        {
            get { return (LanguageNode)GetChild(1); }
        }

        public override bool CheckSemantic(Scope scope, List<Error> errors)
        {
            bool result = LeftValue.CheckSemantic(scope, errors);
            result = Expression.CheckSemantic(scope, errors) && result;
            NodeType = new VoidType();

            if (LeftValue is IdentificatorVariableNode) //analisis para cuando es una variable de solo lectura
            {
                var identifier = (IdentificatorVariableNode)LeftValue;
                if (scope.ContainVariable(identifier.Id))
                {
                    var variable = identifier.Variable;
                    if (variable.IsReadOnly)
                    {
                        result = false;
                        errors.Add(new Error(string.Format("The variable '{0}' is read only", identifier.Id),
                                             LeftValue.Line, LeftValue.CharPositionInLine));
                    }
                }
            }

            if (Expression.NodeType is ErrorType)
            {
                result = false;
                errors.Add(new Error("Assignment impossible because right expression is wrong", Expression.Line,
                                     Expression.CharPositionInLine));
            }
            else if (scope.IsDistinct(LeftValue.NodeType, Expression.NodeType))
            {
                result = false;
                NodeType = new ErrorType();
                if (!(LeftValue.NodeType is ErrorType))
                    errors.Add(
                        new Error(
                            string.Format("Cannot implicitly convert type '{0}' to '{1}'", Expression.NodeType,
                                          LeftValue.NodeType), Line, CharPositionInLine));
            }
            return result;
        }

        public override void GenerateCode(ILGenerator codeGenerator)
        {
            if (LeftValue is IndexerNode)
            {
                var indexer = LeftValue as IndexerNode;
                indexer.LeftValue.GenerateCode(codeGenerator);
                indexer.Access.GenerateCode(codeGenerator);
                Expression.GenerateCode(codeGenerator);
                codeGenerator.Emit(OpCodes.Stelem, indexer.CodeGeneratorType);
            }
            else if (LeftValue is FieldAccessNode)
            {
                var access = LeftValue as FieldAccessNode;
                access.LeftValue.GenerateCode(codeGenerator);
                Expression.GenerateCode(codeGenerator);
                codeGenerator.Emit(OpCodes.Stfld,
                                               access.LeftValue.CodeGeneratorType.GetField(access.Access.Text));
            }
            else
            {
                var idVariableNode = (IdentificatorVariableNode)LeftValue;
                codeGenerator.Emit(OpCodes.Ldloc_0);

                if (idVariableNode.DistanceToScope > 0)
                {
                    codeGenerator.Emit(OpCodes.Ldc_I4, idVariableNode.DistanceToScope);
                    codeGenerator.Emit(OpCodes.Call, CodeGenerator.GoToItScopeMethod);
                }

                if (Expression.NodeType is IntType)
                {
                    codeGenerator.Emit(OpCodes.Ldfld, CodeGenerator.IntegerVariables);
                    codeGenerator.Emit(OpCodes.Ldc_I4, idVariableNode.Variable.Index);
                    Expression.GenerateCode(codeGenerator);
                    codeGenerator.Emit(OpCodes.Stelem_I4);
                }
                else
                {
                    codeGenerator.Emit(OpCodes.Ldfld, CodeGenerator.ReferenceVariables);
                    codeGenerator.Emit(OpCodes.Ldc_I4, idVariableNode.Variable.Index);
                    Expression.GenerateCode(codeGenerator);
                    codeGenerator.Emit(OpCodes.Stelem_Ref);
                }
            }
        }
    }
}
