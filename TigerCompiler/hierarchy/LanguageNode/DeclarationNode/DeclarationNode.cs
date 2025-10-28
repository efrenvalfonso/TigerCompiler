using System.Collections.Generic;
using Antlr.Runtime;
using TigerCompiler.hierarchy.LanguageNode.DeclarationNode.TypeDeclarationNode;
using TigerCompiler.hierarchy.LanguageNode.InstructionNode;


namespace TigerCompiler.hierarchy.LanguageNode.DeclarationNode
{
    public abstract class DeclarationNode : LanguageNode
    {
        private string _id;

        protected DeclarationNode(IToken token)
            : base(token)
        {
        }

        public string Id
        {
            get { return _id ?? (_id = GetChild(0).Text); }
            protected set { _id = value; }
        }

        protected bool FieldsOk(List<string> names, ExpressionSequenceNode expressionSequence, List<Error> errors)
        {
            bool result = true;
            if (expressionSequence != null)
            {

                foreach (var expression in expressionSequence.Expressions)
                {
                    var field = (FieldTypeDeclarationNode)expression;

                    if (names.Contains(field.Id))
                    {
                        result = false;
                        string message = this is RecordTypeDeclarationNode
                                             ? string.Format("The record '{0}' already contains a definition for '{1}'", Id, field.Id)
                                             : string.Format("The parameter name '{0}' of the function '{1}' is duplicated", field.Id, Id);
                        errors.Add(new Error(message, field.Line, field.CharPositionInLine));
                    }
                    else
                    {
                        names.Add(field.Id);
                    }
                }
            }
            return result;
        }
    }
}
