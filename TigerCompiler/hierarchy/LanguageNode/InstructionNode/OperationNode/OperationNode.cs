using Antlr.Runtime;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode.OperationNode
{
    public abstract class OperationNode : InstructionNode
    {
        protected OperationNode(IToken token)
            : base(token)
        {
        }
    }
}
