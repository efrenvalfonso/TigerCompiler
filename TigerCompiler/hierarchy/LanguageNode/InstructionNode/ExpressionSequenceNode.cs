using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigerCompiler.MyTypes;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode
{
    public class ExpressionSequenceNode : InstructionNode
    {
        private List<LanguageNode> _exp;

        public ExpressionSequenceNode(IToken token)
            : base(token)
        {
        }

        public List<LanguageNode> Expressions
        {
            get
            {
                _exp = new List<LanguageNode>();
                for (int i = 0; i < ChildCount; i++)
                    _exp.Add((LanguageNode)GetChild(i));
                return _exp;
            }
        }

        public override bool CheckSemantic(Scope scope, List<Error> errors)
        {
            NodeType = new VoidType();

            bool result = Expressions.Aggregate(true, (current, expression) => expression.CheckSemantic(scope, errors) && current);

            if (Expressions.Count > 0)
                NodeType = Expressions[Expressions.Count - 1].NodeType;

            return result;
        }

        public override void GenerateCode(ILGenerator codeGenerator)
        {
            foreach (var item in Expressions)
                item.GenerateCode(codeGenerator);
        }
    }
}
