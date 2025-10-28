using System.Collections.Generic;
using Antlr.Runtime;
using TigerCompiler.MyTypes;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode.OperationNode.BinaryNode.ShortCircuitBinaryNode.
    LogicalNode
{
    internal abstract class LogicalNode : ShortCircuitBinaryNode
    {
        protected LogicalNode(IToken token)
            : base(token)
        {
        }

        public override bool CheckSemantic(Scope scope, List<Error> errors)
        {
            NodeType = new IntType();
            bool lvChS = LeftValue.CheckSemantic(scope, errors),
                 rvChS = RightValue.CheckSemantic(scope, errors),
                 result = lvChS && rvChS;

            if (lvChS && !(LeftValue.NodeType is IntType))
            {
                result = false;
                NodeType = new ErrorType();
                if (!(LeftValue.NodeType is ErrorType))
                    errors.Add(
                        new Error(
                            string.Format("Cannot implicitly convert type '{0}' to 'int'", LeftValue.NodeType),
                            LeftValue.Line, LeftValue.CharPositionInLine));
            }

            if (rvChS && !(RightValue.NodeType is IntType))
            {
                result = false;
                NodeType = new ErrorType();
                if (!(RightValue.NodeType is ErrorType))
                    errors.Add(
                        new Error(
                            string.Format("Cannot implicitly convert type '{0}' to 'int'", RightValue.NodeType),
                            RightValue.Line, RightValue.CharPositionInLine));
            }

            return result;
        }
    }
}
