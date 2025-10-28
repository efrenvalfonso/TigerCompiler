using System.Collections.Generic;
using Antlr.Runtime;
using TigerCompiler.MyTypes;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode.OperationNode.UnaryNode
{
    public abstract class UnaryNode : OperationNode
    {
        protected UnaryNode(IToken token)
            : base(token)
        {
        }

        protected LanguageNode Node
        {
            get { return (LanguageNode)GetChild(0); }
        }

        public override bool CheckSemantic(Scope scope, List<Error> errors)
        {
            bool result = Node.CheckSemantic(scope, errors);
            NodeType = new IntType();
            if (!(Node.NodeType is IntType))
            {
                result = false;
                NodeType = new ErrorType();
                if (!(Node.NodeType is ErrorType))
                    errors.Add(
                        new Error(
                            string.Format("Cannot implicitly convert type '{0}' to 'int'", Node.NodeType),
                            Node.Line, Node.CharPositionInLine));
            }
            return result;
        }
    }
}
