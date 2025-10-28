using System.Collections.Generic;
using System.Reflection.Emit;
using Antlr.Runtime;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode
{
    internal class FieldAssignmentNode : InstructionNode
    {
        public FieldAssignmentNode(IToken token)
            : base(token)
        {
        }

        public string Name
        {
            get { return GetChild(0).Text; }
        }

        private LanguageNode Expression
        {
            get { return (LanguageNode)GetChild(1); }
        }

        public override bool CheckSemantic(Scope scope, List<Error> errors)
        {
            bool result = Expression.CheckSemantic(scope, errors);
            NodeType = Expression.NodeType;
            return result;
        }

        public override void GenerateCode(ILGenerator codeGenerator)
        {
            Expression.GenerateCode(codeGenerator);
        }
    }
}