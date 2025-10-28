using System.Reflection.Emit;
using Antlr.Runtime;

namespace TigerCompiler.hierarchy.LanguageNode.DeclarationNode.TypeDeclarationNode
{
    public abstract class TypeDeclarationNode : DeclarationNode
    {
        protected TypeDeclarationNode(IToken token)
            : base(token)
        {
        }

        public string RType
        {
            get { return GetChild(1).Text; }
        }

        public override void GenerateCode(ILGenerator codeGenerator)
        {
            // This node doesn't generate code.
        }
    }
}
