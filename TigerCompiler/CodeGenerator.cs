using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;

namespace TigerCompiler
{
    public delegate MethodBuilder LoadStandardLibraryFunction(TypeBuilder containerClass);

    public static class CodeGenerator
    {
        public static ILGenerator StartCompilation(string fileName)
        {
            OutputFileName = fileName;

            Assembly = AppDomain.CurrentDomain.DefineDynamicAssembly(new AssemblyName { Name = "TigerCompiler" },
                                                                     AssemblyBuilderAccess.RunAndSave,
                                                                     Path.GetDirectoryName(OutputFileName));
            ModuleBuilder = Assembly.DefineDynamicModule("TigerProgram", Path.GetFileName(OutputFileName));
            ProgramClass = ModuleBuilder.DefineType("Program", TypeAttributes.Public | TypeAttributes.Class);
            ProgramParent = ProgramClass.DefineField("Parent", ProgramClass, FieldAttributes.Public);
            IntegerVariables = ProgramClass.DefineField("integerVariables", typeof (int[]), FieldAttributes.Public);
            ReferenceVariables = ProgramClass.DefineField("referenceVariables", typeof (object[]),
                                                          FieldAttributes.Public);

            ProgramConstructor = ProgramClass.DefineConstructor(MethodAttributes.Public, CallingConventions.Standard,
                                                                new[] {ProgramClass, typeof (int), typeof (int)});

            var programConstructorILGenerator = ProgramConstructor.GetILGenerator();
            programConstructorILGenerator.Emit(OpCodes.Ldarg_0);
            programConstructorILGenerator.Emit(OpCodes.Ldarg_1);
            programConstructorILGenerator.Emit(OpCodes.Stfld, ProgramParent);
            programConstructorILGenerator.Emit(OpCodes.Ldarg_0);
            programConstructorILGenerator.Emit(OpCodes.Ldarg_2);
            programConstructorILGenerator.Emit(OpCodes.Newarr, typeof (int));
            programConstructorILGenerator.Emit(OpCodes.Stfld, IntegerVariables);
            programConstructorILGenerator.Emit(OpCodes.Ldarg_0);
            programConstructorILGenerator.Emit(OpCodes.Ldarg_3);
            programConstructorILGenerator.Emit(OpCodes.Newarr, typeof (object));
            programConstructorILGenerator.Emit(OpCodes.Stfld, ReferenceVariables);
            programConstructorILGenerator.Emit(OpCodes.Ret);

            GoToItScopeMethod = ProgramClass.DefineMethod("GoToScope", MethodAttributes.Public, ProgramClass,
                                                          new[] {typeof (int)});
            var goToAncestorMethodILGenerator = GoToItScopeMethod.GetILGenerator();
            Label whileLabel = goToAncestorMethodILGenerator.DefineLabel(),
                  endLabel = goToAncestorMethodILGenerator.DefineLabel();
            goToAncestorMethodILGenerator.DeclareLocal(ProgramClass);
            goToAncestorMethodILGenerator.Emit(OpCodes.Ldarg_0);
            goToAncestorMethodILGenerator.Emit(OpCodes.Stloc_0);
            goToAncestorMethodILGenerator.MarkLabel(whileLabel);
            goToAncestorMethodILGenerator.Emit(OpCodes.Ldarg_1);
            goToAncestorMethodILGenerator.Emit(OpCodes.Ldc_I4_0);
            goToAncestorMethodILGenerator.Emit(OpCodes.Ble, endLabel);
            goToAncestorMethodILGenerator.Emit(OpCodes.Ldloc_0);
            goToAncestorMethodILGenerator.Emit(OpCodes.Ldfld, ProgramParent);
            goToAncestorMethodILGenerator.Emit(OpCodes.Stloc_0);
            goToAncestorMethodILGenerator.Emit(OpCodes.Ldarg_1);
            goToAncestorMethodILGenerator.Emit(OpCodes.Ldc_I4_1);
            goToAncestorMethodILGenerator.Emit(OpCodes.Sub);
            goToAncestorMethodILGenerator.Emit(OpCodes.Starg_S, 1);
            goToAncestorMethodILGenerator.Emit(OpCodes.Br, whileLabel);
            goToAncestorMethodILGenerator.MarkLabel(endLabel);
            goToAncestorMethodILGenerator.Emit(OpCodes.Ldloc_0);
            goToAncestorMethodILGenerator.Emit(OpCodes.Ret);

            MainMethod = ProgramClass.DefineMethod("Main", MethodAttributes.Public | MethodAttributes.Static,
                                                   CallingConventions.Standard, typeof (void), Type.EmptyTypes);
            var mainMethodILGenerator = MainMethod.GetILGenerator();
            mainMethodILGenerator.DeclareLocal(ProgramClass);
            mainMethodILGenerator.Emit(OpCodes.Ldnull);
            mainMethodILGenerator.Emit(OpCodes.Ldc_I4_0);
            mainMethodILGenerator.Emit(OpCodes.Ldc_I4_0);
            mainMethodILGenerator.Emit(OpCodes.Newobj, ProgramConstructor);
            mainMethodILGenerator.Emit(OpCodes.Stloc_0);

            BreakLabels = new Stack<Label>();
            CalledStandardLibraryFunctions = new Dictionary<string, MethodBuilder>();
            DeclaredFunctionsAndCount = new Dictionary<string, int>();

            return mainMethodILGenerator;
        }

        public static void SaveCompilation()
        {
            ProgramClass.CreateType();
            Assembly.SetEntryPoint(MainMethod);
            Assembly.Save(Path.GetFileName(OutputFileName));
        }

        private static string OutputFileName { get; set; }

        private static AssemblyBuilder Assembly { get; set; }

        public static ModuleBuilder ModuleBuilder { get; set; }

        public static TypeBuilder ProgramClass { get; private set; }

        public static ConstructorBuilder ProgramConstructor { get; private set; }

        public static FieldBuilder ProgramParent { get; private set; }

        public static FieldBuilder IntegerVariables { get; private set; }

        public static FieldBuilder ReferenceVariables { get; private set; }

        public static MethodBuilder MainMethod { get; private set; }

        public static MethodBuilder GoToItScopeMethod { get; private set; }

        public static Stack<Label> BreakLabels { get; private set; }

        public static Dictionary<string, int> DeclaredFunctionsAndCount { get; private set; }

        public static Dictionary<string, MethodBuilder> CalledStandardLibraryFunctions =
            new Dictionary<string, MethodBuilder>();

        public static readonly Dictionary<string, LoadStandardLibraryFunction> StandardLibraryFunctions =
            new Dictionary<string, LoadStandardLibraryFunction>(14)
                {
                    {"print", Print},
                    {"printi", PrintI},
                    {"flush", Flush},
                    {"getchar", GetChar},
                    {"ord", Ord},
                    {"chr", Chr},
                    {"size", Size},
                    {"substring", Substring},
                    {"concat", Concat},
                    {"not", Not},
                    {"exit", Exit},
                    {"getline", GetLine},
                    {"printline", PrintLine},
                    {"parse", Parse}
                };

        public static bool IsStandardLibraryFunction(string functionId)
        {
            return StandardLibraryFunctions.ContainsKey(functionId);
        }

        #region Standard Library

        /// <summary>
        /// Print the string on the standard output.
        /// </summary>
        private static MethodBuilder Print(TypeBuilder containerClass)
        {
            var method = containerClass.DefineMethod("print",
                                                     MethodAttributes.FamANDAssem | MethodAttributes.Family |
                                                     MethodAttributes.Static,
                                                     typeof (void), new[] {typeof (string)});
            var printCodeGenerator = method.GetILGenerator();

            printCodeGenerator.Emit(OpCodes.Ldarg_0);
            printCodeGenerator.Emit(OpCodes.Call, typeof (Console).GetMethod("Write", new[] {typeof (string)}));
            printCodeGenerator.Emit(OpCodes.Ret);

            return method;
        }

        /// <summary>
        /// Print the integer on the standard output.
        /// </summary>
        private static MethodBuilder PrintI(TypeBuilder containerClass)
        {
            var method = containerClass.DefineMethod("printi",
                                                     MethodAttributes.FamANDAssem | MethodAttributes.Family |
                                                     MethodAttributes.Static,
                                                     typeof (void), new[] {typeof (int)});
            var printiCodeGenerator = method.GetILGenerator();

            printiCodeGenerator.Emit(OpCodes.Ldarg_0);
            printiCodeGenerator.Emit(OpCodes.Call, typeof (Console).GetMethod("Write", new[] {typeof (int)}));
            printiCodeGenerator.Emit(OpCodes.Ret);

            return method;
        }

        /// <summary>
        /// Flush the standard output buffer.
        /// </summary>
        private static MethodBuilder Flush(TypeBuilder containerClass)
        {
            var method = containerClass.DefineMethod("flush",
                                                     MethodAttributes.FamANDAssem | MethodAttributes.Family |
                                                     MethodAttributes.Static,
                                                     typeof (void), new Type[0]);
            var flushCodeGenerator = method.GetILGenerator();

            flushCodeGenerator.Emit(OpCodes.Call, typeof (Console).GetProperty("Out").GetGetMethod());
            flushCodeGenerator.Emit(OpCodes.Callvirt, typeof (TextWriter).GetMethod("Flush"));
            flushCodeGenerator.Emit(OpCodes.Ret);

            return method;
        }

        /// <summary>
        /// Read and return a character from standard input; return an empty string at end-of-file.
        /// </summary>
        private static MethodBuilder GetChar(TypeBuilder containerClass)
        {
            var method = containerClass.DefineMethod("getchar",
                                                     MethodAttributes.FamANDAssem | MethodAttributes.Family |
                                                     MethodAttributes.Static,
                                                     typeof (string), new Type[0]);
            var getCharCodeGenerator = method.GetILGenerator();

            getCharCodeGenerator.Emit(OpCodes.Call, typeof (Console).GetMethod("Read"));
            getCharCodeGenerator.Emit(OpCodes.Call, typeof (Convert).GetMethod("ToChar", new[] {typeof (int)}));
            getCharCodeGenerator.Emit(OpCodes.Call, typeof (char).GetMethod("ToString", new[] {typeof (char)}));
            getCharCodeGenerator.Emit(OpCodes.Ret);

            return method;
        }

        /// <summary>
        /// Return the ASCII value of the first character of s, or -1 if s is empty.
        /// </summary>
        private static MethodBuilder Ord(TypeBuilder containerClass)
        {
            var method = containerClass.DefineMethod("ord",
                                                     MethodAttributes.FamANDAssem | MethodAttributes.Family |
                                                     MethodAttributes.Static, typeof (int), new[] {typeof (string)});
            var ordCodeGenerator = method.GetILGenerator();

            Label zeroLenghtLabel = ordCodeGenerator.DefineLabel(),
                  endLabel = ordCodeGenerator.DefineLabel();
            ordCodeGenerator.Emit(OpCodes.Ldarg_0);
            ordCodeGenerator.Emit(OpCodes.Dup);
            ordCodeGenerator.Emit(OpCodes.Callvirt, typeof (string).GetProperty("Length").GetGetMethod());
            ordCodeGenerator.Emit(OpCodes.Brfalse, zeroLenghtLabel);
            ordCodeGenerator.Emit(OpCodes.Ldc_I4_0);
            ordCodeGenerator.Emit(OpCodes.Callvirt, typeof (string).GetProperty("Chars").GetGetMethod());
            ordCodeGenerator.Emit(OpCodes.Call, typeof (Convert).GetMethod("ToInt32", new[] {typeof (char)}));
            ordCodeGenerator.Emit(OpCodes.Br, endLabel);
            ordCodeGenerator.MarkLabel(zeroLenghtLabel);
            ordCodeGenerator.Emit(OpCodes.Pop);
            ordCodeGenerator.Emit(OpCodes.Ldc_I4, -1);
            ordCodeGenerator.MarkLabel(endLabel);
            ordCodeGenerator.Emit(OpCodes.Ret);

            return method;
        }

        /// <summary>
        /// Return a single-character string for ASCII value i. Terminate program if i is out of range.
        /// </summary>
        private static MethodBuilder Chr(TypeBuilder containerClass)
        {
            var method = containerClass.DefineMethod("chr",
                                                     MethodAttributes.FamANDAssem | MethodAttributes.Family |
                                                     MethodAttributes.Static, typeof (string), new[] {typeof (int)});
            var chrCodeGenerator = method.GetILGenerator();

            Label outOfRangeLabel = chrCodeGenerator.DefineLabel(),
                  endLabel = chrCodeGenerator.DefineLabel();

            chrCodeGenerator.Emit(OpCodes.Ldarg_0);
            chrCodeGenerator.Emit(OpCodes.Ldc_I4_0);
            chrCodeGenerator.Emit(OpCodes.Blt, outOfRangeLabel);
            chrCodeGenerator.Emit(OpCodes.Ldc_I4, 128);
            chrCodeGenerator.Emit(OpCodes.Ldarg_0);
            chrCodeGenerator.Emit(OpCodes.Ble, outOfRangeLabel);
            chrCodeGenerator.Emit(OpCodes.Ldarg_0);
            chrCodeGenerator.Emit(OpCodes.Call, typeof (Convert).GetMethod("ToChar", new[] {typeof (int)}));
            chrCodeGenerator.Emit(OpCodes.Call, typeof (char).GetMethod("ToString", new[] {typeof (char)}));
            chrCodeGenerator.Emit(OpCodes.Br, endLabel);
            chrCodeGenerator.MarkLabel(outOfRangeLabel);
            chrCodeGenerator.Emit(OpCodes.Ldc_I4_1);
            chrCodeGenerator.Emit(OpCodes.Call, typeof (Environment).GetMethod("Exit", new[] {typeof (int)}));
            chrCodeGenerator.MarkLabel(endLabel);
            chrCodeGenerator.Emit(OpCodes.Ret);

            return method;
        }

        /// <summary>
        /// Return the number of characters in s.
        /// </summary>
        private static MethodBuilder Size(TypeBuilder containerClass)
        {
            var method = containerClass.DefineMethod("size",
                                                     MethodAttributes.FamANDAssem | MethodAttributes.Family |
                                                     MethodAttributes.Static, typeof (int), new[] {typeof (string)});
            var sizeCodeGenerator = method.GetILGenerator();

            sizeCodeGenerator.Emit(OpCodes.Ldarg_0);
            sizeCodeGenerator.Emit(OpCodes.Callvirt, typeof (string).GetProperty("Length").GetGetMethod());
            sizeCodeGenerator.Emit(OpCodes.Ret);

            return method;
        }

        /// <summary>
        /// Return the substring of s starting at the character f (first character is numbered zero) and going for n characters.
        /// </summary>
        private static MethodBuilder Substring(TypeBuilder containerClass)
        {
            var method = containerClass.DefineMethod("substring",
                                                     MethodAttributes.FamANDAssem | MethodAttributes.Family |
                                                     MethodAttributes.Static, typeof (string),
                                                     new[] {typeof (string), typeof (int), typeof (int)});
            var substringCodeGenerator = method.GetILGenerator();

            substringCodeGenerator.Emit(OpCodes.Ldarg_0);
            substringCodeGenerator.Emit(OpCodes.Ldarg_1);
            substringCodeGenerator.Emit(OpCodes.Ldarg_2);
            substringCodeGenerator.Emit(OpCodes.Callvirt,
                                        typeof (string).GetMethod("Substring", new[] {typeof (int), typeof (int)}));
            substringCodeGenerator.Emit(OpCodes.Ret);

            return method;
        }

        /// <summary>
        /// Return a new string consisting of s1 followed by s2.
        /// </summary>
        private static MethodBuilder Concat(TypeBuilder containerClass)
        {
            var method = containerClass.DefineMethod("concat",
                                                     MethodAttributes.FamANDAssem | MethodAttributes.Family |
                                                     MethodAttributes.Static, typeof (string),
                                                     new[] {typeof (string), typeof (string)});
            var concatCodeGenerator = method.GetILGenerator();

            concatCodeGenerator.Emit(OpCodes.Ldarg_0);
            concatCodeGenerator.Emit(OpCodes.Ldarg_1);
            concatCodeGenerator.Emit(OpCodes.Call,
                                     typeof (string).GetMethod("Concat", new[] {typeof (string), typeof (string)}));
            concatCodeGenerator.Emit(OpCodes.Ret);

            return method;
        }

        /// <summary>
        /// Return 1 if i is zero, 0 otherwise.
        /// </summary>
        private static MethodBuilder Not(TypeBuilder containerClass)
        {
            var method = containerClass.DefineMethod("not",
                                                     MethodAttributes.FamANDAssem | MethodAttributes.Family |
                                                     MethodAttributes.Static, typeof (int), new[] {typeof (int)});
            var notCodeGenerator = method.GetILGenerator();

            notCodeGenerator.Emit(OpCodes.Ldarg_0);
            notCodeGenerator.Emit(OpCodes.Ldc_I4_0);
            notCodeGenerator.Emit(OpCodes.Ceq);
            notCodeGenerator.Emit(OpCodes.Ret);

            return method;
        }

        /// <summary>
        /// Terminate execution of the program with codeGenerator i.
        /// </summary>
        private static MethodBuilder Exit(TypeBuilder containerClass)
        {
            var method = containerClass.DefineMethod("exit",
                                                     MethodAttributes.FamANDAssem | MethodAttributes.Family |
                                                     MethodAttributes.Static, typeof (void), new[] {typeof (int)});
            var exitCodeGenerator = method.GetILGenerator();

            exitCodeGenerator.Emit(OpCodes.Ldarg_0);
            exitCodeGenerator.Emit(OpCodes.Call, typeof (Environment).GetMethod("Exit", new[] {typeof (int)}));
            exitCodeGenerator.Emit(OpCodes.Ret);

            return method;
        }

        /// <summary>
        /// Reads a line from the standard input (without include the change line character).
        /// </summary>
        private static MethodBuilder GetLine(TypeBuilder containerClass)
        {
            var method = containerClass.DefineMethod("getline",
                                                     MethodAttributes.FamANDAssem | MethodAttributes.Family |
                                                     MethodAttributes.Static, typeof (string), new Type[0]);
            var getlineCodeGenerator = method.GetILGenerator();

            getlineCodeGenerator.Emit(OpCodes.Call, typeof (Console).GetMethod("ReadLine"));
            getlineCodeGenerator.Emit(OpCodes.Ret);

            return method;
        }

        /// <summary>
        /// Prints the value of s to the standard output followed of change line character.
        /// </summary>
        private static MethodBuilder PrintLine(TypeBuilder containerClass)
        {
            var method = containerClass.DefineMethod("printline",
                                                     MethodAttributes.FamANDAssem | MethodAttributes.Family |
                                                     MethodAttributes.Static, typeof (void), new[] {typeof (string)});
            var printlineCodeGenerator = method.GetILGenerator();

            printlineCodeGenerator.Emit(OpCodes.Ldarg_0);
            printlineCodeGenerator.Emit(OpCodes.Call, typeof (Console).GetMethod("WriteLine", new[] {typeof (string)}));
            printlineCodeGenerator.Emit(OpCodes.Ret);

            return method;
        }

        /// <summary>
        /// Gets the int value of number represented by s if this is a valus number.
        /// </summary>
        private static MethodBuilder Parse(TypeBuilder containerClass)
        {
            var method = containerClass.DefineMethod("parse",
                                                     MethodAttributes.FamANDAssem | MethodAttributes.Family |
                                                     MethodAttributes.Static, typeof (int), new[] {typeof (string)});
            var parseCodeGenerator = method.GetILGenerator();

            parseCodeGenerator.Emit(OpCodes.Ldarg_0);
            parseCodeGenerator.Emit(OpCodes.Call, typeof (int).GetMethod("Parse", new[] {typeof (string)}));
            parseCodeGenerator.Emit(OpCodes.Ret);

            return method;
        }

        #endregion
    }
}