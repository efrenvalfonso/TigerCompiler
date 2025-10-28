using Antlr.Runtime;


namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode.OperationNode.BinaryNode
{
    public abstract class BinaryNode : OperationNode
    {
        protected BinaryNode(IToken token)
            : base(token)
        {
        }

        protected LanguageNode LeftValue
        {
            get { return (LanguageNode)GetChild(0); }
        }

        protected LanguageNode RightValue
        {
            get { return (LanguageNode)GetChild(1); }
        }
    }
}