using System.Collections.Generic;
using Antlr.Runtime;
using System.Reflection.Emit;
using TigerCompiler.MyTypes;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode.ControlNode.LoopNode
{
    class WhileNode : LoopNode
    {
        public WhileNode(IToken token)
            : base(token)
        {
        }

        private LanguageNode Condition
        {
            get { return (LanguageNode)GetChild(0); }
        }

        private LanguageNode Body
        {
            get { return (LanguageNode)GetChild(1); }
        }

        public override bool CheckSemantic(Scope scope, List<Error> errors)
        {
            NodeType = new VoidType();
            bool result = Condition.CheckSemantic(scope, errors);

            if (!(Condition.NodeType is IntType)) // se evaluo bien pero no es un entero
            {
                result = false;
                NodeType = new ErrorType();
                if (!(Condition.NodeType is ErrorType))
                    errors.Add(
                        new Error(string.Format("Cannot implicitly convert type '{0}' to 'int'", Condition.NodeType),
                                  Condition.Line, Condition.CharPositionInLine));
            }

            result = Body.CheckSemantic(scope.NewScope(false, true), errors) && result;

            if (!(Body.NodeType is VoidType)) //el cuerpo del while debe retornar void
            {
                result = false;
                NodeType = new ErrorType();
                if (!(Body.NodeType is ErrorType))
                    errors.Add(
                        new Error(string.Format("Cannot implicitly convert type '{0}' to 'void'", Body.NodeType),
                                  Body.Line, Body.CharPositionInLine));
            }
            
            return result;
        }

        public override void GenerateCode(ILGenerator codeGenerator)
        {
            Label whileLabel = codeGenerator.DefineLabel(),
                  comparisonLabel = codeGenerator.DefineLabel(),
                  endLabel = codeGenerator.DefineLabel();
            CodeGenerator.BreakLabels.Push(endLabel);
            codeGenerator.Emit(OpCodes.Br, comparisonLabel);
            codeGenerator.MarkLabel(whileLabel);
            Body.GenerateCode(codeGenerator);
            codeGenerator.MarkLabel(comparisonLabel);
            Condition.GenerateCode(codeGenerator);
            codeGenerator.Emit(OpCodes.Brtrue, whileLabel);
            codeGenerator.MarkLabel(endLabel);
            CodeGenerator.BreakLabels.Pop();
        }
    }
}
