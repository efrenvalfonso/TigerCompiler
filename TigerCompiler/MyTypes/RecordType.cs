using System.Collections.Generic;

namespace TigerCompiler.MyTypes
{
    public class RecordType : ComplexType
    {
        public RecordType(Dictionary<string, string> fields, string name)
            : base("record", name)
        {
            Fields = fields;
        }

        public Dictionary<string, string> Fields { get; private set; }

    }
}
