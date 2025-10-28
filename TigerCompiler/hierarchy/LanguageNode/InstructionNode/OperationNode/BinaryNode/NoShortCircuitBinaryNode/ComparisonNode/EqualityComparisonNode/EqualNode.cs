using System.Reflection.Emit;
using Antlr.Runtime;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode.OperationNode.BinaryNode.NoShortCircuitBinaryNode.ComparisonNode.EqualityComparisonNode
{
    public class EqualNode : EqualityComparisonNode
    {
        public EqualNode(IToken token)
            : base(token)
        {
        }

        public override void GenerateCode(ILGenerator codeGenerator)
        {
            base.GenerateCode(codeGenerator);
            codeGenerator.Emit(OpCodes.Ceq);
        }
    }
}