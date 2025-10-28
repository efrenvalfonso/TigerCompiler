using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigerCompiler.MyTypes;
using TigerCompiler.hierarchy.LanguageNode.InstructionNode.ControlNode;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode
{
    public class TupleNode : InstructionNode
    {
        public TupleNode(IToken token)
            : base(token)
        {
        }

        private ExpressionSequenceNode Expressions
        {
            get
            {
                if (ChildCount == 1) return (ExpressionSequenceNode)GetChild(0);
                return null;
            }
        }

        public override bool CheckSemantic(Scope scope, List<Error> errors)
        {
            bool result = true;
            NodeType = new VoidType();
            if (Expressions != null)
            {
                result = Expressions.Expressions.Aggregate(true, (current, expr) => expr.CheckSemantic(scope, errors) && current);

                if (!PossibleBreak(Expressions.Expressions) && Expressions.Expressions.Count > 0)
                    NodeType = Expressions.Expressions[Expressions.Expressions.Count - 1].NodeType;
            }
            return result;
        }

        private bool PossibleBreak(IEnumerable<LanguageNode> expressions)
        {
            return expressions.Any(expr => expr is BreakNode || expr.ChildCount > 0 && PossibleBreak(GetChildren(expr)));
        }

        private IEnumerable<LanguageNode> GetChildren(LanguageNode expr)
        {
            var result = new List<LanguageNode>();
            for (int i = 0; i < expr.ChildCount; i++)
            {
                result.Add((LanguageNode)expr.GetChild(i));
            }
            return result;
        }

        public override void GenerateCode(ILGenerator codeGenerator)
        {
            if (Expressions != null) Expressions.GenerateCode(codeGenerator);
        }
    }
}
