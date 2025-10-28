using System.Collections.Generic;
using System.Linq;
using TigerCompiler.MyTypes;
using TigerCompiler.hierarchy.LanguageNode.DeclarationNode.ExpressionsSequenceDeclarationNode;
using TigerCompiler.hierarchy.LanguageNode.DeclarationNode.VarDeclarationNode;

namespace TigerCompiler
{
    public class Scope
    {
        private Scope(Scope father, bool isForScope = false, bool isWhileScope = false)
        {
            IsForScope = isForScope;
            IsWhileScope = isWhileScope;
            FunctionTable = new Dictionary<string, FunctionDeclarationNode>();
            ScopeFunction = new Dictionary<string, FunctionDeclarationNode>();
            Father = father;
            TypeId = new List<string>();
            AliasTable = new Dictionary<TypeNode, TypeNode>();
            ArrayOrRecordAliasTable = new List<TypeNode>();
            VariableTable = new Dictionary<string, VariableDeclarationNode>();
            TypeTable = new Dictionary<string, MyType>();
            IntegerVariablesCount = 0;
            ReferenceVariablesCount = 0;
        }

        public Scope NewScope(bool isLoopScope = false, bool isWhileScope = false)
        {
            var c = new Scope(this, isLoopScope, isWhileScope);
            c.TypeTable.Add("int", new IntType { DotNetType = typeof(int) });
            c.TypeTable.Add("string", new StringType { DotNetType = typeof(string) });
            c.Count = Count + 1;
            return c;
        }

        public List<string> TypeId { get; set; }

        public List<TypeNode> ArrayOrRecordAliasTable { get; private set; }

        public Dictionary<TypeNode, TypeNode> AliasTable { get; private set; }

        public Scope(bool isLoopScope = false, bool isWhileScope = false)
            : this(null, isLoopScope, isWhileScope)
        {
        }

        private static readonly Dictionary<string, FunctionDeclarationNode> PreDefineFunctions =
            new Dictionary<string, FunctionDeclarationNode>
                {
                    {"print", new FunctionDeclarationNode("print", new VoidType(), new List<MyType> {new StringType()})},
                    {"printi", new FunctionDeclarationNode("printi", new VoidType(), new List<MyType> {new IntType()})},
                    {"flush", new FunctionDeclarationNode("flush", new VoidType(), new List<MyType>())},
                    {"getchar", new FunctionDeclarationNode("getchar", new StringType(), new List<MyType>())},
                    {"ord", new FunctionDeclarationNode("ord", new IntType(), new List<MyType> {new StringType()})},
                    {"chr", new FunctionDeclarationNode("chr", new StringType(), new List<MyType> {new IntType()})},
                    {
                        "substring",
                        new FunctionDeclarationNode("substring", new StringType(),
                                                    new List<MyType> {new StringType(), new IntType(), new IntType()})
                        },
                    {
                        "concat",
                        new FunctionDeclarationNode("concat", new StringType(),
                                                    new List<MyType> {new StringType(), new StringType()})
                        },
                    {"not", new FunctionDeclarationNode("not", new IntType(), new List<MyType> {new IntType()})},
                    {"exit", new FunctionDeclarationNode("exit", new VoidType(), new List<MyType> {new IntType()})},
                    {"size", new FunctionDeclarationNode("size", new IntType(), new List<MyType> {new StringType()})},
                    {"getline", new FunctionDeclarationNode("getline", new StringType(), new List<MyType>())},
                    {
                        "printline",
                        new FunctionDeclarationNode("printline", new VoidType(), new List<MyType> {new StringType()})
                        },
                    {"parse", new FunctionDeclarationNode("parse", new IntType(), new List<MyType> {new StringType()})}
                };

        public int Count { get; private set; }


        private Dictionary<string, FunctionDeclarationNode> FunctionTable { get; set; }

        public Dictionary<string, FunctionDeclarationNode> ScopeFunction { get; private set; }

        public Dictionary<string, MyType> TypeTable { get; private set; }

        private Dictionary<string, VariableDeclarationNode> VariableTable { get; set; }

        public int IntegerVariablesCount { get; private set; }

        public int ReferenceVariablesCount { get; private set; }

        public bool ContainVariable(string variableName)
        {
            if (VariableTable.ContainsKey(variableName))
                return true;
            return Father != null && Father.ContainVariable(variableName);
        }

        public MyType GetVariableType(string variableName)
        {
            VariableDeclarationNode variable;
            if (VariableTable.TryGetValue(variableName, out variable))
                return variable.NodeType;
            return Father != null ? Father.GetVariableType(variableName) : null;
        }

        public Scope Father { get; private set; }

        public bool ContainLocalVariable(string id)
        {
            return VariableTable.ContainsKey(id);
        }

        public bool ContainType(string variableTypeId)
        {
            if (TypeTable.ContainsKey(variableTypeId))
                return true;
            return Father != null && Father.ContainType(variableTypeId);
        }

        public void InsertVariable(VariableDeclarationNode variableNode)
        {
            VariableTable.Add(variableNode.Id, variableNode);
            variableNode.Index = variableNode.NodeType is IntType ? IntegerVariablesCount++ : ReferenceVariablesCount++;
        }

        public void InsertType(string id, MyType nodeType)
        {
            TypeTable.Add(id, nodeType);
        }

        public bool ContainFunctionInTable(string id)
        {
            if (FunctionTable.ContainsKey(id))
                return true;
            return Father != null ? Father.ContainFunctionInTable(id) : PreDefineFunctions.ContainsKey(id);
        }

        public bool ContainFunctionInTable(string id, out List<MyType> parameter)
        {
            parameter = new List<MyType>();
            if (FunctionTable.ContainsKey(id))
            {
                parameter = FunctionTable[id].ParametersTypes;
                return true;
            }
            if (Father != null) return Father.ContainFunctionInTable(id, out parameter);
            if (PreDefineFunctions.ContainsKey(id))
            {
                parameter = PreDefineFunctions[id].ParametersTypes;
                return true;
            }
            return false;
        }

        public void InsertFunction(FunctionDeclarationNode function)
        {
            ScopeFunction.Add(function.Id, function);
        }

        public void InsertAlias(TypeNode id, TypeNode rtype)
        {
            AliasTable.Add(id, rtype);
        }

        public bool ContainLocalType(string id)
        {
            return TypeTable.ContainsKey(id);
        }

        /// <summary>
        /// verifica si el tipo ha sido declarado solo en el ambito local
        /// </summary>
        /// <param name="id"></param>
        /// <returns> </returns>
        public bool ContainLocalTypeId(string id)
        {
            return TypeId.Contains(id);
        }

        public MyType GetMyType(string typeName)
        {
            var scope = this;
            while (scope != null && !scope.TypeTable.ContainsKey(typeName))
                scope = scope.Father;
            return scope == null ? new NilType() : scope.TypeTable[typeName];
        }

        public bool IsInLoop(string typeName)
        {
            var types = new List<string> { typeName };
            if (TypeTable.ContainsKey(typeName))
            {
                var t = TypeTable[typeName];
                if (t is ArrayType)
                {
                    string arrayType = (t as ArrayType).GetElementsType;
                    return IsInLoop(arrayType, types);
                }
                return false;
            }
            if (Father != null) return Father.IsInLoop(typeName);
            return false;
        }

        private bool IsInLoop(string seek, List<string> types)
        {
            if (types.Contains(seek)) return true;
            if (TypeTable.ContainsKey(seek))
            {
                var t = TypeTable[seek];
                if (t is ArrayType)
                {
                    types.Add(seek);
                    string arrayType = (t as ArrayType).GetElementsType;
                    return IsInLoop(arrayType, types);
                }
                return false;
            }
            return false;
        }

        public void InsertId(string id)
        {
            TypeId.Add(id);
        }

        /// <summary>
        /// compara los tipos por "Referencia" en este caso por su nombre que es unico
        /// </summary>
        /// <param name="variableType"></param>
        /// <param name="valueType"></param>
        /// <returns></returns>
        public bool IsDistinct(MyType variableType, MyType valueType)
        {
            var type1 = variableType.GetMyStringType;
            var type2 = valueType.GetMyStringType;
            if (type2 == "nil" && (type1 == "string" || type1 == "array" || type1 == "record")
                || type1 == "nil" && (type2 == "string" || type2 == "array" || type2 == "record")) return false;

            return variableType.Name != valueType.Name;
        }

        public void InsertArrayOrRecordAlias(IEnumerable<TypeNode> fieldsTypes)
        {
            foreach (var t in fieldsTypes)
            {
                if (!ArrayOrRecordAliasTable.Contains(t))
                    ArrayOrRecordAliasTable.Add(t);
            }

        }

        public void ResetAlias()
        {
            if (AliasTable.Count > 0)
                AliasTable = new Dictionary<TypeNode, TypeNode>();
            if (ArrayOrRecordAliasTable.Count > 0)
                ArrayOrRecordAliasTable = new List<TypeNode>();
        }

        public void ResetFunction()
        {
            ScopeFunction = new Dictionary<string, FunctionDeclarationNode>();
        }

        public void InsertFunctionTable(FunctionDeclarationNode function)
        {
            FunctionTable.Add(function.Id, function);
        }

        public bool ParameterEquals(List<MyType> parameterType, List<MyType> functionParameter)
        {
            if (parameterType.Count == functionParameter.Count)
                return !functionParameter.Where((t, i) => IsDistinct(parameterType[i], t)).Any();
            return false;
        }

        public bool ContainFunction(string id, out List<MyType> parameter)
        {
            bool result = false;
            parameter = new List<MyType>();
            var current = this;
            while (current != null)
            {
                if (current.ScopeFunction.ContainsKey(id))
                {
                    parameter = current.ScopeFunction[id].ParametersTypes;
                    result = true;
                    break;
                }
                current = current.Father;
            }
            if (!result)
            {
                if (PreDefineFunctions.ContainsKey(id))
                {
                    parameter = PreDefineFunctions[id].ParametersTypes;
                    return true;
                }
                return false;
            }
            return true;
        }

        public FunctionDeclarationNode GetFunction(string id, out int distanceToScope)
        {
            var scope = this;
            distanceToScope = 0;

            if (PreDefineFunctions.ContainsKey(id))
                return PreDefineFunctions[id];

            while (scope != null)
            {
                if (scope.ScopeFunction.ContainsKey(id)) return scope.ScopeFunction[id];
                if (scope.FunctionTable.ContainsKey(id)) return scope.FunctionTable[id];
                if (!scope.IsWhileScope) distanceToScope++;
                scope = scope.Father;
            }

            return null;
        }

        public VariableDeclarationNode GetVariable(string variableName, out int distanceToScope)
        {
            VariableDeclarationNode variable = null;
            distanceToScope = 0;
            var scope = this;

            while (scope != null && !scope.VariableTable.TryGetValue(variableName, out variable))
            {
                if (!scope.IsWhileScope) distanceToScope++;
                scope = scope.Father;
            }

            return scope == null ? null : variable;
        }

        public bool IsForScope { get; private set; }

        public bool IsWhileScope { get; private set; }

        public bool ContainInAliasTable(string id)
        {
            return AliasTable.Keys.Any(typeNode => typeNode.Name == id);
        }
    }
}