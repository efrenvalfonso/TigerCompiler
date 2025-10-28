using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigerCompiler.MyTypes;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode.ControlNode.BasicTypeNode
{
    class NillNode : BasicTypeNode
    {
        public NillNode(IToken token)
            : base(token)
        {
        }

        public override bool CheckSemantic(Scope scope, List<Error> errors)
        {
            NodeType = new NilType();
            CodeGeneratorType = typeof(Nullable);
            return true;
        }

        public override void GenerateCode(ILGenerator codeGenerator)
        {
            codeGenerator.Emit(OpCodes.Ldnull);
        }
    }
}
