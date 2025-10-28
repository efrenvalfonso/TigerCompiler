namespace TigerCompiler.MyTypes
{
    public class ArrayType : ComplexType
    {
        public ArrayType(string elementsType, string name)
            : base("array", name)
        {
            GetElementsType = elementsType;
        }

        public string GetElementsType { get; private set; }
    }
}
