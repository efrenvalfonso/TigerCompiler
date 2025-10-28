using System.Collections.Generic;
using Antlr.Runtime;
using TigerCompiler.MyTypes;
using TigerCompiler.hierarchy.LanguageNode.InstructionNode;

namespace TigerCompiler.hierarchy.LanguageNode.DeclarationNode.ExpressionsSequenceDeclarationNode
{
    public abstract class ExpressionsSequenceDeclarationNode : DeclarationNode
    {
        protected ExpressionsSequenceDeclarationNode(IToken token)
            : base(token)
        {
            ParametersTypes = new List<MyType>();
            ParametersNames = new List<string>();
        }

        public List<MyType> ParametersTypes { get; protected set; }

        protected List<string> ParametersNames { get; private set; }

        public ExpressionSequenceNode Fields
        {
            get
            {
                if (ChildCount == 3 && (GetChild(1) is ExpressionSequenceNode) || ChildCount == 4)
                    return (ExpressionSequenceNode)GetChild(1);
                return null;
            }
        }
    }
}