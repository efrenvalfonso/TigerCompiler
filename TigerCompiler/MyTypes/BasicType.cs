namespace TigerCompiler.MyTypes
{
    public abstract class BasicType : MyType
    {
        protected BasicType(string type)
            : base(type, type)
        {
        }
    }
}
