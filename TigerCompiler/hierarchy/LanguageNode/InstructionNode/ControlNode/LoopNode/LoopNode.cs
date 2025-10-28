using Antlr.Runtime;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode.ControlNode.LoopNode
{
    abstract class LoopNode : ControlNode
    {
        protected LoopNode(IToken token)
            : base(token)
        {
        }
    }
}
