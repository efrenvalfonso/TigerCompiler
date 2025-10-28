using Antlr.Runtime;
using Antlr.Runtime.Tree;
using TigerCompiler.hierarchy.LanguageNode.DeclarationNode;
using TigerCompiler.hierarchy.LanguageNode.DeclarationNode.ExpressionsSequenceDeclarationNode;
using TigerCompiler.hierarchy.LanguageNode.InstructionNode.AccesNode.ArrayAccessNode;
using TigerCompiler.hierarchy.LanguageNode.InstructionNode.AccesNode.FieldAccessNode;
using TigerCompiler.hierarchy.LanguageNode.DeclarationNode.TypeDeclarationNode;
using TigerCompiler.hierarchy.LanguageNode.DeclarationNode.VarDeclarationNode;
using TigerCompiler.hierarchy.LanguageNode.InstructionNode;
using TigerCompiler.hierarchy.LanguageNode.InstructionNode.ControlNode;
using TigerCompiler.hierarchy.LanguageNode.InstructionNode.ControlNode.BasicTypeNode;
using TigerCompiler.hierarchy.LanguageNode.InstructionNode.ControlNode.ConditionalNode;
using TigerCompiler.hierarchy.LanguageNode.InstructionNode.ControlNode.LoopNode;
using TigerCompiler.hierarchy.LanguageNode.InstructionNode.OperationNode.BinaryNode.NoShortCircuitBinaryNode.ArithmeticNode;
using TigerCompiler.hierarchy.LanguageNode.InstructionNode.OperationNode.BinaryNode.NoShortCircuitBinaryNode.ComparisonNode.EqualityComparisonNode;
using TigerCompiler.hierarchy.LanguageNode.InstructionNode.OperationNode.BinaryNode.NoShortCircuitBinaryNode.ComparisonNode.RelationalComparisonNode;
using TigerCompiler.hierarchy.LanguageNode.InstructionNode.OperationNode.BinaryNode.ShortCircuitBinaryNode.LogicalNode;
using TigerCompiler.hierarchy.LanguageNode.InstructionNode.OperationNode.UnaryNode;

namespace TigerCompiler
{
    class AstConverter:CommonTreeAdaptor
    {
        public override object Create(IToken payload)
        {
            if(payload == null)
                return base.Create(payload);

            switch (payload.Type)
            {

                    #region operator
                case TigerParser.OR:
                    return new OrNode(payload);
                       
                case  TigerParser.AND:
                    return new AndNode(payload);
                        
                case TigerParser.MULTIPLICATION:
                    return new MultiplyNode(payload);
                      
                case TigerParser.DIVISION:
                    return new DivNode(payload);
                       
                case  TigerParser.MINUS:
                    return new SubstractionNode(payload);
                       
                case TigerParser.PLUS:
                    return new SumNode(payload);
                        
                case TigerParser.EQUAL:
                    return new EqualNode(payload);
                        
                case  TigerParser.NOT_EQUAL:
                    return new NotEqualNode(payload);
                       
                case  TigerParser.LESS_THAN:
                    return new LessThanNode(payload);
                       
                case TigerParser.LESS_EQUAL_THAN:
                    return new LessThanEqualNode(payload);
                        
                case TigerParser.GREATHER_THAN:
                    return new GreaterThanNode(payload);
                       
                case TigerParser.GREATHER_EQUAL_THAN:
                    return new GreaterThanEqualNode(payload);

                case TigerParser.UNARY_MINUS:
                    return new MinusNode(payload);

                    #endregion

                    #region types
                case TigerParser.INT:
                    return new IntNode(payload);
                        
                case TigerParser.STRING:
                    return new StringNode(payload);

                case TigerParser.NIL:
                    return new NillNode(payload);
                        
                    #endregion

                    #region control
                case TigerParser.BREAK:
                    return new BreakNode(payload);
                       
                case  TigerParser.IF_THEN:
                    return new IfThenNode(payload);
                        
                case TigerParser.IF_THEN_ELSE:
                    return new IfThenElseNode(payload);
                        
                case TigerParser.FOR:
                    return new ForNode(payload);
                        
                case TigerParser.WHILE:
                    return new WhileNode(payload);
                        
                case  TigerParser.LET:
                    return new LetNode(payload);
                        
                    #endregion

                    #region Array
                case TigerParser.ARRAY_DECLARATION:
                    return new ArrayDeclarationNode(payload);
                                                                  
                case TigerParser.ARRAY_TYPE_DECLARATION:
                    return new ArrayTypeDeclarationNode(payload);
                        
                    #endregion 

                    #region Record
                case TigerParser.RECORD_ASSIGNMENT:
                    return new RecordAssignmentNode(payload);                  

                case TigerParser.FIELD:
                    return new FieldAssignmentNode(payload);

                case TigerParser.TYPE_FIELD:
                    return new FieldTypeDeclarationNode(payload);

                case TigerParser.RECORD_TYPE_DECLARATION:
                    return new RecordTypeDeclarationNode(payload);
                       
                    #endregion           

                    #region Tuple

                case TigerParser.TUPLE:
                    return new TupleNode(payload);
                    #endregion

                    #region assignment

                case TigerParser.ASSIGNMENT:
                    return new AssignmentNode(payload);
                        
                    #endregion 

                    #region LeftValue

                case TigerParser.INDEXER:
                    return new IndexerNode(payload);

                case TigerParser.RECORD_ACCESS:
                    return new FieldAccessNode(payload);

                    #endregion

                    #region function
                case TigerParser.FUNCTION_DECLARATION:
                    return new FunctionDeclarationNode(payload);
                        
                case TigerParser.FUNCTION_CALL:
                    return new FunctionCallNode(payload);
                                                                  
                case  TigerParser.EXPRESSION_SET:
                    return new ExpressionSequenceNode(payload);
                        
                    #endregion

                    #region Declaration
                case TigerParser.ID:
                    return new IdentificatorVariableNode(payload);

                case TigerParser.EXPLICIT_TYPE_DECLARATION:
                    return new AliasTypeNode(payload);

                case TigerParser.VARIABLE_DECLARATION:
                    return new VariableDeclarationNode(payload);

                case TigerParser.VARIABLE_TYPE_DECLARATION:
                    return new VariableDeclarationNode(payload);

                    #endregion

                default :
                    return base.Create(payload);
            }
        }
    }
}
