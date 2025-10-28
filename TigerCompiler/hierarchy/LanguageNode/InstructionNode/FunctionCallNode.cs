using System.Collections.Generic;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigerCompiler.MyTypes;
using TigerCompiler.hierarchy.LanguageNode.DeclarationNode.ExpressionsSequenceDeclarationNode;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode
{
    internal class FunctionCallNode : InstructionNode
    {
        private int _distanceToScope;
        private List<MyType> _arguments;

        public FunctionCallNode(IToken token)
            : base(token)
        {
        }

        private string Id
        {
            get { return GetChild(0).Text; }
        }

        private List<MyType> Argument { get; set; }

        private ExpressionSequenceNode Parameter
        {
            get
            {
                if (ChildCount == 2 || ChildCount == 5)
                {
                    return (ExpressionSequenceNode)GetChild(1);
                }
                return null;
            }
        }

        private FunctionDeclarationNode Function { get; set; }

        public override bool CheckSemantic(Scope scope, List<Error> errors)
        {
            bool result = true;
            Argument = GetArgument(scope, errors); //los de la llamada.
            List<MyType> parameter;
            if (!scope.ContainFunctionInTable(Id, out parameter) && !scope.ContainFunction(Id, out parameter))
            //primero buscar en la tabla (scope mas cercano)
            {
                result = false;
                errors.Add(
                    new Error(
                        string.Format("The {0} '{1}' does not exist in current context",
                                      Parameter == null ? "procedure" : "function", Id),
                        Line, CharPositionInLine));
                NodeType = new ErrorType();
            }
            else if (parameter.Count != Argument.Count)
            {
                result = false;
                errors.Add(
                    new Error(string.Format("The {0} '{1}' cannot take {2} argument{3}",
                                            Parameter == null ? "procedure" : "function", Id,
                                            Argument.Count, Argument.Count == 1 ? "" : "s"), Line, CharPositionInLine));
            }
            else if (!scope.ParameterEquals(parameter, Argument))
            {
                result = false;

                errors.Add(new Error(string.Format("Function '{0}'has some invalid arguments", Id), Line,
                                     CharPositionInLine));

                var wrongArguments = new List<int>(parameter.Count);
                for (int i = 0; i < parameter.Count; i++)
                    if (parameter[i].GetType() != Argument[i].GetType()) wrongArguments.Add(i);

                foreach (var wrongArgument in wrongArguments)
                {
                    if (Argument[wrongArgument] is ErrorType)
                        errors.Add(new Error(
                                       string.Format("Argument {0}: argument is wrong, '{1}' expected",
                                                     wrongArgument + 1, parameter[wrongArgument]), Line,
                                       CharPositionInLine));
                    else
                        errors.Add(new Error(
                                       string.Format("Argument {0}: cannot convert from '{1}' to '{2}'",
                                                     wrongArgument + 1,
                                                     Argument[wrongArgument], parameter[wrongArgument]), Line,
                                       CharPositionInLine));
                }

                NodeType = new ErrorType();
            }
            else
            {
                Function = scope.GetFunction(Id, out _distanceToScope);
                NodeType = Function.ReturnType;
            }
            return result;
        }

        private List<MyType> GetArgument(Scope scope, List<Error> errors)
        {
            _arguments = new List<MyType>();
            if (Parameter != null)
                foreach (var arg in Parameter.Expressions)
                {
                    arg.CheckSemantic(scope, errors);
                    _arguments.Add(arg.NodeType);
                }
            return _arguments;
        }

        public override void GenerateCode(ILGenerator codeGenerator)
        {
            if (CodeGenerator.IsStandardLibraryFunction(Id))
            {
                if (!CodeGenerator.CalledStandardLibraryFunctions.ContainsKey(Id))
                    CodeGenerator.CalledStandardLibraryFunctions.Add(Id,
                                                                     CodeGenerator.StandardLibraryFunctions[Id](
                                                                         CodeGenerator.ProgramClass));
                if (Parameter != null) Parameter.GenerateCode(codeGenerator);
                codeGenerator.Emit(OpCodes.Call, CodeGenerator.CalledStandardLibraryFunctions[Id]);
            }
            else
            {
                codeGenerator.Emit(OpCodes.Ldloc_0);
                if (_distanceToScope > 0)
                {
                    codeGenerator.Emit(OpCodes.Ldc_I4, _distanceToScope);
                    codeGenerator.Emit(OpCodes.Call, CodeGenerator.GoToItScopeMethod);
                }
                codeGenerator.Emit(OpCodes.Ldc_I4, Function.IntegerVariablesCount);
                codeGenerator.Emit(OpCodes.Ldc_I4, Function.ReferenceVariablesCount);
                codeGenerator.Emit(OpCodes.Newobj, CodeGenerator.ProgramConstructor);

                if (Parameter != null)
                {
                    for (int i = 0; i < Parameter.Expressions.Count; i++)
                    {
                        codeGenerator.Emit(OpCodes.Dup);
                        if (Function.ParametersTypes[i] is IntType)
                        {
                            codeGenerator.Emit(OpCodes.Ldfld, CodeGenerator.IntegerVariables);
                            codeGenerator.Emit(OpCodes.Ldc_I4, Function.Parameters[i].Index);
                            Parameter.Expressions[i].GenerateCode(codeGenerator);

                            codeGenerator.Emit(OpCodes.Stelem_I4);
                        }
                        else
                        {
                            codeGenerator.Emit(OpCodes.Ldfld, CodeGenerator.ReferenceVariables);
                            codeGenerator.Emit(OpCodes.Ldc_I4, Function.Parameters[i].Index);
                            Parameter.Expressions[i].GenerateCode(codeGenerator);
                            codeGenerator.Emit(OpCodes.Stelem_Ref);
                        }
                    }
                }

                codeGenerator.Emit(OpCodes.Call, Function.FunctionCode);
            }
        }
    }
}