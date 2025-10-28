using System.Collections.Generic;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigerCompiler.MyTypes;

namespace TigerCompiler.hierarchy.LanguageNode.InstructionNode.ControlNode.BasicTypeNode
{
    class StringNode : BasicTypeNode
    {
        public StringNode(IToken token)
            : base(token)
        {
        }

        public override bool CheckSemantic(Scope scope, List<Error> errors)
        {
            NodeType = new StringType();
            CodeGeneratorType = NodeType.DotNetType;
            return true;
        }

        public override void GenerateCode(ILGenerator codeGenerator)
        {
            string value = "";

            for (int i = 1; i < Text.Length - 1; i++)
            {
                if (Text[i] == '\\')
                {
                    bool searching = true;
                    int wsCount = 0;
                    for (int j = 1; searching; j++)
                    {
                        switch (Text[i + j])
                        {
                            case ' ':
                            case '\t':
                            case '\n':
                            case '\r':
                            case '\f':
                                wsCount++;
                                continue;
                            default:
                                searching = false;
                                break;
                        }
                    }
                    if (wsCount == 0)
                        switch (Text[++i])
                        {
                            case '\'':
                                value += '\'';
                                break;
                            case '\"':
                                value += '\"';
                                break;
                            case '\\':
                                value += '\\';
                                break;
                            case '0':
                                value += '\0';
                                break;
                            case 'a':
                                value += '\a';
                                break;
                            case 'b':
                                value += '\b';
                                break;
                            case 'f':
                                value += '\f';
                                break;
                            case 'n':
                                value += '\n';
                                break;
                            case 'r':
                                value += '\r';
                                break;
                            case 't':
                                value += '\t';
                                break;
                            case 'v':
                                value += '\v';
                                break;
                            case 'U':
                                value +=
                                    (char)
                                    (4096 * ConvertToInt32(Text[i + 5]) + 256 * ConvertToInt32(Text[i + 6]) +
                                     16 * ConvertToInt32(Text[i + 7]) + ConvertToInt32(Text[i + 8]));
                                i += 8;
                                break;
                            case 'u':
                                value +=
                                    (char)
                                    (4096 * ConvertToInt32(Text[i + 1]) + 256 * ConvertToInt32(Text[i + 2]) +
                                     16 * ConvertToInt32(Text[i + 3]) + ConvertToInt32(Text[i + 4]));
                                i += 4;
                                break;
                            case 'x':
                                string number = "";
                                for (int j = 1; char.IsDigit(Text[i + 1]) && j <= 4; i++, j++)
                                    number += Text[i + 1];

                                value += (char)int.Parse(number);

                                //value +=
                                //    (char)
                                //    (number.Select(
                                //        (t, j) => (int) (Math.Pow(16, number.Length - 1 - j))*ConvertToInt32(t)).Sum());
                                break;
                        }
                    else
                        i += wsCount + 1;
                }
                else value += Text[i];
            }

            codeGenerator.Emit(OpCodes.Ldstr, value);
        }

        private bool IsHexadecimalDigit(char digit)
        {
            return digit >= 48 && digit <= 57 || digit >= 65 && digit <= 70;
        }

        private int ConvertToInt32(char hexadecimalDigit)
        {
            return hexadecimalDigit >= 48 && hexadecimalDigit <= 57 ? hexadecimalDigit - 48 : hexadecimalDigit - 55;
        }
    }
}
