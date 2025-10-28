using System.Collections.Generic;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigerCompiler.MyTypes;
using TigerCompiler.hierarchy.LanguageNode.DeclarationNode.VarDeclarationNode;
using TigerCompiler.hierarchy.LanguageNode.InstructionNode;

namespace TigerCompiler.hierarchy.LanguageNode.DeclarationNode.ExpressionsSequenceDeclarationNode
{
    public class FunctionDeclarationNode : ExpressionsSequenceDeclarationNode
    {
        public FunctionDeclarationNode(string id, MyType returnType, List<MyType> parametersTypes)
            : base(null) //Standard Library Function Constructor
        {
            Id = id;
            ReturnType = returnType;
            ParametersTypes = parametersTypes;

        }

        public FunctionDeclarationNode(IToken token)
            : base(token)
        {
        }

        public List<VariableDeclarationNode> Parameters { get; private set; }

        private LanguageNode Body
        {
            get
            {
                switch (ChildCount)
                {
                    case 3: //llamada a un proceso con parametros o a una funcion sin parametros                       
                        return (LanguageNode)GetChild(2);
                    case 2: //llamada a un proceso sin parametros
                        return (LanguageNode)GetChild(1);
                    case 4: //llamada a una funcion con parametros
                        return (LanguageNode)GetChild(3);
                    default:
                        return null;
                }
            }
        }

        public string ReturnTypeName
        {
            get
            {
                switch (ChildCount)
                {
                    case 2:
                        return null;
                    case 3:
                        return Children[1] is ExpressionSequenceNode
                                   ? null
                                   : Children[1].Text;
                    default:
                        return Children[2].Text;
                }
            }
        }

        public MyType ReturnType { get; set; }

        public MethodBuilder FunctionCode { get; set; }

        public int FunctionNumber { get; private set; }

        public int IntegerVariablesCount { get; private set; }

        public int ReferenceVariablesCount { get; private set; }

        public override bool CheckSemantic(Scope scope, List<Error> errors)
        {
            ReturnType = ReturnTypeName == null ? new VoidType() : scope.GetMyType(ReturnTypeName);

            bool result = true, insertFunction = true;

            if (scope.ContainLocalVariable(Id) || scope.ContainFunctionInTable(Id))
            {
                result = false;
                errors.Add(
                    new Error(string.Format("A variable or function named '{0}' is already defined in this scope", Id),
                              GetChild(0).Line, GetChild(0).CharPositionInLine));
            }
            else if (ReturnType is NilType) // ya tiene que estar seteado el tipo
            {
                result = false;
                errors.Add(
                    new Error(string.Format("The type named '{0}' is not defined in this scope", ReturnTypeName),
                              GetChild(3).Line, GetChild(3).CharPositionInLine));
            }
            else
            {
                if (Fields != null)
                {
                    insertFunction = FieldsOk(ParametersNames, Fields, errors);
                    result = insertFunction;
                }

                var newScope = scope.NewScope();

                if (insertFunction)
                    Parameters = InsertArgument(newScope, ParametersNames, ParametersTypes);
                result = Body.CheckSemantic(newScope, errors) && result;

                var bodyType = Body.NodeType;

                if (ReturnType is VoidType)
                {
                    if (!(bodyType is VoidType || bodyType is ErrorType))
                    {
                        result = false;
                        errors.Add(new Error(string.Format("Since '{0}' is a procedure must not return value", Id), Line,
                                             CharPositionInLine));
                    }
                }
                else if (bodyType is VoidType)
                {
                    result = false;
                    errors.Add(new Error(string.Format("Since '{0}' is a function must return value", Id), Line,
                                             CharPositionInLine));
                }
                else if (scope.IsDistinct(ReturnType, bodyType))
                {
                    result = false;
                    NodeType = new ErrorType();
                    if (!(bodyType is ErrorType || ReturnType is ErrorType))
                        errors.Add(
                            new Error(
                                string.Format("Cannot implicitly convert type '{0}' to '{1}'", bodyType, ReturnType),
                                Line, CharPositionInLine));
                }

                IntegerVariablesCount = newScope.IntegerVariablesCount;
                ReferenceVariablesCount = newScope.ReferenceVariablesCount;

                NodeType = ReturnType; //el valor de retorno de la funcion es el especificado 
                if (insertFunction)
                {
                    FunctionNumber = CodeGenerator.DeclaredFunctionsAndCount.ContainsKey(Id)
                                         ? ++CodeGenerator.DeclaredFunctionsAndCount[Id]
                                         : CodeGenerator.DeclaredFunctionsAndCount[Id] = 0;

                    scope.InsertFunctionTable(this);
                }
            }
            return result;
        }

        public override void GenerateCode(ILGenerator codeGenerator)
        {
            var methodCodeGenerator = FunctionCode.GetILGenerator();
            methodCodeGenerator.DeclareLocal(CodeGenerator.ProgramClass);
            methodCodeGenerator.Emit(OpCodes.Ldarg_0);
            methodCodeGenerator.Emit(OpCodes.Stloc_0);
            Body.GenerateCode(methodCodeGenerator);
            methodCodeGenerator.Emit(OpCodes.Ret);
        }

        private List<VariableDeclarationNode> InsertArgument(Scope scope, List<string> parameterName,
                                                             List<MyType> parameterType)
        {
            var result = new List<VariableDeclarationNode>();

            for (int i = 0; i < parameterType.Count; i++)
            {
                result.Add(new VariableDeclarationNode(parameterName[i], null) { NodeType = parameterType[i] });
                scope.InsertVariable(result[i]);
            }

            return result;
        }
    }
}