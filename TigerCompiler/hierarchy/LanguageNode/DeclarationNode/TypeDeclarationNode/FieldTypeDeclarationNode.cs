using System.Collections.Generic;
using System.Reflection.Emit;
using Antlr.Runtime;

namespace TigerCompiler.hierarchy.LanguageNode.DeclarationNode.TypeDeclarationNode
{
    public class FieldTypeDeclarationNode : TypeDeclarationNode
    {
        public FieldTypeDeclarationNode(IToken token)
            : base(token)
        {
        }

        public override bool CheckSemantic(Scope scope, List<Error> errors)
        {
            return true;
        }

        public override void GenerateCode(ILGenerator codeGenerator)
        {
            // This node doesn't generate code.
        }
    }
}
