using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using TigerCompiler.MyTypes;

namespace TigerCompiler.hierarchy.LanguageNode
{
    public abstract class LanguageNode : CommonTree
    {
        protected LanguageNode(IToken token)
            : base(token)
        {
        }

        public Type CodeGeneratorType { get; protected set; }

        public MyType NodeType { get; protected internal set; }

        public abstract bool CheckSemantic(Scope scope, List<Error> errors);

        public abstract void GenerateCode(ILGenerator codeGenerator);
    }
}
