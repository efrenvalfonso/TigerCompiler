using System.Collections.Generic;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigerCompiler.MyTypes;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode.ControlNode.ConditionalNode
{
    internal class IfThenElseNode : ConditionalNode
    {
        private LanguageNode ConditionalExpression
        {
            get { return (LanguageNode)GetChild(0); }
        }

        private LanguageNode ThenExpression
        {
            get { return (LanguageNode)GetChild(1); }
        }

        private LanguageNode ElseExpression
        {
            get { return (LanguageNode)GetChild(2); }
        }

        public IfThenElseNode(IToken token)
            : base(token)
        {
        }

        public override bool CheckSemantic(Scope scope, List<Error> errors)
        {
            NodeType = new VoidType();
            bool ceChS = ConditionalExpression.CheckSemantic(scope, errors),
                 teChS = ThenExpression.CheckSemantic(scope, errors),
                 eChS = ElseExpression.CheckSemantic(scope, errors),
                 result = ceChS && teChS && eChS;

            if (ceChS && !(ConditionalExpression.NodeType is IntType))
            {
                result = false;
                if (!(ConditionalExpression.NodeType is ErrorType))
                    errors.Add(
                        new Error(
                            string.Format("Cannot implicitly convert type '{0}' to 'int'",
                                          ConditionalExpression.NodeType), ConditionalExpression.Line,
                            ConditionalExpression.CharPositionInLine));

                NodeType = new ErrorType();
            }
            bool isDistinct = scope.IsDistinct(ThenExpression.NodeType, ElseExpression.NodeType);
            if (teChS && eChS && isDistinct)
            {
                result = false;
                if (!(ThenExpression.NodeType is ErrorType || ElseExpression.NodeType is ErrorType))
                    errors.Add(
                        new Error(
                            string.Format(
                                "Cannot implicitly convert type '{0}' to '{1}' and vice versa. The then and else bodies must return the same type'",
                                ThenExpression.NodeType, ElseExpression.NodeType), Line, CharPositionInLine));

                NodeType = new ErrorType();
            }
            if (!isDistinct) NodeType = ThenExpression.NodeType;
            return result;
        }

        public override void GenerateCode(ILGenerator codeGenerator)
        {
            Label endLabel = codeGenerator.DefineLabel(),
                  elseLabel = codeGenerator.DefineLabel();
            ConditionalExpression.GenerateCode(codeGenerator);
            codeGenerator.Emit(OpCodes.Brfalse, elseLabel);
            ThenExpression.GenerateCode(codeGenerator);
            codeGenerator.Emit(OpCodes.Br, endLabel);
            codeGenerator.MarkLabel(elseLabel);
            ElseExpression.GenerateCode(codeGenerator);
            codeGenerator.MarkLabel(endLabel);
        }
    }
}