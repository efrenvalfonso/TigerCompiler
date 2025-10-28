using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

namespace TigerCompiler.MyTypes
{
    public abstract class MyType
    {
        protected MyType(string type, string name)
        {
            GetMyStringType = type;
            Name = name;
        }

        public string Name { get; private set; }

        public Type DotNetType { get; set; }

        public ConstructorBuilder ConstructorBuilder { get; private set; }

        public void CodeGeneratorType(Scope scope)
        {
            if (DotNetType == null)
            {
                switch (GetMyStringType)
                {
                    case "array":
                        var array = (ArrayType)this;
                        var t1 = scope.GetMyType(array.GetElementsType);
                        if (t1 is NilType || Loop) DotNetType = typeof(Nullable).MakeArrayType();
                        else if (t1.DotNetType == null)
                        {
                            Type t = t1.ReturnCodeGeneratorType(scope);
                            t1.DotNetType = t;
                            DotNetType = t.MakeArrayType();
                        }
                        else
                        {
                            DotNetType = t1.DotNetType.MakeArrayType();
                        }
                        break;
                    case "record":
                        var record = (RecordType)this;
                        var ty = new List<Type>(record.Fields.Count);
                        DotNetType = CodeGenerator.ModuleBuilder.DefineType(record.Name + scope.Count, TypeAttributes.Public);
                        foreach (var key in record.Fields)
                        {
                            MyType fieldType = scope.GetMyType(record.Fields[key.Key]);
                            if (fieldType is NilType) ty.Add(typeof(Nullable));
                            else if (fieldType.DotNetType == null)
                            {
                                Type t = fieldType.ReturnCodeGeneratorType(scope);
                                fieldType.DotNetType = t;
                                ty.Add(t);
                            }
                            else ty.Add(fieldType.DotNetType);
                        }
                        DotNetType = CreateType(record.Fields.Keys.ToArray(), ty.ToArray());
                        break;
                    default:
                        DotNetType = null;
                        break;
                }
            }
        }

        private Type ReturnCodeGeneratorType(Scope scope)
        {
            if (DotNetType == null)
            {
                switch (GetMyStringType)
                {
                    case "int":
                        return typeof(int);
                    case "string":
                        return typeof(string);
                    case "void":
                        return typeof(void);
                    case "array":
                        var array = (ArrayType)this;
                        var t1 = scope.GetMyType(array.GetElementsType);
                        if (t1 is NilType || Loop) return typeof(Nullable).MakeArrayType();
                        if (t1.DotNetType == null)
                        {

                            Type t = t1.ReturnCodeGeneratorType(scope);
                            return t.MakeArrayType();

                        }
                        return t1.DotNetType.MakeArrayType();
                    case "record":
                        var record = (RecordType)this;
                        var ty = new List<Type>(record.Fields.Count);
                        DotNetType = CodeGenerator.ModuleBuilder.DefineType(record.Name, TypeAttributes.Public);
                        foreach (var key in record.Fields)
                        {
                            MyType fieldType = scope.GetMyType(record.Fields[key.Key]);
                            if (fieldType is NilType) ty.Add(typeof(Nullable));
                            else if (fieldType.DotNetType == null)
                                ty.Add(fieldType.ReturnCodeGeneratorType(scope));
                            else ty.Add(fieldType.DotNetType);
                        }
                        return CreateType(record.Fields.Keys.ToArray(), ty.ToArray());
                    default:
                        return null;

                }
            }
            return DotNetType;
        }

        private Type CreateType(string[] fieldNames, Type[] fieldTypes)
        {
            var typeBuilder = (TypeBuilder)DotNetType;
            var fields = new Dictionary<string, FieldInfo>();

            for (int i = 0; i < fieldNames.Length; i++)
            {
                //fieldTypes[i] = fieldTypes[i] ?? typeBuilder;
                fields.Add(fieldNames[i],
                           typeBuilder.DefineField(fieldNames[i], fieldTypes[i],
                                                   FieldAttributes.FamANDAssem | FieldAttributes.Family));
            }
            ConstructorBuilder constructorBuilder =
                typeBuilder.DefineConstructor(MethodAttributes.FamANDAssem | MethodAttributes.Family,
                                              CallingConventions.Standard, fieldTypes);
            ConstructorBuilder = constructorBuilder;
            ILGenerator ilGeneretor = constructorBuilder.GetILGenerator();
            for (int i = 0; i < fieldTypes.Length; i++)
            {
                ilGeneretor.Emit(OpCodes.Ldarg_0);
                ilGeneretor.Emit(OpCodes.Ldarg, i + 1);
                ilGeneretor.Emit(OpCodes.Stfld, fields[fieldNames[i]]);
            }
            ilGeneretor.Emit(OpCodes.Ret);
            return typeBuilder.CreateType();
        }

        public string GetMyStringType { get; private set; }

        public bool Loop { private get; set; }

        public override bool Equals(object obj)
        {
            try
            {
                var objCast = (MyType)obj;
                if (objCast == null || GetMyStringType != objCast.GetMyStringType)
                    return false;
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return GetMyStringType;
        }
    }
}