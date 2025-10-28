using System.Reflection.Emit;
using Antlr.Runtime;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode.OperationNode.BinaryNode.NoShortCircuitBinaryNode.ArithmeticNode
{
    class SumNode : ArithmeticNode
    {
        public SumNode(IToken token)
            : base(token)
        {
        }

        public override void GenerateCode(ILGenerator codeGenerator)
        {
            base.GenerateCode(codeGenerator);
            codeGenerator.Emit(OpCodes.Add);
        }
    }
}
