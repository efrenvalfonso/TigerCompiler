using System;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigerCompiler.MyTypes;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode.OperationNode.BinaryNode.NoShortCircuitBinaryNode
{
    public abstract class NoShortCircuitBinaryNode : BinaryNode
    {
        protected NoShortCircuitBinaryNode(IToken token)
            : base(token)
        {
        }

        public override void GenerateCode(ILGenerator codeGenerator)
        {
            LeftValue.GenerateCode(codeGenerator);
            RightValue.GenerateCode(codeGenerator);

            if (LeftValue.NodeType is StringType)
            {
                Type type = typeof(string);
                codeGenerator.Emit(OpCodes.Call, type.GetMethod("Compare", new[] { type, type }));
                codeGenerator.Emit(OpCodes.Ldc_I4_0);
            }
        }
    }
}
