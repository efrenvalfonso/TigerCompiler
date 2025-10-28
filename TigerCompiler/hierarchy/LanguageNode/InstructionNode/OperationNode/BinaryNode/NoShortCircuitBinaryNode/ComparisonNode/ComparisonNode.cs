using Antlr.Runtime;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode.OperationNode.BinaryNode.NoShortCircuitBinaryNode.ComparisonNode
{
    public abstract class ComparisonNode : NoShortCircuitBinaryNode
    {
        protected ComparisonNode(IToken token)
            : base(token)
        {
        }
    }
}