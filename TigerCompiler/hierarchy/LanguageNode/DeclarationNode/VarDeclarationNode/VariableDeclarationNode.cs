using System.Collections.Generic;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigerCompiler.MyTypes;

namespace TigerCompiler.hierarchy.LanguageNode.DeclarationNode.VarDeclarationNode
{
    public sealed class VariableDeclarationNode : VarDeclarationNode
    {
        private readonly LanguageNode _value;

        public VariableDeclarationNode(IToken token)
            : base(token)
        {
        }

        public VariableDeclarationNode(string name, LanguageNode value)
            : base(null)
        {
            Id = name;
            _value = value;
        }

        private string VariableTypeIdName { get { return ChildCount == 3 ? GetChild(2).Text : null; } }

        private MyType VariableTypeId { get; set; }

        private LanguageNode VariableValue { get { return _value ?? (LanguageNode)GetChild(1); } }

        public int Index { get; set; }

        public bool IsReadOnly { get; set; }

        public override bool CheckSemantic(Scope scope, List<Error> errors)
        {
            bool result = VariableValue.CheckSemantic(scope, errors);
            NodeType = VariableValue.NodeType;
            if (scope.ContainLocalVariable(Id) || scope.ContainFunctionInTable(Id))//las variables y las funciones comparten el mismo namespace
            {
                result = false;
                errors.Add(
                    new Error(string.Format("A variable or function named '{0}' is already defined in this scope", Id),
                              GetChild(0).Line, GetChild(0).CharPositionInLine));
                NodeType = new ErrorType();

            }
            else
            {
                if (VariableTypeIdName != null) //el tipo de la variable no se infiere
                {
                    VariableTypeId = scope.GetMyType(VariableTypeIdName);
                    if (!(VariableTypeId is NilType))
                    {
                        NodeType = VariableTypeId;
                        if (scope.IsDistinct(VariableTypeId, VariableValue.NodeType))
                        {
                            result = false;
                            NodeType = new ErrorType();
                            if (!(VariableValue.NodeType is ErrorType || VariableTypeId is ErrorType))
                                errors.Add(
                                    new Error(
                                        string.Format("Cannot implicitly convert type '{0}' to '{1}'",
                                                      VariableValue.NodeType, VariableTypeId), GetChild(2).Line,
                                        GetChild(2).CharPositionInLine));
                        }
                    }
                    else
                    {
                        result = false;
                        errors.Add(
                            new Error(
                                string.Format("The type named '{0}' is not defined in this scope", VariableTypeId),
                                GetChild(2).Line, GetChild(2).CharPositionInLine));
                        NodeType = new ErrorType();
                    }
                }
                else //se infiere el tipo
                {
                    if (VariableValue.NodeType is VoidType)
                    {
                        result = false;
                        NodeType = new ErrorType();
                        errors.Add(
                            new Error("Cannot infer type. Variable value cannot be of type 'void'",
                                      VariableValue.Line, VariableValue.CharPositionInLine));
                    }
                    else if (VariableValue.NodeType is NilType)
                    {
                        result = false;
                        NodeType = new ErrorType();
                        errors.Add(
                            new Error("Cannot infer type. Variable value cannot be 'nil'",
                                      VariableValue.Line, VariableValue.CharPositionInLine));
                    }
                }
            }
            if (result) scope.InsertVariable(this);
            return result;
        }

        public override void GenerateCode(ILGenerator codeGenerator)
        {
            codeGenerator.Emit(OpCodes.Ldloc_0);
            if (NodeType is IntType)
            {
                codeGenerator.Emit(OpCodes.Ldfld, CodeGenerator.IntegerVariables);
                codeGenerator.Emit(OpCodes.Ldc_I4, Index);
                VariableValue.GenerateCode(codeGenerator);
                codeGenerator.Emit(OpCodes.Stelem_I4);
            }
            else
            {
                codeGenerator.Emit(OpCodes.Ldfld, CodeGenerator.ReferenceVariables);
                codeGenerator.Emit(OpCodes.Ldc_I4, Index);
                VariableValue.GenerateCode(codeGenerator);
                codeGenerator.Emit(OpCodes.Stelem_Ref);
            }
        }
    }
}
