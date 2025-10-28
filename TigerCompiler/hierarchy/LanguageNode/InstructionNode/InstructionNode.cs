using Antlr.Runtime;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode
{
    public abstract class InstructionNode : LanguageNode
    {
        protected InstructionNode(IToken token)
            : base(token)
        {
        }
    }
}
