using Antlr.Runtime;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode.AccesNode
{
    abstract class AccessNode : InstructionNode
    {
        protected AccessNode(IToken token)
            : base(token)
        {
        }

        public LanguageNode LeftValue
        {
            get { return (LanguageNode)GetChild(0); }
        }

        public LanguageNode Access
        {
            get { return (LanguageNode)GetChild(1); }
        }
    }
}
