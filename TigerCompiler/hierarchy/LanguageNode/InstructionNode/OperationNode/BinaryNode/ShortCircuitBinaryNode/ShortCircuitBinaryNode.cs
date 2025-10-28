using Antlr.Runtime;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode.OperationNode.BinaryNode.ShortCircuitBinaryNode
{
    internal abstract class ShortCircuitBinaryNode : BinaryNode
    {
        protected ShortCircuitBinaryNode(IToken token)
            : base(token)
        {
        }
    }
}