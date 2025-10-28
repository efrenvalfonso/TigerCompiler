using System.Collections.Generic;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigerCompiler.MyTypes;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode.AccesNode.FieldAccessNode
{
    internal class FieldAccessNode : AccessNode
    {
        public FieldAccessNode(IToken token)
            : base(token)
        {
        }

        private string Name
        {
            get { return LeftValue.Text; }
        }

        public override bool CheckSemantic(Scope scope, List<Error> errors)
        {
            bool result = LeftValue.CheckSemantic(scope, errors);
            if (!(LeftValue.NodeType is RecordType))
            {
                result = false;
                NodeType = new ErrorType();
                if (!(LeftValue.NodeType is ErrorType))
                    errors.Add(
                    new Error(string.Format("Cannot implicitly convert type '{0}' to 'record'", LeftValue.NodeType),
                              LeftValue.Line, LeftValue.CharPositionInLine));
            }
            else
            {
                var recordType = (RecordType)LeftValue.NodeType;
                CodeGeneratorType = recordType.DotNetType;
                if (!recordType.Fields.ContainsKey(Access.Text))
                {
                    result = false;
                    errors.Add(new Error(
                                   string.Format("'{0}' does not contain a field named '{1}'", Name, Access.Text),
                                   Access.Line, Access.CharPositionInLine));
                    NodeType = new ErrorType();
                }
                else
                    NodeType = scope.GetMyType(recordType.Fields[Access.Text]);
            }
            return result;
        }

        public override void GenerateCode(ILGenerator codeGenerator)
        {
            LeftValue.GenerateCode(codeGenerator);
            codeGenerator.Emit(OpCodes.Ldfld,
                                           CodeGeneratorType.GetField(
                                               Access.Text));
        }
    }
}