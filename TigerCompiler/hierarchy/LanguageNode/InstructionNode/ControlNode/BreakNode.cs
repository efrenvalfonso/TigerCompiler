using System.Collections.Generic;
using Antlr.Runtime;
using System.Reflection.Emit;
using TigerCompiler.MyTypes;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode.ControlNode
{
    internal class BreakNode : ControlNode
    {
        public BreakNode(IToken token)
            : base(token)
        {
        }

        public override bool CheckSemantic(Scope scope, List<Error> errors)
        {
            NodeType = new VoidType();
            if (IsInloop(scope))
                return true;

            errors.Add(new Error("No enclosing loop or tuple out of which to break", Line, CharPositionInLine));
            return false;
        }

        private bool IsInloop(Scope scope)
        {
            while (scope != null)
            {
                if (scope.IsForScope || scope.IsWhileScope) return true;
                scope = scope.Father;
            }
            return false;
        }

        public override void GenerateCode(ILGenerator codeGenerator)
        {
            ILGenerator ge = codeGenerator;
            ge.Emit(OpCodes.Br, CodeGenerator.BreakLabels.Peek());
        }
    }
}