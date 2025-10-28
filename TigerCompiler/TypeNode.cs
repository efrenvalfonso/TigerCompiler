using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using TigerCompiler.MyTypes;


namespace TigerCompiler
{
    public class TypeNode
    {
        public TypeNode()
        {
        }

        public TypeNode(string name, int line, int col)
        {
            Name = name;
            Line = line;
            Col = col;
        }

        public int Col
        {
            get; set; }

        public int Line
        {
            get; set; }

        public string Name
        {
            get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof (TypeNode)) return false;
            return Equals((TypeNode) obj);
        }

        public bool Equals(TypeNode other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(other.Name, Name);
        }
       

        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0);
        }
    }
}
