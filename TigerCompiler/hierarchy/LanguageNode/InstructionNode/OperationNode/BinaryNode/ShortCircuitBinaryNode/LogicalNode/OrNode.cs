using System.Reflection.Emit;
using Antlr.Runtime;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode.OperationNode.BinaryNode.ShortCircuitBinaryNode.LogicalNode
{
    internal class OrNode : LogicalNode
    {
        public OrNode(IToken token)
            : base(token)
        {
        }


        public override void GenerateCode(ILGenerator codeGenerator)
        {
            var endLabel = codeGenerator.DefineLabel();
            LeftValue.GenerateCode(codeGenerator);
            codeGenerator.Emit(OpCodes.Dup);
            codeGenerator.Emit(OpCodes.Brtrue, endLabel);
            codeGenerator.Emit(OpCodes.Pop);
            RightValue.GenerateCode(codeGenerator);
            codeGenerator.MarkLabel(endLabel);
        }
    }
}
