using System.Reflection.Emit;
using Antlr.Runtime;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode.OperationNode.BinaryNode.NoShortCircuitBinaryNode.ComparisonNode.RelationalComparisonNode
{
    public class GreaterThanNode : RelationalComparisonNode
    {
        public GreaterThanNode(IToken token)
            : base(token)
        {
        }

        public override void GenerateCode(ILGenerator codeGenerator)
        {
            base.GenerateCode(codeGenerator);
            codeGenerator.Emit(OpCodes.Cgt);
        }
    }
}