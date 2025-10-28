using Antlr.Runtime;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode.ControlNode.ConditionalNode
{
    abstract class ConditionalNode : ControlNode
    {
        protected ConditionalNode(IToken token)
            : base(token)
        {
        }
    }
}
