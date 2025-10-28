using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigerCompiler.MyTypes;
using TigerCompiler.hierarchy.LanguageNode.DeclarationNode.ExpressionsSequenceDeclarationNode;
using TigerCompiler.hierarchy.LanguageNode.DeclarationNode.TypeDeclarationNode;
using TigerCompiler.hierarchy.LanguageNode.DeclarationNode.VarDeclarationNode;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode.ControlNode
{
    internal class LetNode : ControlNode
    {
        public LetNode(IToken token)
            : base(token)
        {
        }

        private ExpressionSequenceNode Declaration
        {
            get { return (ExpressionSequenceNode)GetChild(0); }
        }

        private LanguageNode Body
        {
            get { return (LanguageNode)GetChild(1); }
        }

        public override bool CheckSemantic(Scope scope, List<Error> errors)
        {
            var newScope = scope.NewScope();
            bool result = true;
            var function = new List<LanguageNode>();
            List<Error> typeErrors;
            foreach (var declaration in Declaration.Expressions)
            {
                if (declaration is TypeDeclarationNode)
                {
                    #region logica interna de la declaracion de funciones

                    if (function.Count > 0)
                    {
                        foreach (var f in function) f.CheckSemantic(newScope, errors);
                        newScope.ResetFunction();
                        function.Clear();
                    }

                    #endregion

                    result = declaration.CheckSemantic(newScope, errors) && result;
                }
                else
                {
                    #region verificacion de consistencia de los tipos

                    typeErrors = CheckTypeConsisntency(newScope);
                    if (typeErrors.Count > 0) //hay errores de tipo
                    {
                        result = false;
                        errors.AddRange(typeErrors);
                    }

                    #endregion


                    if (declaration is VariableDeclarationNode)
                    {
                        #region logica interna de la declaracion de funciones

                        if (function.Count > 0)
                        {
                            foreach (var f in function) f.CheckSemantic(newScope, errors);
                            newScope.ResetFunction();
                            function.Clear();
                        }

                        #endregion

                        declaration.CheckSemantic(newScope, errors);
                    }
                    else
                    {
                        var functionErrors = SetFunctionInfo(newScope, declaration as FunctionDeclarationNode);
                        if (functionErrors.Count > 0) errors.AddRange(functionErrors);
                        function.Add(declaration);
                    }
                }
            }

            #region verificacion de consistencia de los tipos

            typeErrors = CheckTypeConsisntency(newScope);
            if (typeErrors.Count > 0) //hay errores de tipo
            {
                result = false;
                errors.AddRange(typeErrors);
            }

            #endregion

            #region logica interna de la declaracion de funciones

            if (function.Count > 0)
            {
                foreach (var f in function) f.CheckSemantic(newScope, errors);
                newScope.ResetFunction();
            }

            #endregion

            IntegerVariablesCount = newScope.IntegerVariablesCount;
            ReferenceVariablesCount = newScope.ReferenceVariablesCount;

            if (Body != null)
            {
                result = Body.CheckSemantic(newScope, errors) && result;
                NodeType = Body.NodeType;
            }
            else
                NodeType = new VoidType();

            return result;
        }

        private List<Error> SetFunctionInfo(Scope scope, FunctionDeclarationNode function)
        {
            var result = new List<Error>();

            //setea la propiedad de los parametros de modo que en la semantica de la funcion se puede utilizar esta propiedad

            if (function.Fields != null)
            {
                foreach (TypeDeclarationNode field in function.Fields.Expressions)
                {
                    var ftype = scope.GetMyType(field.RType);
                    if (ftype is NilType)
                        result.Add(
                            new Error(
                                string.Format("The type named '{0}' is not defined in this scope", field.Id), field.Line,
                                field.CharPositionInLine));
                    function.ParametersTypes.Add(ftype);
                }
            }
            if (!scope.ScopeFunction.ContainsKey(function.Id))
            {
                function.ReturnType = function.ReturnTypeName == null
                                          ? new VoidType()
                                          : scope.GetMyType(function.ReturnTypeName);
                scope.InsertFunction(function);
            }
            return result;
        }

        private List<Error> CheckTypeConsisntency(Scope scope)
        {
            var result = new List<Error>();

            var cheked = new List<TypeNode>();
            foreach (var node in scope.AliasTable.Keys)
            {
                if (!cheked.Contains(node))
                {
                    var nodes = new List<TypeNode> { node };
                    Error e;
                    if (IsLoop(scope, node, nodes, out e))
                    {
                        result.Add(e);
                        cheked.AddRange(nodes);
                    }
                    else
                    {
                        nodes = new List<TypeNode> { node };
                        if (!InsertType(scope, node, nodes, out e))
                            result.Add(e);
                        cheked.AddRange(nodes);
                    }
                }
            }

            foreach (var alias in scope.ArrayOrRecordAliasTable)
            {
                if (!scope.TypeTable.ContainsKey(alias.Name) && !scope.AliasTable.ContainsKey(alias))
                    result.Add(
                        new Error(string.Format("The type named '{0}' is not defined in this scope", alias.Name),
                                  alias.Line, alias.Col));
                if (scope.IsInLoop(alias.Name))
                {
                    scope.TypeTable[alias.Name].Loop = true; //para que al darle el tipo de .NET, sea null(solo es un ciclo si todos son array)
                }
            }
            foreach (var item in scope.TypeId)
            {
                scope.GetMyType(item).CodeGeneratorType(scope);//setea el tipo .NET de los tipos
            }
            scope.TypeId = new List<string>();
            scope.ResetAlias();
            return result;
        }

        private bool InsertType(Scope scope, TypeNode node, ICollection<TypeNode> nodes, out Error error)
        {
            error = null;
            var last = new TypeNode();
            TypeNode seek = scope.AliasTable[node];
            while (seek != null)
            {
                if (scope.ContainType(seek.Name))
                {
                    var t = scope.GetMyType(seek.Name);
                    foreach (var n in nodes)
                    {
                        scope.InsertType(n.Name, t);
                    }
                    return true;
                }
                if (scope.AliasTable.ContainsKey(seek))
                {
                    nodes.Add(seek);
                    seek = scope.AliasTable[seek];
                }
                else
                {
                    last = seek;
                    seek = null;
                }
            }
            error = new Error(string.Format("The type named '{0}' is not defined in this scope", last.Name), last.Line,
                              last.Col);
            return false;
        }

        private bool IsLoop(Scope scope, TypeNode seek, ICollection<TypeNode> nodes, out Error error)
        {
            error = null;
            seek = scope.AliasTable[seek];
            while (seek != null)
            {
                if (nodes.Contains(seek))
                {
                    seek = nodes.First(n => n.Name == seek.Name);
                    error = BuildErrorLoopMessage(nodes, seek);
                    return true;
                }
                nodes.Add(seek);
                seek = scope.AliasTable.ContainsKey(seek) ? scope.AliasTable[seek] : null;
            }
            return false;
        }

        private Error BuildErrorLoopMessage(IEnumerable<TypeNode> nodes, TypeNode seek)
        {
            bool ok = false;
            string errorMessage = "Exist a declarations loop: ";
            foreach (var node in nodes)
                if (ok || node.Equals(seek))
                {
                    ok = true;
                    errorMessage += node.Name + " -> ";
                }
            errorMessage += seek.Name;
            return new Error(errorMessage, seek.Line, seek.Col);
        }

        public override void GenerateCode(ILGenerator codeGenerator)
        {
            var declaration = new List<LanguageNode>();
            codeGenerator.Emit(OpCodes.Ldloc_0);
            codeGenerator.Emit(OpCodes.Ldc_I4, IntegerVariablesCount);
            codeGenerator.Emit(OpCodes.Ldc_I4, ReferenceVariablesCount);
            codeGenerator.Emit(OpCodes.Newobj, CodeGenerator.ProgramConstructor);
            codeGenerator.Emit(OpCodes.Stloc_0);

            foreach (var expression in Declaration.Expressions)
            {
                if (expression is FunctionDeclarationNode)
                {
                    var function = (FunctionDeclarationNode)expression;

                    function.FunctionCode =
                        CodeGenerator.ProgramClass.DefineMethod(
                            function.Id + (function.FunctionNumber == 0 ? "" : function.FunctionNumber.ToString()),
                            MethodAttributes.FamANDAssem | MethodAttributes.Family,
                            function.ReturnTypeName == null ? typeof(void) : function.ReturnType.DotNetType,
                            System.Type.EmptyTypes);
                    declaration.Add(expression);
                }
                else
                    expression.GenerateCode(codeGenerator);
            }
            foreach (var expression in declaration)
                expression.GenerateCode(codeGenerator);
            if (Body != null) Body.GenerateCode(codeGenerator);
            codeGenerator.Emit(OpCodes.Ldloc_0);
            codeGenerator.Emit(OpCodes.Ldfld, CodeGenerator.ProgramParent);
            codeGenerator.Emit(OpCodes.Stloc_0);
        }

        private int IntegerVariablesCount { get; set; }

        private int ReferenceVariablesCount { get; set; }
    }
}