using System.Reflection.Emit;
using Antlr.Runtime;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode.OperationNode.BinaryNode.NoShortCircuitBinaryNode.ComparisonNode.EqualityComparisonNode
{
    public class NotEqualNode : EqualityComparisonNode
    {
        public NotEqualNode(IToken token)
            : base(token)
        {
        }

        public override void GenerateCode(ILGenerator codeGenerator)
        {
            base.GenerateCode(codeGenerator);
            codeGenerator.Emit(OpCodes.Ceq);
            codeGenerator.Emit(OpCodes.Ldc_I4_0);
            codeGenerator.Emit(OpCodes.Ceq);
        }
    }
}