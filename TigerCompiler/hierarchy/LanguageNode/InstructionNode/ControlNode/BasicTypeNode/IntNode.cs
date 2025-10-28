using System.Collections.Generic;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigerCompiler.MyTypes;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode.ControlNode.BasicTypeNode
{
    internal class IntNode : BasicTypeNode
    {
        public IntNode(IToken token)
            : base(token)
        {
        }

        private int Value { get; set; }

        public override bool CheckSemantic(Scope scope, List<Error> errors)
        {
            int value;
            if (int.TryParse(Text, out value))
            {
                NodeType = new IntType();
                CodeGeneratorType = NodeType.DotNetType;
                Value = value;
                return true;
            }
            errors.Add(new Error("The number is incorrect. Integer values are between -2147483648 and 2147483647", Line, CharPositionInLine));
            return false;
        }

        public override void GenerateCode(ILGenerator codeGenerator)
        {
            codeGenerator.Emit(OpCodes.Ldc_I4, Value);
        }
    }
}