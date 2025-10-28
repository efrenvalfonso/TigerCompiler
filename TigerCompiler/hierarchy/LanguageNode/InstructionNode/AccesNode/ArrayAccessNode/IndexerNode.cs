using System.Collections.Generic;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigerCompiler.MyTypes;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode.AccesNode.ArrayAccessNode
{
    class IndexerNode : AccessNode
    {
        public IndexerNode(IToken token)
            : base(token)
        {
        }

        public override bool CheckSemantic(Scope scope, List<Error> errors)
        {
            bool result = LeftValue.CheckSemantic(scope, errors);
            
            if (!(LeftValue.NodeType is ErrorType))
                if (!(LeftValue.NodeType is ArrayType))
                {
                    result = false;
                    errors.Add(
                        new Error(
                            string.Format("Cannot apply indexing with [] to an expression of type '{0}'",
                                          LeftValue.NodeType),
                            LeftValue.Line, LeftValue.CharPositionInLine));
                    NodeType = new ErrorType();
                }
                else
                {
                    var arrayType = (ArrayType)LeftValue.NodeType;
                    NodeType = scope.GetMyType(arrayType.GetElementsType);
                    CodeGeneratorType = NodeType.DotNetType;
                }
            else NodeType = new ErrorType();

            result = Access.CheckSemantic(scope, errors) && result;
            if (!(Access.NodeType is IntType))
            {
                if (!(Access.NodeType is ErrorType))
                    errors.Add(new Error(
                                   string.Format("Cannot implicitly convert type '{0}' to 'int'", Access.NodeType),
                                   Access.Line, Access.CharPositionInLine));
                result = false;
                NodeType = new ErrorType();
            }
            return result;
        }

        public override void GenerateCode(ILGenerator codeGenerator)
        {
            LeftValue.GenerateCode(codeGenerator);
            Access.GenerateCode(codeGenerator);
            codeGenerator.Emit(OpCodes.Ldelem, CodeGeneratorType);
        }
    }
}
