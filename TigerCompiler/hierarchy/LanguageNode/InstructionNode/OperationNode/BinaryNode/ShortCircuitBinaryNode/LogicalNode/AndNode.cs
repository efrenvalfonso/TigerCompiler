using System.Reflection.Emit;
using Antlr.Runtime;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode.OperationNode.BinaryNode.ShortCircuitBinaryNode.LogicalNode
{
    class AndNode : LogicalNode
    {
        public AndNode(IToken token)
            : base(token)
        {
        }

        public override void GenerateCode(ILGenerator codeGenerator)
        {
            Label falseLabel = codeGenerator.DefineLabel(),
                  endLabel = codeGenerator.DefineLabel();

            LeftValue.GenerateCode(codeGenerator);
            codeGenerator.Emit(OpCodes.Brfalse, falseLabel);
            RightValue.GenerateCode(codeGenerator);
            codeGenerator.Emit(OpCodes.Br, endLabel);
            codeGenerator.MarkLabel(falseLabel);
            codeGenerator.Emit(OpCodes.Ldc_I4_0);
            codeGenerator.MarkLabel(endLabel);
        }
    }
}
