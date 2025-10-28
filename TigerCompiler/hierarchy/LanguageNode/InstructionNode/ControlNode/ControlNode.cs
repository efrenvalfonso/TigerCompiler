using Antlr.Runtime;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode.ControlNode
{
    abstract class ControlNode : InstructionNode
    {
        protected ControlNode(IToken token)
            : base(token)
        {
        }
    }
}
