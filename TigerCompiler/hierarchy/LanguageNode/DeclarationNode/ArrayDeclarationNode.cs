using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigerCompiler.MyTypes;

namespace TigerCompiler.hierarchy.LanguageNode.DeclarationNode
{
    class ArrayDeclarationNode : DeclarationNode
    {

        public ArrayDeclarationNode(IToken token)
            : base(token)
        {
        }

        private LanguageNode ArrayLength
        {
            get { return (LanguageNode)GetChild(1); }
        }

        private LanguageNode ArrayInitValue
        {
            get { return (LanguageNode)GetChild(2); }
        }

        public override bool CheckSemantic(Scope scope, List<Error> errors)
        {
            bool result = ArrayLength.CheckSemantic(scope, errors);
            result = ArrayInitValue.CheckSemantic(scope, errors) && result;

            var arrayType = scope.GetMyType(Id);

            NodeType = arrayType;

            if (!(arrayType is ArrayType))
            {
                result = false;
                errors.Add(
                    new Error(string.Format("'{0}' must be an array", Id), GetChild(0).Line,
                              GetChild(0).CharPositionInLine));
                NodeType = new ErrorType();
            }

            var arrayLengthType = ArrayLength.NodeType;
            if (!(arrayLengthType is IntType))
            {
                result = false;
                NodeType = new ErrorType();
                if (!(arrayLengthType is ErrorType))
                    errors.Add(
                        new Error(string.Format("Cannot implicitly convert type '{0}' to 'int'", arrayLengthType),
                                  ArrayLength.Line, ArrayLength.CharPositionInLine));
            }

            var arrayInitialValueType = ArrayInitValue.NodeType;
            if (result)
            {
                arrayType = scope.GetMyType((arrayType as ArrayType).GetElementsType);
                if (scope.IsDistinct(arrayType, arrayInitialValueType))
                {
                    result = false;
                    NodeType = new ErrorType();
                    if (!(arrayInitialValueType is ErrorType || arrayType is ErrorType))
                        errors.Add(
                            new Error(
                                string.Format("Cannot implicitly convert type '{0}' to '{1}'", arrayInitialValueType,
                                              arrayType), ArrayInitValue.Line, ArrayInitValue.CharPositionInLine));
                }
                CodeGeneratorType = arrayType.DotNetType;
            }
            return result;
        }

        public override void GenerateCode(ILGenerator codeGenerator)
        {
            var index = codeGenerator.DeclareLocal(typeof(int));
            codeGenerator.Emit(OpCodes.Ldc_I4_0);
            codeGenerator.Emit(OpCodes.Stloc, index);

            var length = codeGenerator.DeclareLocal(typeof(int));
            ArrayLength.GenerateCode(codeGenerator);                        //crea el tamanno del array
            codeGenerator.Emit(OpCodes.Dup);
            codeGenerator.Emit(OpCodes.Stloc, length);                      //la variable local de indice 1 es para el length del array 


            var array = codeGenerator.DeclareLocal(typeof(Array));
            codeGenerator.Emit(OpCodes.Newarr, CodeGeneratorType);          //crea el array
            codeGenerator.Emit(OpCodes.Stloc, array);                       //guarda el array en la variable local de indice 2

            Label label1 = codeGenerator.DefineLabel(),
                label2 = codeGenerator.DefineLabel();

            codeGenerator.Emit(OpCodes.Br, label1);                         //va para la condicion
            codeGenerator.MarkLabel(label2);                                //marca la etiqueta           
            codeGenerator.Emit(OpCodes.Ldloc, array);                       //pone el array
            codeGenerator.Emit(OpCodes.Ldloc, index);                       //pone el index en la pila             
            ArrayInitValue.GenerateCode(codeGenerator);
            codeGenerator.Emit(OpCodes.Stelem, CodeGeneratorType);          //rellena el array
            #region suma uno al indice
            codeGenerator.Emit(OpCodes.Ldloc, index);                       //pone en la pila el index
            codeGenerator.Emit(OpCodes.Ldc_I4_1);                           //pone un uno en la pila
            codeGenerator.Emit(OpCodes.Add);                                //aumenta el length del array
            codeGenerator.Emit(OpCodes.Stloc, index);                       //actualiza el index
            #endregion
            codeGenerator.MarkLabel(label1);                                //marca la etiqueta
            codeGenerator.Emit(OpCodes.Ldloc, index);                       // pone el index
            codeGenerator.Emit(OpCodes.Ldloc, length);                      // pone el length
            codeGenerator.Emit(OpCodes.Blt, label2);                        /*compara si el index es <= que el length,
                                                                             * si se cumple se hace una iteracion*/
            codeGenerator.Emit(OpCodes.Ldloc, array);                       // el array se queda en el tope de la pila
        }
    }
}
