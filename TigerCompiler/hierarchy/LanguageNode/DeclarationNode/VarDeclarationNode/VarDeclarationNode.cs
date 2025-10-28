using Antlr.Runtime;

namespace TigerCompiler.hierarchy.LanguageNode.DeclarationNode.VarDeclarationNode
{
    public abstract class VarDeclarationNode : DeclarationNode
    {
        protected VarDeclarationNode(IToken token)
            : base(token)
        {
        }
    }
}
