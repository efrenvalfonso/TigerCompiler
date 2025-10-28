using System.Reflection.Emit;
using Antlr.Runtime;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode.OperationNode.UnaryNode
{
    public class MinusNode : UnaryNode
    {
        public MinusNode(IToken token)
            : base(token)
        {
        }


        public override void GenerateCode(ILGenerator codeGenerator)
        {
            Node.GenerateCode(codeGenerator);
            codeGenerator.Emit(OpCodes.Neg);
        }
    }
}