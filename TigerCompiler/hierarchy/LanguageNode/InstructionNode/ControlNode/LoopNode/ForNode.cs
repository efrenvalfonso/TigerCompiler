using System.Collections.Generic;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigerCompiler.MyTypes;
using TigerCompiler.hierarchy.LanguageNode.DeclarationNode.VarDeclarationNode;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode.ControlNode.LoopNode
{
    internal class ForNode : LoopNode
    {
        public ForNode(IToken token)
            : base(token)
        {
        }

        private string Index
        {
            get { return GetChild(0).Text; }
        }

        private LanguageNode FromExpression
        {
            get { return (LanguageNode) GetChild(1); }
        }

        private LanguageNode ToExpression
        {
            get { return (LanguageNode) GetChild(2); }
        }

        private LanguageNode Body
        {
            get { return (LanguageNode) GetChild(3); }
        }

        public override bool CheckSemantic(Scope scope, List<Error> errors)
        {
            bool result = FromExpression.CheckSemantic(scope, errors);
            result = ToExpression.CheckSemantic(scope, errors) && result;
            NodeType = new VoidType();

            if (!(FromExpression.NodeType is IntType))
            {
                result = false;
                NodeType = new ErrorType();
                if (!(FromExpression.NodeType is ErrorType))
                    errors.Add(
                        new Error(
                            string.Format("Cannot implicitly convert type '{0}' to 'int'", FromExpression.NodeType),
                            FromExpression.Line, FromExpression.CharPositionInLine));
            }

            if (!(ToExpression.NodeType is IntType))
            {
                result = false;
                NodeType = new ErrorType();
                if (!(ToExpression.NodeType is ErrorType))
                    errors.Add(
                        new Error(string.Format("Cannot implicitly convert type '{0}' to 'int'", ToExpression.NodeType),
                                  ToExpression.Line, ToExpression.CharPositionInLine));
            }

            var newScope = scope.NewScope(true);
            var v = new VariableDeclarationNode(Index, FromExpression) { IsReadOnly = true, NodeType = new IntType() };
            newScope.InsertVariable(v);
            result = Body.CheckSemantic(newScope, errors) && result;

            if (!(Body.NodeType is VoidType))
            {
                result = false;
                NodeType = new ErrorType();
                if (!(Body.NodeType is ErrorType))
                    errors.Add(new Error(string.Format("Cannot implicitly convert type '{0}' to 'void'", Body.NodeType),
                                         Body.Line, Body.CharPositionInLine));
            }

            return result;
        }

        public override void GenerateCode(ILGenerator codeGenerator)
        {

            // carga la variable local de indice 0, this.
            codeGenerator.Emit(OpCodes.Ldloc_0);
            // carga el entero 2.
            codeGenerator.Emit(OpCodes.Ldc_I4_2);
            // carga el entero 0.
            codeGenerator.Emit(OpCodes.Ldc_I4_0);
            // crea una nueva instancia de tipo Program con los parametros this, 2, 0.
            codeGenerator.Emit(OpCodes.Newobj, CodeGenerator.ProgramConstructor);
            // duplica la instancia.
            codeGenerator.Emit(OpCodes.Dup);
            // carga el campo IntegerVariables de la clase Program.
            codeGenerator.Emit(OpCodes.Ldfld, CodeGenerator.IntegerVariables);
            // carga el entero 0.
            codeGenerator.Emit(OpCodes.Ldc_I4_0);
            // genera el codigo de FromExpression y carga el resultado.
            FromExpression.GenerateCode(codeGenerator);
            // setea el array IntegerVariables de la clase Program en el indice 0 con el resulado de la expresion Bottom.
            codeGenerator.Emit(OpCodes.Stelem_I4);
            // duplica la instancia.
            codeGenerator.Emit(OpCodes.Dup);
            // carga el campo IntegerVariables de la clase Program.
            codeGenerator.Emit(OpCodes.Ldfld, CodeGenerator.IntegerVariables);
            // carga el entero 1.
            codeGenerator.Emit(OpCodes.Ldc_I4_1);
            // genera el codigo de UpExpression y carga el resultado.
            ToExpression.GenerateCode(codeGenerator);
            // setea el array IntegerVariables de la clase Program en el indice 0 con el resulado de la expresion Bottom.
            codeGenerator.Emit(OpCodes.Stelem_I4);
            // guarda la instancia de Program creada en la variable local de indice cero.
            codeGenerator.Emit(OpCodes.Stloc_0);
            // crea la etiqueta endLabel.
            Label endLabel = codeGenerator.DefineLabel(),
                  // crea la etiqueta comparisonLabel.
                  comparisonLabel = codeGenerator.DefineLabel(),
                  // crea la etiqueta bodyLabel.
                  bodylabel = codeGenerator.DefineLabel();
            // pone en la pila de etiquetas del generador de codigo endLabel.
            CodeGenerator.BreakLabels.Push(endLabel);
            // salta al incremento del for.
            codeGenerator.Emit(OpCodes.Br, comparisonLabel);
            // marca el inicio del cuerpo del for.
            codeGenerator.MarkLabel(bodylabel);
            // genera el codigo de Body
            Body.GenerateCode(codeGenerator);
            // carga la variable local de indice 0.
            codeGenerator.Emit(OpCodes.Ldloc_0);
            // carga el campo IntegerVariables de la clase Program.
            codeGenerator.Emit(OpCodes.Ldfld, CodeGenerator.IntegerVariables);
            // carga el entero 0.
            codeGenerator.Emit(OpCodes.Ldc_I4_0);
            // carga la variable local de indice 0.
            codeGenerator.Emit(OpCodes.Ldloc_0);
            // carga el campo IntegerVariables de la clase Program.
            codeGenerator.Emit(OpCodes.Ldfld, CodeGenerator.IntegerVariables);
            // carga el entero 0.
            codeGenerator.Emit(OpCodes.Ldc_I4_0);
            // carga el valor array IntegerVariables de la clase Program en el indice 0.
            codeGenerator.Emit(OpCodes.Ldelem_I4);
            // carga el entero 1.
            codeGenerator.Emit(OpCodes.Ldc_I4_1);
            // le suma 1 al valor array IntegerVariables de la clase Program en el indice 0.
            codeGenerator.Emit(OpCodes.Add);
            // setea el array IntegerVariables de la clase Program en el indice 0 con el incremento.
            codeGenerator.Emit(OpCodes.Stelem_I4);
            // marca el incremento del for.
            codeGenerator.MarkLabel(comparisonLabel);
            // carga la variable local de indice 0.
            codeGenerator.Emit(OpCodes.Ldloc_0);
            // carga el campo IntegerVariables de la clase Program.
            codeGenerator.Emit(OpCodes.Ldfld, CodeGenerator.IntegerVariables);
            // carga el entero 0.
            codeGenerator.Emit(OpCodes.Ldc_I4_0);
            // carga el valor array IntegerVariables de la clase Program en el indice 0.
            codeGenerator.Emit(OpCodes.Ldelem_I4);
            // carga la variable local de indice 0.
            codeGenerator.Emit(OpCodes.Ldloc_0);
            // carga el campo IntegerVariables de la clase Program.
            codeGenerator.Emit(OpCodes.Ldfld, CodeGenerator.IntegerVariables);
            // carga el entero 1.
            codeGenerator.Emit(OpCodes.Ldc_I4_1);
            // carga el valor array IntegerVariables de la clase Program en el indice 1.
            codeGenerator.Emit(OpCodes.Ldelem_I4);
            // salta al cuerpo del for si Program.IntegerVariables[0] <= Program.IntegerVariables[1].
            codeGenerator.Emit(OpCodes.Ble, bodylabel);
            // marca el fin del for.
            codeGenerator.MarkLabel(endLabel);
            // carga la variable local de indice 0.
            codeGenerator.Emit(OpCodes.Ldloc_0);
            // carga el padre de la instancia de Program
            codeGenerator.Emit(OpCodes.Ldfld, CodeGenerator.ProgramParent);
            // pone en la variable local con indice 0 el padre de la instancia de Program.
            codeGenerator.Emit(OpCodes.Stloc_0);
            // quita de la pila de etiquetas del generador de codigo endLabel.
            CodeGenerator.BreakLabels.Pop();
        }
    }
}