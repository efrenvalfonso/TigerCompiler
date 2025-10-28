using System.Collections.Generic;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigerCompiler.MyTypes;
using TigerCompiler.hierarchy.LanguageNode.DeclarationNode.VarDeclarationNode;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode
{ // puede que haya que setearle el CodeGeneraorType; por ahora resuleve con el NodeType
    public class RecordAssignmentNode : InstructionNode
    {
        public RecordAssignmentNode(IToken token)
            : base(token)
        {
        }

        private string Id
        {
            get { return GetChild(0).Text; }
        }

        private ExpressionSequenceNode Fields
        {
            get
            {
                if (ChildCount == 3) return (ExpressionSequenceNode)GetChild(1);
                if (ChildCount == 2 && !(GetChild(1) is IdentificatorVariableNode))
                    return (ExpressionSequenceNode)GetChild(1);
                return null;
            }
        }

        public override bool CheckSemantic(Scope scope, List<Error> errors)
        {
            bool result = true;
            if (!scope.ContainType(Id))
            {
                result = false;
                errors.Add(new Error(string.Format("The type named '{0}' is not defined in this scope", Id),
                                     GetChild(0).Line, GetChild(0).CharPositionInLine));
                NodeType = new ErrorType();
            }
            else
            {
                var type = scope.GetMyType(Id);
                if (!(type is RecordType))
                {
                    result = false;
                    errors.Add(new Error(string.Format("The type named '{0}' is must be a record type", Id),
                                         GetChild(0).Line, GetChild(0).CharPositionInLine));
                    NodeType = new ErrorType();
                }
                else
                {
                    var recordType = (RecordType)type;
                    if (Fields != null)
                        if (Fields.Expressions.Count != recordType.Fields.Count)
                            errors.Add(
                                new Error(
                                    string.Format("The record '{0}' cannot take {1} field{2}", Id,
                                                  Fields.Expressions.Count, Fields.Expressions.Count == 1 ? "" : "s"),
                                    Line, CharPositionInLine));
                        else
                        {
                            int i = 0;
                            foreach (var key in recordType.Fields)
                                if (i < Fields.Expressions.Count)
                                {
                                    var f = (FieldAssignmentNode)Fields.Expressions[i];
                                    f.CheckSemantic(scope, errors);
                                    if (f.Name != key.Key)
                                        errors.Add(
                                            new Error(
                                                string.Format(
                                                    "Field {0}: the field name '{1}' is wrong, '{2}' expected", i + 1,
                                                    f.Name, key.Key), f.Line, f.CharPositionInLine));
                                    else
                                    {
                                        var fieldType = scope.GetMyType(key.Value);
                                        if (scope.IsDistinct(fieldType, f.NodeType))
                                            if (f.NodeType is ErrorType)
                                                errors.Add(
                                                    new Error(
                                                        string.Format("Field {0}: field is wrong, '{1}' expected",
                                                                      i + 1, fieldType), f.Line, f.CharPositionInLine));
                                            else
                                                errors.Add(
                                                    new Error(
                                                        string.Format("Field {0}: cannot convert from '{1}' to '{2}'",
                                                                      i + 1, f.NodeType, fieldType), f.Line,
                                                        f.CharPositionInLine));
                                    }
                                    i++;
                                }
                        }

                    NodeType = recordType;
                }
            }
            return result;
        }

        public override void GenerateCode(ILGenerator codeGenerator)
        {
            if (Fields != null)
                foreach (var field in Fields.Expressions)
                    field.GenerateCode(codeGenerator);
            // ir a la clase FieldAssigment y generar el codigo de su expresion
            codeGenerator.Emit(OpCodes.Newobj, NodeType.ConstructorBuilder);
        }
    }
}
