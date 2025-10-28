using System.Collections.Generic;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigerCompiler.MyTypes;

namespace TigerCompiler.hierarchy.LanguageNode.DeclarationNode.VarDeclarationNode
{
    internal class IdentificatorVariableNode : VarDeclarationNode
    {
        public IdentificatorVariableNode(IToken token)
            : base(token)
        {
        }

        public VariableDeclarationNode Variable { get; private set; }

        public string Id
        {
            get { return Text; }
        }

        public int DistanceToScope { get; private set; }

        public override bool CheckSemantic(Scope scope, List<Error> errors)
        {
            if (scope.ContainVariable(Id))
            {
                int distanceToScope;
                Variable = scope.GetVariable(Id, out distanceToScope);
                NodeType = scope.GetVariableType(Id);
                CodeGeneratorType = NodeType.DotNetType;
                DistanceToScope = distanceToScope;
                return true;
            }
            errors.Add(
                new Error(string.Format("The name '{0}' does not exist in the current context", Id), Line,
                          CharPositionInLine));
            NodeType = new ErrorType();
            return false;
        }

        public override void GenerateCode(ILGenerator codeGenerator)
        {
            codeGenerator.Emit(OpCodes.Ldloc_0);
            if (DistanceToScope > 0)
            {
                codeGenerator.Emit(OpCodes.Ldc_I4, DistanceToScope);
                codeGenerator.Emit(OpCodes.Call, CodeGenerator.GoToItScopeMethod);
            }
            if (NodeType is IntType)
            {
                codeGenerator.Emit(OpCodes.Ldfld, CodeGenerator.IntegerVariables);
                codeGenerator.Emit(OpCodes.Ldc_I4, Variable.Index);
                codeGenerator.Emit(OpCodes.Ldelem_I4);
            }
            else
            {
                codeGenerator.Emit(OpCodes.Ldfld, CodeGenerator.ReferenceVariables);
                codeGenerator.Emit(OpCodes.Ldc_I4, Variable.Index);
                codeGenerator.Emit(OpCodes.Ldelem_Ref);
            }
        }
    }
}