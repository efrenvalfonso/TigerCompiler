using System.Collections.Generic;
using Antlr.Runtime;
using TigerCompiler.MyTypes;
using TigerCompiler.hierarchy.LanguageNode.InstructionNode;

namespace TigerCompiler.hierarchy.LanguageNode.DeclarationNode.TypeDeclarationNode
{
    class RecordTypeDeclarationNode : TypeDeclarationNode
    {
        public RecordTypeDeclarationNode(IToken token)
            : base(token)
        {
        }

        private ExpressionSequenceNode Fields
        {
            get
            {
                if (ChildCount == 2) return (ExpressionSequenceNode)GetChild(1);
                return null;
            }
        }

        public override bool CheckSemantic(Scope scope, List<Error> errors)
        {
            bool result = FieldsOk(new List<string>(), Fields, errors);
            NodeType = new VoidType();

            if (scope.ContainLocalTypeId(Id) || scope.ContainLocalType(Id))
            {
                result = false;
                errors.Add(new Error(string.Format("A type named '{0}' is already defined in this scope", Id),
                                     GetChild(0).Line, GetChild(0).CharPositionInLine));
            }
            else if (result)
            {
                scope.InsertId(Id);
                var fields = new Dictionary<string, string>();
                var alias = new List<TypeNode>();
                if (Fields != null)
                {
                    foreach (FieldTypeDeclarationNode v in Fields.Expressions)
                    {
                        fields.Add(v.Id, v.RType);
                        alias.Add(new TypeNode(v.RType, v.Line, v.CharPositionInLine));
                    }
                }
                scope.InsertType(Id, new RecordType(fields, Id));
                scope.InsertArrayOrRecordAlias(alias.ToArray());
            }

            return result;
        }
    }
}
