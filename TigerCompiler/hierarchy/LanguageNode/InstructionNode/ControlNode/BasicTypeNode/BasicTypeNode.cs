using Antlr.Runtime;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode.ControlNode.BasicTypeNode
{
    abstract class BasicTypeNode : ControlNode
    {
        protected BasicTypeNode(IToken token)
            : base(token)
        {
        }
    }
}
