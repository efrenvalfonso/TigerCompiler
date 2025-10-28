using System.Collections.Generic;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigerCompiler.MyTypes;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode.ControlNode.ConditionalNode
{
    internal class IfThenNode : ConditionalNode
    {
        private LanguageNode ConditionalExpression
        {
            get { return (LanguageNode)GetChild(0); }
        }

        private LanguageNode ThenExpression
        {
            get { return (LanguageNode)GetChild(1); }
        }

        public IfThenNode(IToken token)
            : base(token)
        {
        }

        public override bool CheckSemantic(Scope scope, List<Error> errors)
        {
            NodeType = new VoidType();
            bool ceChs = ConditionalExpression.CheckSemantic(scope, errors),
                 teChs = ThenExpression.CheckSemantic(scope, errors),
                 result = ceChs && teChs;

            if (ceChs && !(ConditionalExpression.NodeType is IntType))
            {
                if (!(ConditionalExpression.NodeType is ErrorType))
                    errors.Add(
                        new Error(
                            string.Format("Cannot implicitly convert type '{0}' to 'int'",
                                          ConditionalExpression.NodeType), ConditionalExpression.Line,
                            ConditionalExpression.CharPositionInLine));

                NodeType = new ErrorType();
                result = false;
            }
            if (teChs && !(ThenExpression.NodeType is VoidType))
            {
                if (!(ThenExpression.NodeType is ErrorType))
                    errors.Add(
                        new Error(
                            string.Format("Cannot implicitly convert type '{0}' to 'void'", ThenExpression.NodeType),
                            ThenExpression.Line, ThenExpression.CharPositionInLine));

                NodeType = new ErrorType();
                result = false;
            }

            return result;
        }

        public override void GenerateCode(ILGenerator codeGenerator)
        {
            var endLabel = codeGenerator.DefineLabel();
            ConditionalExpression.GenerateCode(codeGenerator);
            codeGenerator.Emit(OpCodes.Brfalse, endLabel);
            ThenExpression.GenerateCode(codeGenerator);
            codeGenerator.MarkLabel(endLabel);
        }
    }
}