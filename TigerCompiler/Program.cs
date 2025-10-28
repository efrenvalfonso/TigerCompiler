using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigerCompiler.hierarchy.LanguageNode;

namespace TigerCompiler
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Tiger Compiler version 1.0" + '\n' +
                              "Copyright (C) 2011-2012 Leobel Izquierdo Alvarez & Efren Vila Alfonso" + '\n');

            var file = new FileInfo(args[0]);

            if (file.Exists)
            {
                var input = new ANTLRFileStream(file.FullName);
                var lexer = new TigerLexer(input);
                var tokens = new CommonTokenStream(lexer);
                var parser = new TigerParser(tokens) { TreeAdaptor = new AstConverter() };
                var result = parser.program();

                if (lexer.Errors.Count == 0 && parser.Errors.Count == 0)
                {
                    string outputFileName = Path.ChangeExtension(file.FullName, ".exe");
                    var codeGenerator = CodeGenerator.StartCompilation(outputFileName);
                    var exppression = (LanguageNode)(result.Tree);
                    var errors = new List<Error>();

                    exppression.CheckSemantic(new Scope(), errors);

                    if (errors.Count == 0)
                    {
                        #region try


                        LocalBuilder exception = codeGenerator.DeclareLocal(typeof(Exception)),
                                     separator = codeGenerator.DeclareLocal(typeof(char[])),
                                     splittedText = codeGenerator.DeclareLocal(typeof(string[])),
                                     splitIndex = codeGenerator.DeclareLocal(typeof(int));

                        codeGenerator.BeginExceptionBlock();

                        exppression.GenerateCode(codeGenerator);

                        #endregion

                        #region catch

                        codeGenerator.BeginCatchBlock(typeof(Exception));

                        // guardar la excepcion
                        codeGenerator.Emit(OpCodes.Stloc, exception);
                        //-------------------

                        // crear el array de char con '.'
                        codeGenerator.Emit(OpCodes.Ldc_I4_1);
                        codeGenerator.Emit(OpCodes.Newarr, typeof(char));
                        codeGenerator.Emit(OpCodes.Stloc, separator);
                        codeGenerator.Emit(OpCodes.Ldloc, separator);
                        codeGenerator.Emit(OpCodes.Ldc_I4_0);
                        codeGenerator.Emit(OpCodes.Ldc_I4_S, 46);
                        codeGenerator.Emit(OpCodes.Stelem, typeof(char));
                        // ------------------------------

                        codeGenerator.Emit(OpCodes.Ldstr, "Exception of type \'");

                        // crear el array de string y guardarlo
                        codeGenerator.Emit(OpCodes.Ldloc, exception);
                        codeGenerator.Emit(OpCodes.Callvirt,
                                           typeof(Exception).GetMethod("GetType", Type.EmptyTypes));
                        codeGenerator.Emit(OpCodes.Callvirt,
                                           typeof(Type).GetMethod("ToString", Type.EmptyTypes));
                        codeGenerator.Emit(OpCodes.Ldloc, separator);
                        codeGenerator.Emit(OpCodes.Callvirt,
                                           typeof(string).GetMethod("Split", new[] { typeof(char[]) }));
                        codeGenerator.Emit(OpCodes.Stloc, splittedText);
                        // ------------------------------------

                        // guardar el Length del array de string y restarle 1
                        codeGenerator.Emit(OpCodes.Ldloc, splittedText);
                        codeGenerator.Emit(OpCodes.Callvirt,
                                           typeof(string).GetProperty("Length").GetGetMethod());
                        codeGenerator.Emit(OpCodes.Ldc_I4_1);
                        codeGenerator.Emit(OpCodes.Sub);
                        codeGenerator.Emit(OpCodes.Stloc, splitIndex);
                        // -------------------------------------------------

                        // cargar el valor en la posicion Length - 1 del array
                        codeGenerator.Emit(OpCodes.Ldloc, splittedText);
                        codeGenerator.Emit(OpCodes.Ldloc, splitIndex);
                        codeGenerator.Emit(OpCodes.Ldelem, typeof(string));
                        // ---------------------------------------------------

                        codeGenerator.Emit(OpCodes.Ldstr, "\' was thrown.");
                        codeGenerator.Emit(OpCodes.Call,
                                           typeof(string).GetMethod("Concat",
                                                                     new[]
                                                                         {
                                                                             typeof (object),
                                                                             typeof (object),
                                                                             typeof (object)
                                                                         }));

                        // poner las letras de la consola amarillas.
                        codeGenerator.Emit(OpCodes.Ldc_I4_S, 14);
                        codeGenerator.Emit(OpCodes.Call, typeof(Console).GetProperty("ForegroundColor").GetSetMethod());
                        // -----------------------------------------

                        codeGenerator.Emit(OpCodes.Call,
                                           typeof(Console).GetMethod("WriteLine", new[] { typeof(string) }));

                        // resetear a su color original las letras de la consola amarillas.
                        codeGenerator.Emit(OpCodes.Call, typeof(Console).GetMethod("ResetColor"));
                        // -----------------------------------------

                        codeGenerator.Emit(OpCodes.Ldc_I4_1);
                        codeGenerator.Emit(OpCodes.Call, typeof(Environment).GetMethod("Exit", new[] { typeof(int) }));

                        codeGenerator.EndExceptionBlock();

                        #endregion

                        codeGenerator.Emit(OpCodes.Ret);

                        CodeGenerator.SaveCompilation();
                    }
                    else foreach (var error in errors) Console.WriteLine(error.ToString() + '\n');
                }
                else
                {
                    foreach (var error in lexer.Errors) Console.WriteLine(error.ToString() + '\n');
                    foreach (var error in parser.Errors) Console.WriteLine(error.ToString() + '\n');
                }
            }
            else Console.WriteLine(new Error("File '" + file.FullName + "' cannot be found", 0, 0).ToString());
            Console.ReadLine();
        }
    }
}