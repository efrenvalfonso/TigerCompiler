using System.Collections.Generic;
using Antlr.Runtime;
using TigerCompiler.MyTypes;

namespace TigerCompiler.hierarchy.LanguageNode.DeclarationNode.TypeDeclarationNode
{
    class AliasTypeNode : TypeDeclarationNode
    {
        public AliasTypeNode(IToken token)
            : base(token)
        {
        }

        public override bool CheckSemantic(Scope scope, List<Error> errors)
        {
            NodeType = new VoidType();
            if (scope.ContainInAliasTable(Id) || scope.ContainLocalType(Id))
                errors.Add(new Error(string.Format("A type named '{0}' is already defined in this scope", Id),
                                     GetChild(0).Line, GetChild(0).CharPositionInLine));
            else
                scope.InsertAlias(new TypeNode(Id, GetChild(0).Line, GetChild(0).CharPositionInLine),
                                  new TypeNode(RType, GetChild(1).Line, GetChild(1).CharPositionInLine));
            return true;
        }
    }
}
