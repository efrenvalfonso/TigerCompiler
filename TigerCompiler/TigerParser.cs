// $ANTLR 3.3 Nov 30, 2010 12:45:30 C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g 2010-01-12 16:32:03

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


	using TigerCompiler;


using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;
using Map = System.Collections.IDictionary;
using HashMap = System.Collections.Generic.Dictionary<object, object>;

using Antlr.Runtime.Tree;
using RewriteRuleITokenStream = Antlr.Runtime.Tree.RewriteRuleTokenStream;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:45:30")]
[System.CLSCompliant(false)]
public partial class TigerParser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "ARRAY", "BREAK", "DO", "ELSE", "END", "FOR", "FUNCTION", "IF", "IN", "LET", "NIL", "OF", "THEN", "TO", "TYPE", "VAR", "WHILE", "COMMA", "COLON", "SEMICOLON", "LEFT_PARENTHESIS", "RIGHT_PARENTHESIS", "LEFT_BRACKET", "RIGHT_BRACKET", "LEFT_KEY", "RIGHT_KEY", "DOT", "PLUS", "MINUS", "MULTIPLICATION", "DIVISION", "EQUAL", "NOT_EQUAL", "LESS_THAN", "LESS_EQUAL_THAN", "GREATHER_THAN", "GREATHER_EQUAL_THAN", "AND", "OR", "ASSIGNMENT", "UNARY_MINUS", "IF_THEN", "IF_THEN_ELSE", "EXPRESSION_SET", "INDEXER", "TUPLE", "FIELD", "TYPE_FIELD", "VARIABLE_DECLARATION", "ARRAY_DECLARATION", "RECORD_ASSIGNMENT", "RECORD_ASSIGNMENT_ACCESS", "PROCEDURE_DECLARATION", "EXPLICIT_TYPE_DECLARATION", "RECORD_TYPE_DECLARATION", "ARRAY_TYPE_DECLARATION", "VARIABLE_TYPE_DECLARATION", "FUNCTION_DECLARATION", "RECORD_ACCESS", "FUNCTION_CALL", "FUNCTION_CALL_INDEXER", "LETTER", "DIGIT", "ID", "INT", "HEX_DIGIT", "CLOSE_LINE_COMMENT", "LINE_COMMENT", "BLOCK_COMMENT", "COMMENT", "WHITE_SPACE", "ESC_SEQ", "STRING"
	};
	public const int EOF=-1;
	public const int ARRAY=4;
	public const int BREAK=5;
	public const int DO=6;
	public const int ELSE=7;
	public const int END=8;
	public const int FOR=9;
	public const int FUNCTION=10;
	public const int IF=11;
	public const int IN=12;
	public const int LET=13;
	public const int NIL=14;
	public const int OF=15;
	public const int THEN=16;
	public const int TO=17;
	public const int TYPE=18;
	public const int VAR=19;
	public const int WHILE=20;
	public const int COMMA=21;
	public const int COLON=22;
	public const int SEMICOLON=23;
	public const int LEFT_PARENTHESIS=24;
	public const int RIGHT_PARENTHESIS=25;
	public const int LEFT_BRACKET=26;
	public const int RIGHT_BRACKET=27;
	public const int LEFT_KEY=28;
	public const int RIGHT_KEY=29;
	public const int DOT=30;
	public const int PLUS=31;
	public const int MINUS=32;
	public const int MULTIPLICATION=33;
	public const int DIVISION=34;
	public const int EQUAL=35;
	public const int NOT_EQUAL=36;
	public const int LESS_THAN=37;
	public const int LESS_EQUAL_THAN=38;
	public const int GREATHER_THAN=39;
	public const int GREATHER_EQUAL_THAN=40;
	public const int AND=41;
	public const int OR=42;
	public const int ASSIGNMENT=43;
	public const int UNARY_MINUS=44;
	public const int IF_THEN=45;
	public const int IF_THEN_ELSE=46;
	public const int EXPRESSION_SET=47;
	public const int INDEXER=48;
	public const int TUPLE=49;
	public const int FIELD=50;
	public const int TYPE_FIELD=51;
	public const int VARIABLE_DECLARATION=52;
	public const int ARRAY_DECLARATION=53;
	public const int RECORD_ASSIGNMENT=54;
	public const int RECORD_ASSIGNMENT_ACCESS=55;
	public const int PROCEDURE_DECLARATION=56;
	public const int EXPLICIT_TYPE_DECLARATION=57;
	public const int RECORD_TYPE_DECLARATION=58;
	public const int ARRAY_TYPE_DECLARATION=59;
	public const int VARIABLE_TYPE_DECLARATION=60;
	public const int FUNCTION_DECLARATION=61;
	public const int RECORD_ACCESS=62;
	public const int FUNCTION_CALL=63;
	public const int FUNCTION_CALL_INDEXER=64;
	public const int LETTER=65;
	public const int DIGIT=66;
	public const int ID=67;
	public const int INT=68;
	public const int HEX_DIGIT=69;
	public const int CLOSE_LINE_COMMENT=70;
	public const int LINE_COMMENT=71;
	public const int BLOCK_COMMENT=72;
	public const int COMMENT=73;
	public const int WHITE_SPACE=74;
	public const int ESC_SEQ=75;
	public const int STRING=76;

	// delegates
	// delegators

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				true, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false, false, 
				false, false, true, false, false, false, false, false, false, false, 
				false, false, false, false, false
			};
	#else
		private static readonly bool[] decisionCanBacktrack = new bool[0];
	#endif
	public TigerParser( ITokenStream input )
		: this( input, new RecognizerSharedState() )
	{
	}
	public TigerParser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{
		ITreeAdaptor treeAdaptor = null;
		CreateTreeAdaptor(ref treeAdaptor);
		TreeAdaptor = treeAdaptor ?? new CommonTreeAdaptor();

		OnCreated();
	}
		
	// Implement this function in your helper file to use a custom tree adaptor
	partial void CreateTreeAdaptor(ref ITreeAdaptor adaptor);

	private ITreeAdaptor adaptor;

	public ITreeAdaptor TreeAdaptor
	{
		get
		{
			return adaptor;
		}
		set
		{
			this.adaptor = value;
		}
	}

	public override string[] TokenNames { get { return TigerParser.tokenNames; } }
	public override string GrammarFileName { get { return "C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g"; } }


		public List<Error> Errors = new List<Error>();

		public override string GetErrorMessage(RecognitionException e, string[] tokenNames)
		{
		    var message = "Syntactic Error";
		
		    if (e is UnwantedTokenException)
		    {
		        var unwantedTokenException = (UnwantedTokenException) e;
		        message = string.Format("Unexpected token {0}. {1} expected.",
		                                GetTokenErrorDisplay(unwantedTokenException.UnexpectedToken),
		                                unwantedTokenException.Expecting == EOF
		                                    ? "EOF"
		                                    : tokenNames[unwantedTokenException.Expecting]);
		    }
		
	    	    if (e is MissingTokenException)
		    {
		        var missingTokenException = (MissingTokenException) e;
		        message = string.Format("Missing token {0} in {1}.",
		                                missingTokenException.Expecting == EOF
		                                    ? "EOF"
		                                    : tokenNames[missingTokenException.Expecting],
		                                GetTokenErrorDisplay(e.Token));
		    }
		
	    	    if (e is MismatchedTokenException)
		    {
		        var mismatchedTokenException = (MismatchedTokenException)e;
		        message = string.Format("Unexpected token {0}. {1} expected.",
		                                GetTokenErrorDisplay(e.Token),
		                                mismatchedTokenException.Expecting == EOF
		                                    ? "EOF"
		                                    : tokenNames[mismatchedTokenException.Expecting]);
		    }
		
	    	    if (e is MismatchedTreeNodeException)
		    {
		        var mismatchedtreeNodeException = (MismatchedTreeNodeException) e;
		        message = string.Format("Mismatched tree node: {0}. {1} expected.",
		                                mismatchedtreeNodeException.Node ?? string.Empty,
		                                mismatchedtreeNodeException.Expecting == EOF
		                                    ? "EOF"
		                                    : tokenNames[mismatchedtreeNodeException.Expecting]);
		    }
		
	    	    if (e is MismatchedSetException)
		    {
		        var mismatchedSetException = (MismatchedSetException) e;
		        message = string.Format("Unexpected token {0}. {1} expected.",
		                                GetTokenErrorDisplay(e.Token),
		                                mismatchedSetException.Expecting);
		    }
		
	    	    if (e is MismatchedNotSetException)
		    {
		        var mismatchedNotSetException = (MismatchedSetException)e;
		        message = string.Format("Unexpected token {0}. {1} expected.",
		                                GetTokenErrorDisplay(e.Token),
		                                mismatchedNotSetException.Expecting);
		    }
		
	    	    if (e is FailedPredicateException)
		    {
		        var predicateException = (FailedPredicateException) e;
		        message = string.Format("Failed predicate: {0}{1}{2} in rule {3}", '{', predicateException.PredicateText,
		                                '}', predicateException.RuleName);
		    }
		
	    	    if (e is NoViableAltException)
		        message = string.Format("Cannot resolve symbol {0}", GetTokenErrorDisplay(e.Token));
		
	    	    if (e is EarlyExitException)
		        message = string.Format("Unexpected token {0}", GetTokenErrorDisplay(e.Token));
		
	    	    Errors.Add(new Error(message, e.Line, e.CharPositionInLine));
		    return message;
		}


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	#region Rules
	public class program_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_program();
	partial void Leave_program();

	// $ANTLR start "program"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:334:8: public program : expression EOF ;
	[GrammarRule("program")]
	public TigerParser.program_return program()
	{
		Enter_program();
		EnterRule("program", 1);
		TraceIn("program", 1);
		TigerParser.program_return retval = new TigerParser.program_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken EOF2=null;
		TigerParser.expression_return expression1 = default(TigerParser.expression_return);

		object EOF2_tree=null;

		try { DebugEnterRule(GrammarFileName, "program");
		DebugLocation(334, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:335:2: ( expression EOF )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:335:4: expression EOF
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(335, 4);
			PushFollow(Follow._expression_in_program1085);
			expression1=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression1.Tree);
			DebugLocation(335, 18);
			EOF2=(IToken)Match(input,EOF,Follow._EOF_in_program1087); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("program", 1);
			LeaveRule("program", 1);
			Leave_program();
		}
		DebugLocation(336, 1);
		} finally { DebugExitRule(GrammarFileName, "program"); }
		return retval;

	}
	// $ANTLR end "program"

	public class expression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expression();
	partial void Leave_expression();

	// $ANTLR start "expression"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:338:1: expression : ( ( left_value_assignment ASSIGNMENT )=>leftValue= left_value_assignment ASSIGNMENT rightConjunctiveExpression= conjunctive_expression | conjunctive_expression );
	[GrammarRule("expression")]
	private TigerParser.expression_return expression()
	{
		Enter_expression();
		EnterRule("expression", 2);
		TraceIn("expression", 2);
		TigerParser.expression_return retval = new TigerParser.expression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ASSIGNMENT3=null;
		TigerParser.left_value_assignment_return leftValue = default(TigerParser.left_value_assignment_return);
		TigerParser.conjunctive_expression_return rightConjunctiveExpression = default(TigerParser.conjunctive_expression_return);
		TigerParser.conjunctive_expression_return conjunctive_expression4 = default(TigerParser.conjunctive_expression_return);

		object ASSIGNMENT3_tree=null;

		try { DebugEnterRule(GrammarFileName, "expression");
		DebugLocation(338, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:339:2: ( ( left_value_assignment ASSIGNMENT )=>leftValue= left_value_assignment ASSIGNMENT rightConjunctiveExpression= conjunctive_expression | conjunctive_expression )
			int alt1=2;
			try { DebugEnterDecision(1, decisionCanBacktrack[1]);
			try
			{
				alt1 = dfa1.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(1); }
			switch (alt1)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:339:4: ( left_value_assignment ASSIGNMENT )=>leftValue= left_value_assignment ASSIGNMENT rightConjunctiveExpression= conjunctive_expression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(339, 52);
				PushFollow(Follow._left_value_assignment_in_expression1111);
				leftValue=left_value_assignment();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftValue.Tree);
				DebugLocation(339, 86);
				ASSIGNMENT3=(IToken)Match(input,ASSIGNMENT,Follow._ASSIGNMENT_in_expression1113); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				ASSIGNMENT3_tree = (object)adaptor.Create(ASSIGNMENT3);
				root_0 = (object)adaptor.BecomeRoot(ASSIGNMENT3_tree, root_0);
				}
				DebugLocation(339, 115);
				PushFollow(Follow._conjunctive_expression_in_expression1120);
				rightConjunctiveExpression=conjunctive_expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, rightConjunctiveExpression.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:340:5: conjunctive_expression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(340, 5);
				PushFollow(Follow._conjunctive_expression_in_expression1126);
				conjunctive_expression4=conjunctive_expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conjunctive_expression4.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expression", 2);
			LeaveRule("expression", 2);
			Leave_expression();
		}
		DebugLocation(341, 1);
		} finally { DebugExitRule(GrammarFileName, "expression"); }
		return retval;

	}
	// $ANTLR end "expression"

	public class left_value_assignment_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_left_value_assignment();
	partial void Leave_left_value_assignment();

	// $ANTLR start "left_value_assignment"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:343:1: left_value_assignment : leftId= id (recordAccess= record_access[(CommonTree)leftId.Tree] leftValue= left_value[(CommonTree)recordAccess.Tree] -> $leftValue | ind= indexer[(CommonTree)leftId.Tree] leftValue= left_value[(CommonTree)ind.Tree] -> $leftValue | -> $leftId) ;
	[GrammarRule("left_value_assignment")]
	private TigerParser.left_value_assignment_return left_value_assignment()
	{
		Enter_left_value_assignment();
		EnterRule("left_value_assignment", 3);
		TraceIn("left_value_assignment", 3);
		TigerParser.left_value_assignment_return retval = new TigerParser.left_value_assignment_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		TigerParser.id_return leftId = default(TigerParser.id_return);
		TigerParser.record_access_return recordAccess = default(TigerParser.record_access_return);
		TigerParser.left_value_return leftValue = default(TigerParser.left_value_return);
		TigerParser.indexer_return ind = default(TigerParser.indexer_return);

		RewriteRuleSubtreeStream stream_id=new RewriteRuleSubtreeStream(adaptor,"rule id");
		RewriteRuleSubtreeStream stream_left_value=new RewriteRuleSubtreeStream(adaptor,"rule left_value");
		RewriteRuleSubtreeStream stream_indexer=new RewriteRuleSubtreeStream(adaptor,"rule indexer");
		RewriteRuleSubtreeStream stream_record_access=new RewriteRuleSubtreeStream(adaptor,"rule record_access");
		try { DebugEnterRule(GrammarFileName, "left_value_assignment");
		DebugLocation(343, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:344:2: (leftId= id (recordAccess= record_access[(CommonTree)leftId.Tree] leftValue= left_value[(CommonTree)recordAccess.Tree] -> $leftValue | ind= indexer[(CommonTree)leftId.Tree] leftValue= left_value[(CommonTree)ind.Tree] -> $leftValue | -> $leftId) )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:344:4: leftId= id (recordAccess= record_access[(CommonTree)leftId.Tree] leftValue= left_value[(CommonTree)recordAccess.Tree] -> $leftValue | ind= indexer[(CommonTree)leftId.Tree] leftValue= left_value[(CommonTree)ind.Tree] -> $leftValue | -> $leftId)
			{
			DebugLocation(344, 11);
			PushFollow(Follow._id_in_left_value_assignment1141);
			leftId=id();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_id.Add(leftId.Tree);
			DebugLocation(345, 3);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:345:3: (recordAccess= record_access[(CommonTree)leftId.Tree] leftValue= left_value[(CommonTree)recordAccess.Tree] -> $leftValue | ind= indexer[(CommonTree)leftId.Tree] leftValue= left_value[(CommonTree)ind.Tree] -> $leftValue | -> $leftId)
			int alt2=3;
			try { DebugEnterSubRule(2);
			try { DebugEnterDecision(2, decisionCanBacktrack[2]);
			switch (input.LA(1))
			{
			case DOT:
				{
				alt2=1;
				}
				break;
			case LEFT_BRACKET:
				{
				alt2=2;
				}
				break;
			case ASSIGNMENT:
				{
				alt2=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 2, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(2); }
			switch (alt2)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:345:5: recordAccess= record_access[(CommonTree)leftId.Tree] leftValue= left_value[(CommonTree)recordAccess.Tree]
				{
				DebugLocation(345, 18);
				PushFollow(Follow._record_access_in_left_value_assignment1151);
				recordAccess=record_access((CommonTree)leftId.Tree);
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_record_access.Add(recordAccess.Tree);
				DebugLocation(345, 69);
				PushFollow(Follow._left_value_in_left_value_assignment1158);
				leftValue=left_value((CommonTree)recordAccess.Tree);
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_left_value.Add(leftValue.Tree);


				{
				// AST REWRITE
				// elements: leftValue
				// token labels: 
				// rule labels: retval, leftValue
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
				RewriteRuleSubtreeStream stream_leftValue=new RewriteRuleSubtreeStream(adaptor,"rule leftValue",leftValue!=null?leftValue.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 345:113: -> $leftValue
				{
					DebugLocation(345, 116);
					adaptor.AddChild(root_0, stream_leftValue.NextTree());

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:346:5: ind= indexer[(CommonTree)leftId.Tree] leftValue= left_value[(CommonTree)ind.Tree]
				{
				DebugLocation(346, 9);
				PushFollow(Follow._indexer_in_left_value_assignment1174);
				ind=indexer((CommonTree)leftId.Tree);
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_indexer.Add(ind.Tree);
				DebugLocation(346, 54);
				PushFollow(Follow._left_value_in_left_value_assignment1181);
				leftValue=left_value((CommonTree)ind.Tree);
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_left_value.Add(leftValue.Tree);


				{
				// AST REWRITE
				// elements: leftValue
				// token labels: 
				// rule labels: retval, leftValue
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
				RewriteRuleSubtreeStream stream_leftValue=new RewriteRuleSubtreeStream(adaptor,"rule leftValue",leftValue!=null?leftValue.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 346:89: -> $leftValue
				{
					DebugLocation(346, 92);
					adaptor.AddChild(root_0, stream_leftValue.NextTree());

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:347:5: 
				{

				{
				// AST REWRITE
				// elements: leftId
				// token labels: 
				// rule labels: retval, leftId
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
				RewriteRuleSubtreeStream stream_leftId=new RewriteRuleSubtreeStream(adaptor,"rule leftId",leftId!=null?leftId.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 347:5: -> $leftId
				{
					DebugLocation(347, 8);
					adaptor.AddChild(root_0, stream_leftId.NextTree());

				}

				retval.Tree = root_0;
				}
				}

				}
				break;

			}
			} finally { DebugExitSubRule(2); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("left_value_assignment", 3);
			LeaveRule("left_value_assignment", 3);
			Leave_left_value_assignment();
		}
		DebugLocation(349, 1);
		} finally { DebugExitRule(GrammarFileName, "left_value_assignment"); }
		return retval;

	}
	// $ANTLR end "left_value_assignment"

	public class conjunctive_expression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_conjunctive_expression();
	partial void Leave_conjunctive_expression();

	// $ANTLR start "conjunctive_expression"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:351:1: conjunctive_expression : leftDisjunctiveExpression= disjunctive_expression ( OR rightDisjunctiveExpression= disjunctive_expression )* ;
	[GrammarRule("conjunctive_expression")]
	private TigerParser.conjunctive_expression_return conjunctive_expression()
	{
		Enter_conjunctive_expression();
		EnterRule("conjunctive_expression", 4);
		TraceIn("conjunctive_expression", 4);
		TigerParser.conjunctive_expression_return retval = new TigerParser.conjunctive_expression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken OR5=null;
		TigerParser.disjunctive_expression_return leftDisjunctiveExpression = default(TigerParser.disjunctive_expression_return);
		TigerParser.disjunctive_expression_return rightDisjunctiveExpression = default(TigerParser.disjunctive_expression_return);

		object OR5_tree=null;

		try { DebugEnterRule(GrammarFileName, "conjunctive_expression");
		DebugLocation(351, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:352:2: (leftDisjunctiveExpression= disjunctive_expression ( OR rightDisjunctiveExpression= disjunctive_expression )* )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:352:4: leftDisjunctiveExpression= disjunctive_expression ( OR rightDisjunctiveExpression= disjunctive_expression )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(352, 30);
			PushFollow(Follow._disjunctive_expression_in_conjunctive_expression1215);
			leftDisjunctiveExpression=disjunctive_expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftDisjunctiveExpression.Tree);
			DebugLocation(352, 55);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:352:55: ( OR rightDisjunctiveExpression= disjunctive_expression )*
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=2;
				try { DebugEnterDecision(3, decisionCanBacktrack[3]);
				int LA3_0 = input.LA(1);

				if ((LA3_0==OR))
				{
					alt3=1;
				}


				} finally { DebugExitDecision(3); }
				switch ( alt3 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:352:56: OR rightDisjunctiveExpression= disjunctive_expression
					{
					DebugLocation(352, 58);
					OR5=(IToken)Match(input,OR,Follow._OR_in_conjunctive_expression1218); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR5_tree = (object)adaptor.Create(OR5);
					root_0 = (object)adaptor.BecomeRoot(OR5_tree, root_0);
					}
					DebugLocation(352, 87);
					PushFollow(Follow._disjunctive_expression_in_conjunctive_expression1225);
					rightDisjunctiveExpression=disjunctive_expression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, rightDisjunctiveExpression.Tree);

					}
					break;

				default:
					goto loop3;
				}
			}

			loop3:
				;

			} finally { DebugExitSubRule(3); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("conjunctive_expression", 4);
			LeaveRule("conjunctive_expression", 4);
			Leave_conjunctive_expression();
		}
		DebugLocation(353, 1);
		} finally { DebugExitRule(GrammarFileName, "conjunctive_expression"); }
		return retval;

	}
	// $ANTLR end "conjunctive_expression"

	public class disjunctive_expression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_disjunctive_expression();
	partial void Leave_disjunctive_expression();

	// $ANTLR start "disjunctive_expression"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:355:1: disjunctive_expression : leftRelationalExpression= relational_expression ( AND rightRelationalExpression= relational_expression )* ;
	[GrammarRule("disjunctive_expression")]
	private TigerParser.disjunctive_expression_return disjunctive_expression()
	{
		Enter_disjunctive_expression();
		EnterRule("disjunctive_expression", 5);
		TraceIn("disjunctive_expression", 5);
		TigerParser.disjunctive_expression_return retval = new TigerParser.disjunctive_expression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken AND6=null;
		TigerParser.relational_expression_return leftRelationalExpression = default(TigerParser.relational_expression_return);
		TigerParser.relational_expression_return rightRelationalExpression = default(TigerParser.relational_expression_return);

		object AND6_tree=null;

		try { DebugEnterRule(GrammarFileName, "disjunctive_expression");
		DebugLocation(355, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:356:2: (leftRelationalExpression= relational_expression ( AND rightRelationalExpression= relational_expression )* )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:356:4: leftRelationalExpression= relational_expression ( AND rightRelationalExpression= relational_expression )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(356, 29);
			PushFollow(Follow._relational_expression_in_disjunctive_expression1242);
			leftRelationalExpression=relational_expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftRelationalExpression.Tree);
			DebugLocation(356, 53);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:356:53: ( AND rightRelationalExpression= relational_expression )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				int LA4_0 = input.LA(1);

				if ((LA4_0==AND))
				{
					alt4=1;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:356:54: AND rightRelationalExpression= relational_expression
					{
					DebugLocation(356, 57);
					AND6=(IToken)Match(input,AND,Follow._AND_in_disjunctive_expression1245); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND6_tree = (object)adaptor.Create(AND6);
					root_0 = (object)adaptor.BecomeRoot(AND6_tree, root_0);
					}
					DebugLocation(356, 85);
					PushFollow(Follow._relational_expression_in_disjunctive_expression1252);
					rightRelationalExpression=relational_expression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, rightRelationalExpression.Tree);

					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("disjunctive_expression", 5);
			LeaveRule("disjunctive_expression", 5);
			Leave_disjunctive_expression();
		}
		DebugLocation(357, 1);
		} finally { DebugExitRule(GrammarFileName, "disjunctive_expression"); }
		return retval;

	}
	// $ANTLR end "disjunctive_expression"

	public class relational_expression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_relational_expression();
	partial void Leave_relational_expression();

	// $ANTLR start "relational_expression"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:359:1: relational_expression : leftArithmetic= arithmetic_expression ( ( EQUAL | NOT_EQUAL | LESS_THAN | LESS_EQUAL_THAN | GREATHER_THAN | GREATHER_EQUAL_THAN ) rigthArithmetic= arithmetic_expression )? ;
	[GrammarRule("relational_expression")]
	private TigerParser.relational_expression_return relational_expression()
	{
		Enter_relational_expression();
		EnterRule("relational_expression", 6);
		TraceIn("relational_expression", 6);
		TigerParser.relational_expression_return retval = new TigerParser.relational_expression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken EQUAL7=null;
		IToken NOT_EQUAL8=null;
		IToken LESS_THAN9=null;
		IToken LESS_EQUAL_THAN10=null;
		IToken GREATHER_THAN11=null;
		IToken GREATHER_EQUAL_THAN12=null;
		TigerParser.arithmetic_expression_return leftArithmetic = default(TigerParser.arithmetic_expression_return);
		TigerParser.arithmetic_expression_return rigthArithmetic = default(TigerParser.arithmetic_expression_return);

		object EQUAL7_tree=null;
		object NOT_EQUAL8_tree=null;
		object LESS_THAN9_tree=null;
		object LESS_EQUAL_THAN10_tree=null;
		object GREATHER_THAN11_tree=null;
		object GREATHER_EQUAL_THAN12_tree=null;

		try { DebugEnterRule(GrammarFileName, "relational_expression");
		DebugLocation(359, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:360:2: (leftArithmetic= arithmetic_expression ( ( EQUAL | NOT_EQUAL | LESS_THAN | LESS_EQUAL_THAN | GREATHER_THAN | GREATHER_EQUAL_THAN ) rigthArithmetic= arithmetic_expression )? )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:360:4: leftArithmetic= arithmetic_expression ( ( EQUAL | NOT_EQUAL | LESS_THAN | LESS_EQUAL_THAN | GREATHER_THAN | GREATHER_EQUAL_THAN ) rigthArithmetic= arithmetic_expression )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(360, 18);
			PushFollow(Follow._arithmetic_expression_in_relational_expression1268);
			leftArithmetic=arithmetic_expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftArithmetic.Tree);
			DebugLocation(360, 41);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:360:41: ( ( EQUAL | NOT_EQUAL | LESS_THAN | LESS_EQUAL_THAN | GREATHER_THAN | GREATHER_EQUAL_THAN ) rigthArithmetic= arithmetic_expression )?
			int alt6=2;
			try { DebugEnterSubRule(6);
			try { DebugEnterDecision(6, decisionCanBacktrack[6]);
			switch (input.LA(1))
			{
			case EQUAL:
				{
				alt6=1;
				}
				break;
			case NOT_EQUAL:
				{
				alt6=1;
				}
				break;
			case LESS_THAN:
				{
				alt6=1;
				}
				break;
			case LESS_EQUAL_THAN:
				{
				alt6=1;
				}
				break;
			case GREATHER_THAN:
				{
				alt6=1;
				}
				break;
			case GREATHER_EQUAL_THAN:
				{
				alt6=1;
				}
				break;
			}

			} finally { DebugExitDecision(6); }
			switch (alt6)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:360:42: ( EQUAL | NOT_EQUAL | LESS_THAN | LESS_EQUAL_THAN | GREATHER_THAN | GREATHER_EQUAL_THAN ) rigthArithmetic= arithmetic_expression
				{
				DebugLocation(360, 42);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:360:42: ( EQUAL | NOT_EQUAL | LESS_THAN | LESS_EQUAL_THAN | GREATHER_THAN | GREATHER_EQUAL_THAN )
				int alt5=6;
				try { DebugEnterSubRule(5);
				try { DebugEnterDecision(5, decisionCanBacktrack[5]);
				switch (input.LA(1))
				{
				case EQUAL:
					{
					alt5=1;
					}
					break;
				case NOT_EQUAL:
					{
					alt5=2;
					}
					break;
				case LESS_THAN:
					{
					alt5=3;
					}
					break;
				case LESS_EQUAL_THAN:
					{
					alt5=4;
					}
					break;
				case GREATHER_THAN:
					{
					alt5=5;
					}
					break;
				case GREATHER_EQUAL_THAN:
					{
					alt5=6;
					}
					break;
				default:
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 5, 0, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}

				} finally { DebugExitDecision(5); }
				switch (alt5)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:360:43: EQUAL
					{
					DebugLocation(360, 48);
					EQUAL7=(IToken)Match(input,EQUAL,Follow._EQUAL_in_relational_expression1271); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					EQUAL7_tree = (object)adaptor.Create(EQUAL7);
					root_0 = (object)adaptor.BecomeRoot(EQUAL7_tree, root_0);
					}

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:360:52: NOT_EQUAL
					{
					DebugLocation(360, 61);
					NOT_EQUAL8=(IToken)Match(input,NOT_EQUAL,Follow._NOT_EQUAL_in_relational_expression1276); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					NOT_EQUAL8_tree = (object)adaptor.Create(NOT_EQUAL8);
					root_0 = (object)adaptor.BecomeRoot(NOT_EQUAL8_tree, root_0);
					}

					}
					break;
				case 3:
					DebugEnterAlt(3);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:360:65: LESS_THAN
					{
					DebugLocation(360, 74);
					LESS_THAN9=(IToken)Match(input,LESS_THAN,Follow._LESS_THAN_in_relational_expression1281); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					LESS_THAN9_tree = (object)adaptor.Create(LESS_THAN9);
					root_0 = (object)adaptor.BecomeRoot(LESS_THAN9_tree, root_0);
					}

					}
					break;
				case 4:
					DebugEnterAlt(4);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:360:78: LESS_EQUAL_THAN
					{
					DebugLocation(360, 93);
					LESS_EQUAL_THAN10=(IToken)Match(input,LESS_EQUAL_THAN,Follow._LESS_EQUAL_THAN_in_relational_expression1286); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					LESS_EQUAL_THAN10_tree = (object)adaptor.Create(LESS_EQUAL_THAN10);
					root_0 = (object)adaptor.BecomeRoot(LESS_EQUAL_THAN10_tree, root_0);
					}

					}
					break;
				case 5:
					DebugEnterAlt(5);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:360:97: GREATHER_THAN
					{
					DebugLocation(360, 110);
					GREATHER_THAN11=(IToken)Match(input,GREATHER_THAN,Follow._GREATHER_THAN_in_relational_expression1291); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					GREATHER_THAN11_tree = (object)adaptor.Create(GREATHER_THAN11);
					root_0 = (object)adaptor.BecomeRoot(GREATHER_THAN11_tree, root_0);
					}

					}
					break;
				case 6:
					DebugEnterAlt(6);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:360:114: GREATHER_EQUAL_THAN
					{
					DebugLocation(360, 133);
					GREATHER_EQUAL_THAN12=(IToken)Match(input,GREATHER_EQUAL_THAN,Follow._GREATHER_EQUAL_THAN_in_relational_expression1296); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					GREATHER_EQUAL_THAN12_tree = (object)adaptor.Create(GREATHER_EQUAL_THAN12);
					root_0 = (object)adaptor.BecomeRoot(GREATHER_EQUAL_THAN12_tree, root_0);
					}

					}
					break;

				}
				} finally { DebugExitSubRule(5); }

				DebugLocation(360, 151);
				PushFollow(Follow._arithmetic_expression_in_relational_expression1303);
				rigthArithmetic=arithmetic_expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, rigthArithmetic.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(6); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("relational_expression", 6);
			LeaveRule("relational_expression", 6);
			Leave_relational_expression();
		}
		DebugLocation(361, 1);
		} finally { DebugExitRule(GrammarFileName, "relational_expression"); }
		return retval;

	}
	// $ANTLR end "relational_expression"

	public class arithmetic_expression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_arithmetic_expression();
	partial void Leave_arithmetic_expression();

	// $ANTLR start "arithmetic_expression"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:363:1: arithmetic_expression : leftTerm= term ( ( PLUS | MINUS ) rightTerm= term )* ;
	[GrammarRule("arithmetic_expression")]
	private TigerParser.arithmetic_expression_return arithmetic_expression()
	{
		Enter_arithmetic_expression();
		EnterRule("arithmetic_expression", 7);
		TraceIn("arithmetic_expression", 7);
		TigerParser.arithmetic_expression_return retval = new TigerParser.arithmetic_expression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken PLUS13=null;
		IToken MINUS14=null;
		TigerParser.term_return leftTerm = default(TigerParser.term_return);
		TigerParser.term_return rightTerm = default(TigerParser.term_return);

		object PLUS13_tree=null;
		object MINUS14_tree=null;

		try { DebugEnterRule(GrammarFileName, "arithmetic_expression");
		DebugLocation(363, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:364:2: (leftTerm= term ( ( PLUS | MINUS ) rightTerm= term )* )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:364:4: leftTerm= term ( ( PLUS | MINUS ) rightTerm= term )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(364, 13);
			PushFollow(Follow._term_in_arithmetic_expression1320);
			leftTerm=term();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftTerm.Tree);
			DebugLocation(364, 20);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:364:20: ( ( PLUS | MINUS ) rightTerm= term )*
			try { DebugEnterSubRule(8);
			while (true)
			{
				int alt8=2;
				try { DebugEnterDecision(8, decisionCanBacktrack[8]);
				int LA8_0 = input.LA(1);

				if ((LA8_0==PLUS))
				{
					alt8=1;
				}
				else if ((LA8_0==MINUS))
				{
					alt8=1;
				}


				} finally { DebugExitDecision(8); }
				switch ( alt8 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:364:21: ( PLUS | MINUS ) rightTerm= term
					{
					DebugLocation(364, 21);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:364:21: ( PLUS | MINUS )
					int alt7=2;
					try { DebugEnterSubRule(7);
					try { DebugEnterDecision(7, decisionCanBacktrack[7]);
					int LA7_0 = input.LA(1);

					if ((LA7_0==PLUS))
					{
						alt7=1;
					}
					else if ((LA7_0==MINUS))
					{
						alt7=2;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 7, 0, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
					} finally { DebugExitDecision(7); }
					switch (alt7)
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:364:22: PLUS
						{
						DebugLocation(364, 26);
						PLUS13=(IToken)Match(input,PLUS,Follow._PLUS_in_arithmetic_expression1324); if (state.failed) return retval;
						if ( state.backtracking == 0 ) {
						PLUS13_tree = (object)adaptor.Create(PLUS13);
						root_0 = (object)adaptor.BecomeRoot(PLUS13_tree, root_0);
						}

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:364:30: MINUS
						{
						DebugLocation(364, 35);
						MINUS14=(IToken)Match(input,MINUS,Follow._MINUS_in_arithmetic_expression1329); if (state.failed) return retval;
						if ( state.backtracking == 0 ) {
						MINUS14_tree = (object)adaptor.Create(MINUS14);
						root_0 = (object)adaptor.BecomeRoot(MINUS14_tree, root_0);
						}

						}
						break;

					}
					} finally { DebugExitSubRule(7); }

					DebugLocation(364, 48);
					PushFollow(Follow._term_in_arithmetic_expression1337);
					rightTerm=term();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, rightTerm.Tree);

					}
					break;

				default:
					goto loop8;
				}
			}

			loop8:
				;

			} finally { DebugExitSubRule(8); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("arithmetic_expression", 7);
			LeaveRule("arithmetic_expression", 7);
			Leave_arithmetic_expression();
		}
		DebugLocation(365, 1);
		} finally { DebugExitRule(GrammarFileName, "arithmetic_expression"); }
		return retval;

	}
	// $ANTLR end "arithmetic_expression"

	public class term_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_term();
	partial void Leave_term();

	// $ANTLR start "term"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:367:1: term : leftFactor= factor ( ( MULTIPLICATION | DIVISION ) rightFactor= factor )* ;
	[GrammarRule("term")]
	private TigerParser.term_return term()
	{
		Enter_term();
		EnterRule("term", 8);
		TraceIn("term", 8);
		TigerParser.term_return retval = new TigerParser.term_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken MULTIPLICATION15=null;
		IToken DIVISION16=null;
		TigerParser.factor_return leftFactor = default(TigerParser.factor_return);
		TigerParser.factor_return rightFactor = default(TigerParser.factor_return);

		object MULTIPLICATION15_tree=null;
		object DIVISION16_tree=null;

		try { DebugEnterRule(GrammarFileName, "term");
		DebugLocation(367, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:367:6: (leftFactor= factor ( ( MULTIPLICATION | DIVISION ) rightFactor= factor )* )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:367:8: leftFactor= factor ( ( MULTIPLICATION | DIVISION ) rightFactor= factor )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(367, 19);
			PushFollow(Follow._factor_in_term1353);
			leftFactor=factor();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftFactor.Tree);
			DebugLocation(367, 28);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:367:28: ( ( MULTIPLICATION | DIVISION ) rightFactor= factor )*
			try { DebugEnterSubRule(10);
			while (true)
			{
				int alt10=2;
				try { DebugEnterDecision(10, decisionCanBacktrack[10]);
				int LA10_0 = input.LA(1);

				if ((LA10_0==MULTIPLICATION))
				{
					alt10=1;
				}
				else if ((LA10_0==DIVISION))
				{
					alt10=1;
				}


				} finally { DebugExitDecision(10); }
				switch ( alt10 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:367:29: ( MULTIPLICATION | DIVISION ) rightFactor= factor
					{
					DebugLocation(367, 29);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:367:29: ( MULTIPLICATION | DIVISION )
					int alt9=2;
					try { DebugEnterSubRule(9);
					try { DebugEnterDecision(9, decisionCanBacktrack[9]);
					int LA9_0 = input.LA(1);

					if ((LA9_0==MULTIPLICATION))
					{
						alt9=1;
					}
					else if ((LA9_0==DIVISION))
					{
						alt9=2;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 9, 0, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
					} finally { DebugExitDecision(9); }
					switch (alt9)
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:367:30: MULTIPLICATION
						{
						DebugLocation(367, 44);
						MULTIPLICATION15=(IToken)Match(input,MULTIPLICATION,Follow._MULTIPLICATION_in_term1357); if (state.failed) return retval;
						if ( state.backtracking == 0 ) {
						MULTIPLICATION15_tree = (object)adaptor.Create(MULTIPLICATION15);
						root_0 = (object)adaptor.BecomeRoot(MULTIPLICATION15_tree, root_0);
						}

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:367:48: DIVISION
						{
						DebugLocation(367, 56);
						DIVISION16=(IToken)Match(input,DIVISION,Follow._DIVISION_in_term1362); if (state.failed) return retval;
						if ( state.backtracking == 0 ) {
						DIVISION16_tree = (object)adaptor.Create(DIVISION16);
						root_0 = (object)adaptor.BecomeRoot(DIVISION16_tree, root_0);
						}

						}
						break;

					}
					} finally { DebugExitSubRule(9); }

					DebugLocation(367, 71);
					PushFollow(Follow._factor_in_term1370);
					rightFactor=factor();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, rightFactor.Tree);

					}
					break;

				default:
					goto loop10;
				}
			}

			loop10:
				;

			} finally { DebugExitSubRule(10); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("term", 8);
			LeaveRule("term", 8);
			Leave_term();
		}
		DebugLocation(368, 1);
		} finally { DebugExitRule(GrammarFileName, "term"); }
		return retval;

	}
	// $ANTLR end "term"

	public class factor_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_factor();
	partial void Leave_factor();

	// $ANTLR start "factor"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:370:1: factor : ( MINUS factor -> ^( UNARY_MINUS factor ) | value_returner | not_value_returner );
	[GrammarRule("factor")]
	private TigerParser.factor_return factor()
	{
		Enter_factor();
		EnterRule("factor", 9);
		TraceIn("factor", 9);
		TigerParser.factor_return retval = new TigerParser.factor_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken MINUS17=null;
		TigerParser.factor_return factor18 = default(TigerParser.factor_return);
		TigerParser.value_returner_return value_returner19 = default(TigerParser.value_returner_return);
		TigerParser.not_value_returner_return not_value_returner20 = default(TigerParser.not_value_returner_return);

		object MINUS17_tree=null;
		RewriteRuleITokenStream stream_MINUS=new RewriteRuleITokenStream(adaptor,"token MINUS");
		RewriteRuleSubtreeStream stream_factor=new RewriteRuleSubtreeStream(adaptor,"rule factor");
		try { DebugEnterRule(GrammarFileName, "factor");
		DebugLocation(370, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:370:8: ( MINUS factor -> ^( UNARY_MINUS factor ) | value_returner | not_value_returner )
			int alt11=3;
			try { DebugEnterDecision(11, decisionCanBacktrack[11]);
			switch (input.LA(1))
			{
			case MINUS:
				{
				alt11=1;
				}
				break;
			case LET:
			case NIL:
			case LEFT_PARENTHESIS:
			case ID:
			case INT:
			case STRING:
				{
				alt11=2;
				}
				break;
			case BREAK:
			case FOR:
			case IF:
			case WHILE:
				{
				alt11=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 11, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(11); }
			switch (alt11)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:370:10: MINUS factor
				{
				DebugLocation(370, 10);
				MINUS17=(IToken)Match(input,MINUS,Follow._MINUS_in_factor1382); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_MINUS.Add(MINUS17);

				DebugLocation(370, 16);
				PushFollow(Follow._factor_in_factor1384);
				factor18=factor();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_factor.Add(factor18.Tree);


				{
				// AST REWRITE
				// elements: factor
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 370:23: -> ^( UNARY_MINUS factor )
				{
					DebugLocation(370, 26);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:370:26: ^( UNARY_MINUS factor )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(370, 28);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(UNARY_MINUS, "UNARY_MINUS"), root_1);

					DebugLocation(370, 40);
					adaptor.AddChild(root_1, stream_factor.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:371:4: value_returner
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(371, 4);
				PushFollow(Follow._value_returner_in_factor1397);
				value_returner19=value_returner();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value_returner19.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:372:4: not_value_returner
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(372, 4);
				PushFollow(Follow._not_value_returner_in_factor1402);
				not_value_returner20=not_value_returner();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, not_value_returner20.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("factor", 9);
			LeaveRule("factor", 9);
			Leave_factor();
		}
		DebugLocation(373, 1);
		} finally { DebugExitRule(GrammarFileName, "factor"); }
		return retval;

	}
	// $ANTLR end "factor"

	public class value_returner_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_value_returner();
	partial void Leave_value_returner();

	// $ANTLR start "value_returner"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:375:1: value_returner : ( STRING | INT | NIL | leftId= id (recordAccess= record_access[(CommonTree)leftId.Tree] leftValue= left_value[(CommonTree)recordAccess.Tree] -> $leftValue | ind= indexer[(CommonTree)leftId.Tree] ( OF expression -> ^( ARRAY_DECLARATION $leftId expression ) | leftValue= left_value[(CommonTree)ind.Tree] -> $leftValue) | functionCall= function_call[(CommonTree)leftId.Tree] leftValue= left_value[(CommonTree)functionCall.Tree] -> $leftValue | recordAssignment= record_assignment[(CommonTree)leftId.Tree] (recordAccess= record_access[(CommonTree)recordAssignment.Tree] leftValue= left_value[(CommonTree)recordAccess.Tree] -> $leftValue | -> $recordAssignment) | -> $leftId) | tupleExpression= tuple_expression leftValue= left_value[(CommonTree)tupleExpression.Tree] -> $leftValue | letExpression= let_expression leftValue= left_value[(CommonTree)letExpression.Tree] -> $leftValue);
	[GrammarRule("value_returner")]
	private TigerParser.value_returner_return value_returner()
	{
		Enter_value_returner();
		EnterRule("value_returner", 10);
		TraceIn("value_returner", 10);
		TigerParser.value_returner_return retval = new TigerParser.value_returner_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken STRING21=null;
		IToken INT22=null;
		IToken NIL23=null;
		IToken OF24=null;
		TigerParser.id_return leftId = default(TigerParser.id_return);
		TigerParser.record_access_return recordAccess = default(TigerParser.record_access_return);
		TigerParser.left_value_return leftValue = default(TigerParser.left_value_return);
		TigerParser.indexer_return ind = default(TigerParser.indexer_return);
		TigerParser.function_call_return functionCall = default(TigerParser.function_call_return);
		TigerParser.record_assignment_return recordAssignment = default(TigerParser.record_assignment_return);
		TigerParser.tuple_expression_return tupleExpression = default(TigerParser.tuple_expression_return);
		TigerParser.let_expression_return letExpression = default(TigerParser.let_expression_return);
		TigerParser.expression_return expression25 = default(TigerParser.expression_return);

		object STRING21_tree=null;
		object INT22_tree=null;
		object NIL23_tree=null;
		object OF24_tree=null;
		RewriteRuleITokenStream stream_OF=new RewriteRuleITokenStream(adaptor,"token OF");
		RewriteRuleSubtreeStream stream_id=new RewriteRuleSubtreeStream(adaptor,"rule id");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		RewriteRuleSubtreeStream stream_let_expression=new RewriteRuleSubtreeStream(adaptor,"rule let_expression");
		RewriteRuleSubtreeStream stream_record_assignment=new RewriteRuleSubtreeStream(adaptor,"rule record_assignment");
		RewriteRuleSubtreeStream stream_left_value=new RewriteRuleSubtreeStream(adaptor,"rule left_value");
		RewriteRuleSubtreeStream stream_function_call=new RewriteRuleSubtreeStream(adaptor,"rule function_call");
		RewriteRuleSubtreeStream stream_indexer=new RewriteRuleSubtreeStream(adaptor,"rule indexer");
		RewriteRuleSubtreeStream stream_tuple_expression=new RewriteRuleSubtreeStream(adaptor,"rule tuple_expression");
		RewriteRuleSubtreeStream stream_record_access=new RewriteRuleSubtreeStream(adaptor,"rule record_access");
		try { DebugEnterRule(GrammarFileName, "value_returner");
		DebugLocation(375, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:376:2: ( STRING | INT | NIL | leftId= id (recordAccess= record_access[(CommonTree)leftId.Tree] leftValue= left_value[(CommonTree)recordAccess.Tree] -> $leftValue | ind= indexer[(CommonTree)leftId.Tree] ( OF expression -> ^( ARRAY_DECLARATION $leftId expression ) | leftValue= left_value[(CommonTree)ind.Tree] -> $leftValue) | functionCall= function_call[(CommonTree)leftId.Tree] leftValue= left_value[(CommonTree)functionCall.Tree] -> $leftValue | recordAssignment= record_assignment[(CommonTree)leftId.Tree] (recordAccess= record_access[(CommonTree)recordAssignment.Tree] leftValue= left_value[(CommonTree)recordAccess.Tree] -> $leftValue | -> $recordAssignment) | -> $leftId) | tupleExpression= tuple_expression leftValue= left_value[(CommonTree)tupleExpression.Tree] -> $leftValue | letExpression= let_expression leftValue= left_value[(CommonTree)letExpression.Tree] -> $leftValue)
			int alt15=6;
			try { DebugEnterDecision(15, decisionCanBacktrack[15]);
			switch (input.LA(1))
			{
			case STRING:
				{
				alt15=1;
				}
				break;
			case INT:
				{
				alt15=2;
				}
				break;
			case NIL:
				{
				alt15=3;
				}
				break;
			case ID:
				{
				alt15=4;
				}
				break;
			case LEFT_PARENTHESIS:
				{
				alt15=5;
				}
				break;
			case LET:
				{
				alt15=6;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 15, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(15); }
			switch (alt15)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:376:4: STRING
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(376, 4);
				STRING21=(IToken)Match(input,STRING,Follow._STRING_in_value_returner1413); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				STRING21_tree = (object)adaptor.Create(STRING21);
				adaptor.AddChild(root_0, STRING21_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:377:4: INT
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(377, 4);
				INT22=(IToken)Match(input,INT,Follow._INT_in_value_returner1418); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				INT22_tree = (object)adaptor.Create(INT22);
				adaptor.AddChild(root_0, INT22_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:378:4: NIL
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(378, 4);
				NIL23=(IToken)Match(input,NIL,Follow._NIL_in_value_returner1423); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				NIL23_tree = (object)adaptor.Create(NIL23);
				adaptor.AddChild(root_0, NIL23_tree);
				}

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:379:4: leftId= id (recordAccess= record_access[(CommonTree)leftId.Tree] leftValue= left_value[(CommonTree)recordAccess.Tree] -> $leftValue | ind= indexer[(CommonTree)leftId.Tree] ( OF expression -> ^( ARRAY_DECLARATION $leftId expression ) | leftValue= left_value[(CommonTree)ind.Tree] -> $leftValue) | functionCall= function_call[(CommonTree)leftId.Tree] leftValue= left_value[(CommonTree)functionCall.Tree] -> $leftValue | recordAssignment= record_assignment[(CommonTree)leftId.Tree] (recordAccess= record_access[(CommonTree)recordAssignment.Tree] leftValue= left_value[(CommonTree)recordAccess.Tree] -> $leftValue | -> $recordAssignment) | -> $leftId)
				{
				DebugLocation(379, 11);
				PushFollow(Follow._id_in_value_returner1432);
				leftId=id();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_id.Add(leftId.Tree);
				DebugLocation(380, 3);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:380:3: (recordAccess= record_access[(CommonTree)leftId.Tree] leftValue= left_value[(CommonTree)recordAccess.Tree] -> $leftValue | ind= indexer[(CommonTree)leftId.Tree] ( OF expression -> ^( ARRAY_DECLARATION $leftId expression ) | leftValue= left_value[(CommonTree)ind.Tree] -> $leftValue) | functionCall= function_call[(CommonTree)leftId.Tree] leftValue= left_value[(CommonTree)functionCall.Tree] -> $leftValue | recordAssignment= record_assignment[(CommonTree)leftId.Tree] (recordAccess= record_access[(CommonTree)recordAssignment.Tree] leftValue= left_value[(CommonTree)recordAccess.Tree] -> $leftValue | -> $recordAssignment) | -> $leftId)
				int alt14=5;
				try { DebugEnterSubRule(14);
				try { DebugEnterDecision(14, decisionCanBacktrack[14]);
				switch (input.LA(1))
				{
				case DOT:
					{
					alt14=1;
					}
					break;
				case LEFT_BRACKET:
					{
					alt14=2;
					}
					break;
				case LEFT_PARENTHESIS:
					{
					alt14=3;
					}
					break;
				case LEFT_KEY:
					{
					alt14=4;
					}
					break;
				case EOF:
				case DO:
				case ELSE:
				case END:
				case FUNCTION:
				case IN:
				case THEN:
				case TO:
				case TYPE:
				case VAR:
				case COMMA:
				case SEMICOLON:
				case RIGHT_PARENTHESIS:
				case RIGHT_BRACKET:
				case RIGHT_KEY:
				case PLUS:
				case MINUS:
				case MULTIPLICATION:
				case DIVISION:
				case EQUAL:
				case NOT_EQUAL:
				case LESS_THAN:
				case LESS_EQUAL_THAN:
				case GREATHER_THAN:
				case GREATHER_EQUAL_THAN:
				case AND:
				case OR:
					{
					alt14=5;
					}
					break;
				default:
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 14, 0, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}

				} finally { DebugExitDecision(14); }
				switch (alt14)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:380:5: recordAccess= record_access[(CommonTree)leftId.Tree] leftValue= left_value[(CommonTree)recordAccess.Tree]
					{
					DebugLocation(380, 18);
					PushFollow(Follow._record_access_in_value_returner1442);
					recordAccess=record_access((CommonTree)leftId.Tree);
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_record_access.Add(recordAccess.Tree);
					DebugLocation(380, 69);
					PushFollow(Follow._left_value_in_value_returner1449);
					leftValue=left_value((CommonTree)recordAccess.Tree);
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_left_value.Add(leftValue.Tree);


					{
					// AST REWRITE
					// elements: leftValue
					// token labels: 
					// rule labels: retval, leftValue
					// token list labels: 
					// rule list labels: 
					// wildcard labels: 
					if ( state.backtracking == 0 ) {
					retval.Tree = root_0;
					RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
					RewriteRuleSubtreeStream stream_leftValue=new RewriteRuleSubtreeStream(adaptor,"rule leftValue",leftValue!=null?leftValue.Tree:null);

					root_0 = (object)adaptor.Nil();
					// 380:113: -> $leftValue
					{
						DebugLocation(380, 116);
						adaptor.AddChild(root_0, stream_leftValue.NextTree());

					}

					retval.Tree = root_0;
					}
					}

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:381:5: ind= indexer[(CommonTree)leftId.Tree] ( OF expression -> ^( ARRAY_DECLARATION $leftId expression ) | leftValue= left_value[(CommonTree)ind.Tree] -> $leftValue)
					{
					DebugLocation(381, 9);
					PushFollow(Follow._indexer_in_value_returner1465);
					ind=indexer((CommonTree)leftId.Tree);
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_indexer.Add(ind.Tree);
					DebugLocation(381, 44);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:381:44: ( OF expression -> ^( ARRAY_DECLARATION $leftId expression ) | leftValue= left_value[(CommonTree)ind.Tree] -> $leftValue)
					int alt12=2;
					try { DebugEnterSubRule(12);
					try { DebugEnterDecision(12, decisionCanBacktrack[12]);
					int LA12_0 = input.LA(1);

					if ((LA12_0==OF))
					{
						alt12=1;
					}
					else if ((LA12_0==EOF||(LA12_0>=DO && LA12_0<=END)||LA12_0==FUNCTION||LA12_0==IN||(LA12_0>=THEN && LA12_0<=VAR)||LA12_0==COMMA||LA12_0==SEMICOLON||(LA12_0>=RIGHT_PARENTHESIS && LA12_0<=RIGHT_BRACKET)||(LA12_0>=RIGHT_KEY && LA12_0<=ASSIGNMENT)))
					{
						alt12=2;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 12, 0, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
					} finally { DebugExitDecision(12); }
					switch (alt12)
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:381:46: OF expression
						{
						DebugLocation(381, 46);
						OF24=(IToken)Match(input,OF,Follow._OF_in_value_returner1470); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_OF.Add(OF24);

						DebugLocation(381, 49);
						PushFollow(Follow._expression_in_value_returner1472);
						expression25=expression();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) stream_expression.Add(expression25.Tree);


						{
						// AST REWRITE
						// elements: leftId, expression
						// token labels: 
						// rule labels: retval, leftId
						// token list labels: 
						// rule list labels: 
						// wildcard labels: 
						if ( state.backtracking == 0 ) {
						retval.Tree = root_0;
						RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
						RewriteRuleSubtreeStream stream_leftId=new RewriteRuleSubtreeStream(adaptor,"rule leftId",leftId!=null?leftId.Tree:null);

						root_0 = (object)adaptor.Nil();
						// 381:60: -> ^( ARRAY_DECLARATION $leftId expression )
						{
							DebugLocation(381, 63);
							// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:381:63: ^( ARRAY_DECLARATION $leftId expression )
							{
							object root_1 = (object)adaptor.Nil();
							DebugLocation(381, 65);
							root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAY_DECLARATION, "ARRAY_DECLARATION"), root_1);

							DebugLocation(381, 83);
							adaptor.AddChild(root_1, stream_leftId.NextTree());
							DebugLocation(381, 91);
							adaptor.AddChild(root_1, (ind!=null?ind.betweenBracketsExpression:default(ITree)));
							DebugLocation(381, 124);
							adaptor.AddChild(root_1, stream_expression.NextTree());

							adaptor.AddChild(root_0, root_1);
							}

						}

						retval.Tree = root_0;
						}
						}

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:382:11: leftValue= left_value[(CommonTree)ind.Tree]
						{
						DebugLocation(382, 21);
						PushFollow(Follow._left_value_in_value_returner1501);
						leftValue=left_value((CommonTree)ind.Tree);
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) stream_left_value.Add(leftValue.Tree);


						{
						// AST REWRITE
						// elements: leftValue
						// token labels: 
						// rule labels: retval, leftValue
						// token list labels: 
						// rule list labels: 
						// wildcard labels: 
						if ( state.backtracking == 0 ) {
						retval.Tree = root_0;
						RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
						RewriteRuleSubtreeStream stream_leftValue=new RewriteRuleSubtreeStream(adaptor,"rule leftValue",leftValue!=null?leftValue.Tree:null);

						root_0 = (object)adaptor.Nil();
						// 382:56: -> $leftValue
						{
							DebugLocation(382, 59);
							adaptor.AddChild(root_0, stream_leftValue.NextTree());

						}

						retval.Tree = root_0;
						}
						}

						}
						break;

					}
					} finally { DebugExitSubRule(12); }


					}
					break;
				case 3:
					DebugEnterAlt(3);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:384:5: functionCall= function_call[(CommonTree)leftId.Tree] leftValue= left_value[(CommonTree)functionCall.Tree]
					{
					DebugLocation(384, 18);
					PushFollow(Follow._function_call_in_value_returner1527);
					functionCall=function_call((CommonTree)leftId.Tree);
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_function_call.Add(functionCall.Tree);
					DebugLocation(384, 69);
					PushFollow(Follow._left_value_in_value_returner1534);
					leftValue=left_value((CommonTree)functionCall.Tree);
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_left_value.Add(leftValue.Tree);


					{
					// AST REWRITE
					// elements: leftValue
					// token labels: 
					// rule labels: retval, leftValue
					// token list labels: 
					// rule list labels: 
					// wildcard labels: 
					if ( state.backtracking == 0 ) {
					retval.Tree = root_0;
					RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
					RewriteRuleSubtreeStream stream_leftValue=new RewriteRuleSubtreeStream(adaptor,"rule leftValue",leftValue!=null?leftValue.Tree:null);

					root_0 = (object)adaptor.Nil();
					// 384:113: -> $leftValue
					{
						DebugLocation(384, 116);
						adaptor.AddChild(root_0, stream_leftValue.NextTree());

					}

					retval.Tree = root_0;
					}
					}

					}
					break;
				case 4:
					DebugEnterAlt(4);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:385:5: recordAssignment= record_assignment[(CommonTree)leftId.Tree] (recordAccess= record_access[(CommonTree)recordAssignment.Tree] leftValue= left_value[(CommonTree)recordAccess.Tree] -> $leftValue | -> $recordAssignment)
					{
					DebugLocation(385, 22);
					PushFollow(Follow._record_assignment_in_value_returner1550);
					recordAssignment=record_assignment((CommonTree)leftId.Tree);
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_record_assignment.Add(recordAssignment.Tree);
					DebugLocation(385, 67);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:385:67: (recordAccess= record_access[(CommonTree)recordAssignment.Tree] leftValue= left_value[(CommonTree)recordAccess.Tree] -> $leftValue | -> $recordAssignment)
					int alt13=2;
					try { DebugEnterSubRule(13);
					try { DebugEnterDecision(13, decisionCanBacktrack[13]);
					int LA13_0 = input.LA(1);

					if ((LA13_0==DOT))
					{
						alt13=1;
					}
					else if ((LA13_0==EOF||(LA13_0>=DO && LA13_0<=END)||LA13_0==FUNCTION||LA13_0==IN||(LA13_0>=THEN && LA13_0<=VAR)||LA13_0==COMMA||LA13_0==SEMICOLON||LA13_0==RIGHT_PARENTHESIS||LA13_0==RIGHT_BRACKET||LA13_0==RIGHT_KEY||(LA13_0>=PLUS && LA13_0<=OR)))
					{
						alt13=2;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 13, 0, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
					} finally { DebugExitDecision(13); }
					switch (alt13)
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:385:69: recordAccess= record_access[(CommonTree)recordAssignment.Tree] leftValue= left_value[(CommonTree)recordAccess.Tree]
						{
						DebugLocation(385, 82);
						PushFollow(Follow._record_access_in_value_returner1559);
						recordAccess=record_access((CommonTree)recordAssignment.Tree);
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) stream_record_access.Add(recordAccess.Tree);
						DebugLocation(385, 143);
						PushFollow(Follow._left_value_in_value_returner1566);
						leftValue=left_value((CommonTree)recordAccess.Tree);
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) stream_left_value.Add(leftValue.Tree);


						{
						// AST REWRITE
						// elements: leftValue
						// token labels: 
						// rule labels: retval, leftValue
						// token list labels: 
						// rule list labels: 
						// wildcard labels: 
						if ( state.backtracking == 0 ) {
						retval.Tree = root_0;
						RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
						RewriteRuleSubtreeStream stream_leftValue=new RewriteRuleSubtreeStream(adaptor,"rule leftValue",leftValue!=null?leftValue.Tree:null);

						root_0 = (object)adaptor.Nil();
						// 385:187: -> $leftValue
						{
							DebugLocation(385, 190);
							adaptor.AddChild(root_0, stream_leftValue.NextTree());

						}

						retval.Tree = root_0;
						}
						}

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:386:13: 
						{

						{
						// AST REWRITE
						// elements: recordAssignment
						// token labels: 
						// rule labels: retval, recordAssignment
						// token list labels: 
						// rule list labels: 
						// wildcard labels: 
						if ( state.backtracking == 0 ) {
						retval.Tree = root_0;
						RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
						RewriteRuleSubtreeStream stream_recordAssignment=new RewriteRuleSubtreeStream(adaptor,"rule recordAssignment",recordAssignment!=null?recordAssignment.Tree:null);

						root_0 = (object)adaptor.Nil();
						// 386:13: -> $recordAssignment
						{
							DebugLocation(386, 16);
							adaptor.AddChild(root_0, stream_recordAssignment.NextTree());

						}

						retval.Tree = root_0;
						}
						}

						}
						break;

					}
					} finally { DebugExitSubRule(13); }


					}
					break;
				case 5:
					DebugEnterAlt(5);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:388:5: 
					{

					{
					// AST REWRITE
					// elements: leftId
					// token labels: 
					// rule labels: retval, leftId
					// token list labels: 
					// rule list labels: 
					// wildcard labels: 
					if ( state.backtracking == 0 ) {
					retval.Tree = root_0;
					RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
					RewriteRuleSubtreeStream stream_leftId=new RewriteRuleSubtreeStream(adaptor,"rule leftId",leftId!=null?leftId.Tree:null);

					root_0 = (object)adaptor.Nil();
					// 388:5: -> $leftId
					{
						DebugLocation(388, 8);
						adaptor.AddChild(root_0, stream_leftId.NextTree());

					}

					retval.Tree = root_0;
					}
					}

					}
					break;

				}
				} finally { DebugExitSubRule(14); }


				}
				break;
			case 5:
				DebugEnterAlt(5);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:390:4: tupleExpression= tuple_expression leftValue= left_value[(CommonTree)tupleExpression.Tree]
				{
				DebugLocation(390, 20);
				PushFollow(Follow._tuple_expression_in_value_returner1623);
				tupleExpression=tuple_expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_tuple_expression.Add(tupleExpression.Tree);
				DebugLocation(390, 49);
				PushFollow(Follow._left_value_in_value_returner1629);
				leftValue=left_value((CommonTree)tupleExpression.Tree);
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_left_value.Add(leftValue.Tree);


				{
				// AST REWRITE
				// elements: leftValue
				// token labels: 
				// rule labels: retval, leftValue
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
				RewriteRuleSubtreeStream stream_leftValue=new RewriteRuleSubtreeStream(adaptor,"rule leftValue",leftValue!=null?leftValue.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 390:96: -> $leftValue
				{
					DebugLocation(390, 99);
					adaptor.AddChild(root_0, stream_leftValue.NextTree());

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:391:4: letExpression= let_expression leftValue= left_value[(CommonTree)letExpression.Tree]
				{
				DebugLocation(391, 18);
				PushFollow(Follow._let_expression_in_value_returner1644);
				letExpression=let_expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_let_expression.Add(letExpression.Tree);
				DebugLocation(391, 45);
				PushFollow(Follow._left_value_in_value_returner1650);
				leftValue=left_value((CommonTree)letExpression.Tree);
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_left_value.Add(leftValue.Tree);


				{
				// AST REWRITE
				// elements: leftValue
				// token labels: 
				// rule labels: retval, leftValue
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
				RewriteRuleSubtreeStream stream_leftValue=new RewriteRuleSubtreeStream(adaptor,"rule leftValue",leftValue!=null?leftValue.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 391:90: -> $leftValue
				{
					DebugLocation(391, 93);
					adaptor.AddChild(root_0, stream_leftValue.NextTree());

				}

				retval.Tree = root_0;
				}
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("value_returner", 10);
			LeaveRule("value_returner", 10);
			Leave_value_returner();
		}
		DebugLocation(392, 1);
		} finally { DebugExitRule(GrammarFileName, "value_returner"); }
		return retval;

	}
	// $ANTLR end "value_returner"

	public class id_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_id();
	partial void Leave_id();

	// $ANTLR start "id"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:394:1: id : ID ;
	[GrammarRule("id")]
	private TigerParser.id_return id()
	{
		Enter_id();
		EnterRule("id", 11);
		TraceIn("id", 11);
		TigerParser.id_return retval = new TigerParser.id_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID26=null;

		object ID26_tree=null;

		try { DebugEnterRule(GrammarFileName, "id");
		DebugLocation(394, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:394:4: ( ID )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:394:6: ID
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(394, 8);
			ID26=(IToken)Match(input,ID,Follow._ID_in_id1666); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			ID26_tree = (object)adaptor.Create(ID26);
			root_0 = (object)adaptor.BecomeRoot(ID26_tree, root_0);
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("id", 11);
			LeaveRule("id", 11);
			Leave_id();
		}
		DebugLocation(395, 1);
		} finally { DebugExitRule(GrammarFileName, "id"); }
		return retval;

	}
	// $ANTLR end "id"

	public class function_call_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_function_call();
	partial void Leave_function_call();

	// $ANTLR start "function_call"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:397:1: function_call[CommonTree leftId] : LEFT_PARENTHESIS ( expression_list )? RIGHT_PARENTHESIS -> ^( FUNCTION_CALL ( expression_list )? ) ;
	[GrammarRule("function_call")]
	private TigerParser.function_call_return function_call(CommonTree leftId)
	{
		Enter_function_call();
		EnterRule("function_call", 12);
		TraceIn("function_call", 12);
		TigerParser.function_call_return retval = new TigerParser.function_call_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken LEFT_PARENTHESIS27=null;
		IToken RIGHT_PARENTHESIS29=null;
		TigerParser.expression_list_return expression_list28 = default(TigerParser.expression_list_return);

		object LEFT_PARENTHESIS27_tree=null;
		object RIGHT_PARENTHESIS29_tree=null;
		RewriteRuleITokenStream stream_RIGHT_PARENTHESIS=new RewriteRuleITokenStream(adaptor,"token RIGHT_PARENTHESIS");
		RewriteRuleITokenStream stream_LEFT_PARENTHESIS=new RewriteRuleITokenStream(adaptor,"token LEFT_PARENTHESIS");
		RewriteRuleSubtreeStream stream_expression_list=new RewriteRuleSubtreeStream(adaptor,"rule expression_list");
		try { DebugEnterRule(GrammarFileName, "function_call");
		DebugLocation(397, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:398:2: ( LEFT_PARENTHESIS ( expression_list )? RIGHT_PARENTHESIS -> ^( FUNCTION_CALL ( expression_list )? ) )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:398:4: LEFT_PARENTHESIS ( expression_list )? RIGHT_PARENTHESIS
			{
			DebugLocation(398, 4);
			LEFT_PARENTHESIS27=(IToken)Match(input,LEFT_PARENTHESIS,Follow._LEFT_PARENTHESIS_in_function_call1679); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_LEFT_PARENTHESIS.Add(LEFT_PARENTHESIS27);

			DebugLocation(398, 21);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:398:21: ( expression_list )?
			int alt16=2;
			try { DebugEnterSubRule(16);
			try { DebugEnterDecision(16, decisionCanBacktrack[16]);
			int LA16_0 = input.LA(1);

			if ((LA16_0==BREAK||LA16_0==FOR||LA16_0==IF||(LA16_0>=LET && LA16_0<=NIL)||LA16_0==WHILE||LA16_0==LEFT_PARENTHESIS||LA16_0==MINUS||(LA16_0>=ID && LA16_0<=INT)||LA16_0==STRING))
			{
				alt16=1;
			}
			} finally { DebugExitDecision(16); }
			switch (alt16)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:398:21: expression_list
				{
				DebugLocation(398, 21);
				PushFollow(Follow._expression_list_in_function_call1681);
				expression_list28=expression_list();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression_list.Add(expression_list28.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(16); }

			DebugLocation(398, 38);
			RIGHT_PARENTHESIS29=(IToken)Match(input,RIGHT_PARENTHESIS,Follow._RIGHT_PARENTHESIS_in_function_call1684); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_RIGHT_PARENTHESIS.Add(RIGHT_PARENTHESIS29);



			{
			// AST REWRITE
			// elements: expression_list
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 398:56: -> ^( FUNCTION_CALL ( expression_list )? )
			{
				DebugLocation(398, 59);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:398:59: ^( FUNCTION_CALL ( expression_list )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(398, 61);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNCTION_CALL, "FUNCTION_CALL"), root_1);

				DebugLocation(398, 75);
				adaptor.AddChild(root_1, leftId);
				DebugLocation(398, 84);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:398:84: ( expression_list )?
				if ( stream_expression_list.HasNext )
				{
					DebugLocation(398, 84);
					adaptor.AddChild(root_1, stream_expression_list.NextTree());

				}
				stream_expression_list.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("function_call", 12);
			LeaveRule("function_call", 12);
			Leave_function_call();
		}
		DebugLocation(399, 1);
		} finally { DebugExitRule(GrammarFileName, "function_call"); }
		return retval;

	}
	// $ANTLR end "function_call"

	public class record_assignment_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_record_assignment();
	partial void Leave_record_assignment();

	// $ANTLR start "record_assignment"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:401:1: record_assignment[CommonTree leftId] : LEFT_KEY ( field_list )? RIGHT_KEY -> ^( RECORD_ASSIGNMENT ( field_list )? ) ;
	[GrammarRule("record_assignment")]
	private TigerParser.record_assignment_return record_assignment(CommonTree leftId)
	{
		Enter_record_assignment();
		EnterRule("record_assignment", 13);
		TraceIn("record_assignment", 13);
		TigerParser.record_assignment_return retval = new TigerParser.record_assignment_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken LEFT_KEY30=null;
		IToken RIGHT_KEY32=null;
		TigerParser.field_list_return field_list31 = default(TigerParser.field_list_return);

		object LEFT_KEY30_tree=null;
		object RIGHT_KEY32_tree=null;
		RewriteRuleITokenStream stream_RIGHT_KEY=new RewriteRuleITokenStream(adaptor,"token RIGHT_KEY");
		RewriteRuleITokenStream stream_LEFT_KEY=new RewriteRuleITokenStream(adaptor,"token LEFT_KEY");
		RewriteRuleSubtreeStream stream_field_list=new RewriteRuleSubtreeStream(adaptor,"rule field_list");
		try { DebugEnterRule(GrammarFileName, "record_assignment");
		DebugLocation(401, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:402:2: ( LEFT_KEY ( field_list )? RIGHT_KEY -> ^( RECORD_ASSIGNMENT ( field_list )? ) )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:402:4: LEFT_KEY ( field_list )? RIGHT_KEY
			{
			DebugLocation(402, 4);
			LEFT_KEY30=(IToken)Match(input,LEFT_KEY,Follow._LEFT_KEY_in_record_assignment1707); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_LEFT_KEY.Add(LEFT_KEY30);

			DebugLocation(402, 13);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:402:13: ( field_list )?
			int alt17=2;
			try { DebugEnterSubRule(17);
			try { DebugEnterDecision(17, decisionCanBacktrack[17]);
			int LA17_0 = input.LA(1);

			if ((LA17_0==ID))
			{
				alt17=1;
			}
			} finally { DebugExitDecision(17); }
			switch (alt17)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:402:13: field_list
				{
				DebugLocation(402, 13);
				PushFollow(Follow._field_list_in_record_assignment1709);
				field_list31=field_list();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_field_list.Add(field_list31.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(17); }

			DebugLocation(402, 25);
			RIGHT_KEY32=(IToken)Match(input,RIGHT_KEY,Follow._RIGHT_KEY_in_record_assignment1712); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_RIGHT_KEY.Add(RIGHT_KEY32);



			{
			// AST REWRITE
			// elements: field_list
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 402:35: -> ^( RECORD_ASSIGNMENT ( field_list )? )
			{
				DebugLocation(402, 38);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:402:38: ^( RECORD_ASSIGNMENT ( field_list )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(402, 40);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(RECORD_ASSIGNMENT, "RECORD_ASSIGNMENT"), root_1);

				DebugLocation(402, 58);
				adaptor.AddChild(root_1, leftId);
				DebugLocation(402, 67);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:402:67: ( field_list )?
				if ( stream_field_list.HasNext )
				{
					DebugLocation(402, 67);
					adaptor.AddChild(root_1, stream_field_list.NextTree());

				}
				stream_field_list.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("record_assignment", 13);
			LeaveRule("record_assignment", 13);
			Leave_record_assignment();
		}
		DebugLocation(403, 1);
		} finally { DebugExitRule(GrammarFileName, "record_assignment"); }
		return retval;

	}
	// $ANTLR end "record_assignment"

	public class record_access_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_record_access();
	partial void Leave_record_access();

	// $ANTLR start "record_access"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:405:1: record_access[CommonTree leftValue] : DOT rightId= ID -> ^( RECORD_ACCESS $rightId) ;
	[GrammarRule("record_access")]
	private TigerParser.record_access_return record_access(CommonTree leftValue)
	{
		Enter_record_access();
		EnterRule("record_access", 14);
		TraceIn("record_access", 14);
		TigerParser.record_access_return retval = new TigerParser.record_access_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken rightId=null;
		IToken DOT33=null;

		object rightId_tree=null;
		object DOT33_tree=null;
		RewriteRuleITokenStream stream_DOT=new RewriteRuleITokenStream(adaptor,"token DOT");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");

		try { DebugEnterRule(GrammarFileName, "record_access");
		DebugLocation(405, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:406:2: ( DOT rightId= ID -> ^( RECORD_ACCESS $rightId) )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:406:4: DOT rightId= ID
			{
			DebugLocation(406, 4);
			DOT33=(IToken)Match(input,DOT,Follow._DOT_in_record_access1735); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_DOT.Add(DOT33);

			DebugLocation(406, 16);
			rightId=(IToken)Match(input,ID,Follow._ID_in_record_access1741); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(rightId);



			{
			// AST REWRITE
			// elements: rightId
			// token labels: rightId
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleITokenStream stream_rightId=new RewriteRuleITokenStream(adaptor,"token rightId",rightId);
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 406:21: -> ^( RECORD_ACCESS $rightId)
			{
				DebugLocation(406, 24);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:406:24: ^( RECORD_ACCESS $rightId)
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(406, 26);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(RECORD_ACCESS, "RECORD_ACCESS"), root_1);

				DebugLocation(406, 40);
				adaptor.AddChild(root_1, leftValue);
				DebugLocation(406, 52);
				adaptor.AddChild(root_1, stream_rightId.NextNode());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("record_access", 14);
			LeaveRule("record_access", 14);
			Leave_record_access();
		}
		DebugLocation(407, 1);
		} finally { DebugExitRule(GrammarFileName, "record_access"); }
		return retval;

	}
	// $ANTLR end "record_access"

	public class indexer_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		public ITree betweenBracketsExpression;
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_indexer();
	partial void Leave_indexer();

	// $ANTLR start "indexer"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:409:1: indexer[CommonTree leftValue] returns [ITree betweenBracketsExpression] : LEFT_BRACKET expr= expression RIGHT_BRACKET -> ^( INDEXER $expr) ;
	[GrammarRule("indexer")]
	private TigerParser.indexer_return indexer(CommonTree leftValue)
	{
		Enter_indexer();
		EnterRule("indexer", 15);
		TraceIn("indexer", 15);
		TigerParser.indexer_return retval = new TigerParser.indexer_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken LEFT_BRACKET34=null;
		IToken RIGHT_BRACKET35=null;
		TigerParser.expression_return expr = default(TigerParser.expression_return);

		object LEFT_BRACKET34_tree=null;
		object RIGHT_BRACKET35_tree=null;
		RewriteRuleITokenStream stream_LEFT_BRACKET=new RewriteRuleITokenStream(adaptor,"token LEFT_BRACKET");
		RewriteRuleITokenStream stream_RIGHT_BRACKET=new RewriteRuleITokenStream(adaptor,"token RIGHT_BRACKET");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "indexer");
		DebugLocation(409, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:410:2: ( LEFT_BRACKET expr= expression RIGHT_BRACKET -> ^( INDEXER $expr) )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:410:4: LEFT_BRACKET expr= expression RIGHT_BRACKET
			{
			DebugLocation(410, 4);
			LEFT_BRACKET34=(IToken)Match(input,LEFT_BRACKET,Follow._LEFT_BRACKET_in_indexer1768); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_LEFT_BRACKET.Add(LEFT_BRACKET34);

			DebugLocation(410, 22);
			PushFollow(Follow._expression_in_indexer1774);
			expr=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expr.Tree);
			DebugLocation(410, 35);
			RIGHT_BRACKET35=(IToken)Match(input,RIGHT_BRACKET,Follow._RIGHT_BRACKET_in_indexer1776); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_RIGHT_BRACKET.Add(RIGHT_BRACKET35);

			DebugLocation(410, 49);
			if ( state.backtracking == 0 )
			{
				retval.betweenBracketsExpression = (ITree)expr.Tree;
			}


			{
			// AST REWRITE
			// elements: expr
			// token labels: 
			// rule labels: retval, expr
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
			RewriteRuleSubtreeStream stream_expr=new RewriteRuleSubtreeStream(adaptor,"rule expr",expr!=null?expr.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 410:98: -> ^( INDEXER $expr)
			{
				DebugLocation(410, 101);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:410:101: ^( INDEXER $expr)
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(410, 103);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(INDEXER, "INDEXER"), root_1);

				DebugLocation(410, 111);
				adaptor.AddChild(root_1, leftValue);
				DebugLocation(410, 123);
				adaptor.AddChild(root_1, stream_expr.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("indexer", 15);
			LeaveRule("indexer", 15);
			Leave_indexer();
		}
		DebugLocation(411, 1);
		} finally { DebugExitRule(GrammarFileName, "indexer"); }
		return retval;

	}
	// $ANTLR end "indexer"

	public class left_value_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_left_value();
	partial void Leave_left_value();

	// $ANTLR start "left_value"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:413:1: left_value[CommonTree leftValue] : ( (recordAccess= record_access[leftValue] newLeftValue= left_value[(CommonTree)recordAccess.Tree] | ind= indexer[leftValue] newLeftValue= left_value[(CommonTree)ind.Tree] ) -> $newLeftValue | ->);
	[GrammarRule("left_value")]
	private TigerParser.left_value_return left_value(CommonTree leftValue)
	{
		Enter_left_value();
		EnterRule("left_value", 16);
		TraceIn("left_value", 16);
		TigerParser.left_value_return retval = new TigerParser.left_value_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		TigerParser.record_access_return recordAccess = default(TigerParser.record_access_return);
		TigerParser.left_value_return newLeftValue = default(TigerParser.left_value_return);
		TigerParser.indexer_return ind = default(TigerParser.indexer_return);

		RewriteRuleSubtreeStream stream_left_value=new RewriteRuleSubtreeStream(adaptor,"rule left_value");
		RewriteRuleSubtreeStream stream_indexer=new RewriteRuleSubtreeStream(adaptor,"rule indexer");
		RewriteRuleSubtreeStream stream_record_access=new RewriteRuleSubtreeStream(adaptor,"rule record_access");
		try { DebugEnterRule(GrammarFileName, "left_value");
		DebugLocation(413, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:414:2: ( (recordAccess= record_access[leftValue] newLeftValue= left_value[(CommonTree)recordAccess.Tree] | ind= indexer[leftValue] newLeftValue= left_value[(CommonTree)ind.Tree] ) -> $newLeftValue | ->)
			int alt19=2;
			try { DebugEnterDecision(19, decisionCanBacktrack[19]);
			int LA19_0 = input.LA(1);

			if ((LA19_0==LEFT_BRACKET||LA19_0==DOT))
			{
				alt19=1;
			}
			else if ((LA19_0==EOF||(LA19_0>=DO && LA19_0<=END)||LA19_0==FUNCTION||LA19_0==IN||(LA19_0>=THEN && LA19_0<=VAR)||LA19_0==COMMA||LA19_0==SEMICOLON||LA19_0==RIGHT_PARENTHESIS||LA19_0==RIGHT_BRACKET||LA19_0==RIGHT_KEY||(LA19_0>=PLUS && LA19_0<=ASSIGNMENT)))
			{
				alt19=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 19, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(19); }
			switch (alt19)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:414:4: (recordAccess= record_access[leftValue] newLeftValue= left_value[(CommonTree)recordAccess.Tree] | ind= indexer[leftValue] newLeftValue= left_value[(CommonTree)ind.Tree] )
				{
				DebugLocation(414, 4);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:414:4: (recordAccess= record_access[leftValue] newLeftValue= left_value[(CommonTree)recordAccess.Tree] | ind= indexer[leftValue] newLeftValue= left_value[(CommonTree)ind.Tree] )
				int alt18=2;
				try { DebugEnterSubRule(18);
				try { DebugEnterDecision(18, decisionCanBacktrack[18]);
				int LA18_0 = input.LA(1);

				if ((LA18_0==DOT))
				{
					alt18=1;
				}
				else if ((LA18_0==LEFT_BRACKET))
				{
					alt18=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 18, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				} finally { DebugExitDecision(18); }
				switch (alt18)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:414:6: recordAccess= record_access[leftValue] newLeftValue= left_value[(CommonTree)recordAccess.Tree]
					{
					DebugLocation(414, 19);
					PushFollow(Follow._record_access_in_left_value1807);
					recordAccess=record_access(leftValue);
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_record_access.Add(recordAccess.Tree);
					DebugLocation(414, 59);
					PushFollow(Follow._left_value_in_left_value1814);
					newLeftValue=left_value((CommonTree)recordAccess.Tree);
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_left_value.Add(newLeftValue.Tree);

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:415:5: ind= indexer[leftValue] newLeftValue= left_value[(CommonTree)ind.Tree]
					{
					DebugLocation(415, 9);
					PushFollow(Follow._indexer_in_left_value1825);
					ind=indexer(leftValue);
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_indexer.Add(ind.Tree);
					DebugLocation(415, 43);
					PushFollow(Follow._left_value_in_left_value1832);
					newLeftValue=left_value((CommonTree)ind.Tree);
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_left_value.Add(newLeftValue.Tree);

					}
					break;

				}
				} finally { DebugExitSubRule(18); }



				{
				// AST REWRITE
				// elements: newLeftValue
				// token labels: 
				// rule labels: retval, newLeftValue
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
				RewriteRuleSubtreeStream stream_newLeftValue=new RewriteRuleSubtreeStream(adaptor,"rule newLeftValue",newLeftValue!=null?newLeftValue.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 416:5: -> $newLeftValue
				{
					DebugLocation(416, 8);
					adaptor.AddChild(root_0, stream_newLeftValue.NextTree());

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:417:4: 
				{

				{
				// AST REWRITE
				// elements: 
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 417:4: ->
				{
					DebugLocation(417, 7);
					adaptor.AddChild(root_0, leftValue);

				}

				retval.Tree = root_0;
				}
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("left_value", 16);
			LeaveRule("left_value", 16);
			Leave_left_value();
		}
		DebugLocation(418, 1);
		} finally { DebugExitRule(GrammarFileName, "left_value"); }
		return retval;

	}
	// $ANTLR end "left_value"

	public class not_value_returner_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_not_value_returner();
	partial void Leave_not_value_returner();

	// $ANTLR start "not_value_returner"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:420:1: not_value_returner : ( BREAK | control_expression );
	[GrammarRule("not_value_returner")]
	private TigerParser.not_value_returner_return not_value_returner()
	{
		Enter_not_value_returner();
		EnterRule("not_value_returner", 17);
		TraceIn("not_value_returner", 17);
		TigerParser.not_value_returner_return retval = new TigerParser.not_value_returner_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken BREAK36=null;
		TigerParser.control_expression_return control_expression37 = default(TigerParser.control_expression_return);

		object BREAK36_tree=null;

		try { DebugEnterRule(GrammarFileName, "not_value_returner");
		DebugLocation(420, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:421:2: ( BREAK | control_expression )
			int alt20=2;
			try { DebugEnterDecision(20, decisionCanBacktrack[20]);
			int LA20_0 = input.LA(1);

			if ((LA20_0==BREAK))
			{
				alt20=1;
			}
			else if ((LA20_0==FOR||LA20_0==IF||LA20_0==WHILE))
			{
				alt20=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 20, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(20); }
			switch (alt20)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:421:4: BREAK
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(421, 4);
				BREAK36=(IToken)Match(input,BREAK,Follow._BREAK_in_not_value_returner1860); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				BREAK36_tree = (object)adaptor.Create(BREAK36);
				adaptor.AddChild(root_0, BREAK36_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:422:4: control_expression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(422, 4);
				PushFollow(Follow._control_expression_in_not_value_returner1865);
				control_expression37=control_expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, control_expression37.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("not_value_returner", 17);
			LeaveRule("not_value_returner", 17);
			Leave_not_value_returner();
		}
		DebugLocation(423, 1);
		} finally { DebugExitRule(GrammarFileName, "not_value_returner"); }
		return retval;

	}
	// $ANTLR end "not_value_returner"

	public class tuple_expression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_tuple_expression();
	partial void Leave_tuple_expression();

	// $ANTLR start "tuple_expression"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:425:1: tuple_expression : LEFT_PARENTHESIS ( expression_sequence )? RIGHT_PARENTHESIS -> ^( TUPLE ( expression_sequence )? ) ;
	[GrammarRule("tuple_expression")]
	private TigerParser.tuple_expression_return tuple_expression()
	{
		Enter_tuple_expression();
		EnterRule("tuple_expression", 18);
		TraceIn("tuple_expression", 18);
		TigerParser.tuple_expression_return retval = new TigerParser.tuple_expression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken LEFT_PARENTHESIS38=null;
		IToken RIGHT_PARENTHESIS40=null;
		TigerParser.expression_sequence_return expression_sequence39 = default(TigerParser.expression_sequence_return);

		object LEFT_PARENTHESIS38_tree=null;
		object RIGHT_PARENTHESIS40_tree=null;
		RewriteRuleITokenStream stream_RIGHT_PARENTHESIS=new RewriteRuleITokenStream(adaptor,"token RIGHT_PARENTHESIS");
		RewriteRuleITokenStream stream_LEFT_PARENTHESIS=new RewriteRuleITokenStream(adaptor,"token LEFT_PARENTHESIS");
		RewriteRuleSubtreeStream stream_expression_sequence=new RewriteRuleSubtreeStream(adaptor,"rule expression_sequence");
		try { DebugEnterRule(GrammarFileName, "tuple_expression");
		DebugLocation(425, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:426:2: ( LEFT_PARENTHESIS ( expression_sequence )? RIGHT_PARENTHESIS -> ^( TUPLE ( expression_sequence )? ) )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:426:4: LEFT_PARENTHESIS ( expression_sequence )? RIGHT_PARENTHESIS
			{
			DebugLocation(426, 4);
			LEFT_PARENTHESIS38=(IToken)Match(input,LEFT_PARENTHESIS,Follow._LEFT_PARENTHESIS_in_tuple_expression1876); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_LEFT_PARENTHESIS.Add(LEFT_PARENTHESIS38);

			DebugLocation(426, 21);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:426:21: ( expression_sequence )?
			int alt21=2;
			try { DebugEnterSubRule(21);
			try { DebugEnterDecision(21, decisionCanBacktrack[21]);
			int LA21_0 = input.LA(1);

			if ((LA21_0==BREAK||LA21_0==FOR||LA21_0==IF||(LA21_0>=LET && LA21_0<=NIL)||LA21_0==WHILE||LA21_0==LEFT_PARENTHESIS||LA21_0==MINUS||(LA21_0>=ID && LA21_0<=INT)||LA21_0==STRING))
			{
				alt21=1;
			}
			} finally { DebugExitDecision(21); }
			switch (alt21)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:426:21: expression_sequence
				{
				DebugLocation(426, 21);
				PushFollow(Follow._expression_sequence_in_tuple_expression1878);
				expression_sequence39=expression_sequence();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression_sequence.Add(expression_sequence39.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(21); }

			DebugLocation(426, 42);
			RIGHT_PARENTHESIS40=(IToken)Match(input,RIGHT_PARENTHESIS,Follow._RIGHT_PARENTHESIS_in_tuple_expression1881); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_RIGHT_PARENTHESIS.Add(RIGHT_PARENTHESIS40);



			{
			// AST REWRITE
			// elements: expression_sequence
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 426:60: -> ^( TUPLE ( expression_sequence )? )
			{
				DebugLocation(426, 63);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:426:63: ^( TUPLE ( expression_sequence )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(426, 65);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TUPLE, "TUPLE"), root_1);

				DebugLocation(426, 71);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:426:71: ( expression_sequence )?
				if ( stream_expression_sequence.HasNext )
				{
					DebugLocation(426, 71);
					adaptor.AddChild(root_1, stream_expression_sequence.NextTree());

				}
				stream_expression_sequence.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("tuple_expression", 18);
			LeaveRule("tuple_expression", 18);
			Leave_tuple_expression();
		}
		DebugLocation(427, 1);
		} finally { DebugExitRule(GrammarFileName, "tuple_expression"); }
		return retval;

	}
	// $ANTLR end "tuple_expression"

	public class control_expression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_control_expression();
	partial void Leave_control_expression();

	// $ANTLR start "control_expression"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:429:1: control_expression : ( if_expression | while_expression | for_expression );
	[GrammarRule("control_expression")]
	private TigerParser.control_expression_return control_expression()
	{
		Enter_control_expression();
		EnterRule("control_expression", 19);
		TraceIn("control_expression", 19);
		TigerParser.control_expression_return retval = new TigerParser.control_expression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		TigerParser.if_expression_return if_expression41 = default(TigerParser.if_expression_return);
		TigerParser.while_expression_return while_expression42 = default(TigerParser.while_expression_return);
		TigerParser.for_expression_return for_expression43 = default(TigerParser.for_expression_return);


		try { DebugEnterRule(GrammarFileName, "control_expression");
		DebugLocation(429, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:430:2: ( if_expression | while_expression | for_expression )
			int alt22=3;
			try { DebugEnterDecision(22, decisionCanBacktrack[22]);
			switch (input.LA(1))
			{
			case IF:
				{
				alt22=1;
				}
				break;
			case WHILE:
				{
				alt22=2;
				}
				break;
			case FOR:
				{
				alt22=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 22, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(22); }
			switch (alt22)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:430:4: if_expression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(430, 4);
				PushFollow(Follow._if_expression_in_control_expression1901);
				if_expression41=if_expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, if_expression41.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:431:4: while_expression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(431, 4);
				PushFollow(Follow._while_expression_in_control_expression1906);
				while_expression42=while_expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, while_expression42.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:432:4: for_expression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(432, 4);
				PushFollow(Follow._for_expression_in_control_expression1911);
				for_expression43=for_expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, for_expression43.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("control_expression", 19);
			LeaveRule("control_expression", 19);
			Leave_control_expression();
		}
		DebugLocation(433, 1);
		} finally { DebugExitRule(GrammarFileName, "control_expression"); }
		return retval;

	}
	// $ANTLR end "control_expression"

	public class if_expression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_if_expression();
	partial void Leave_if_expression();

	// $ANTLR start "if_expression"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:435:1: if_expression : IF conditionalExpression= expression THEN thenExpression= expression ( ( ELSE )=> ELSE elseExpression= expression -> ^( IF_THEN_ELSE $conditionalExpression $thenExpression $elseExpression) | -> ^( IF_THEN $conditionalExpression $thenExpression) ) ;
	[GrammarRule("if_expression")]
	private TigerParser.if_expression_return if_expression()
	{
		Enter_if_expression();
		EnterRule("if_expression", 20);
		TraceIn("if_expression", 20);
		TigerParser.if_expression_return retval = new TigerParser.if_expression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken IF44=null;
		IToken THEN45=null;
		IToken ELSE46=null;
		TigerParser.expression_return conditionalExpression = default(TigerParser.expression_return);
		TigerParser.expression_return thenExpression = default(TigerParser.expression_return);
		TigerParser.expression_return elseExpression = default(TigerParser.expression_return);

		object IF44_tree=null;
		object THEN45_tree=null;
		object ELSE46_tree=null;
		RewriteRuleITokenStream stream_THEN=new RewriteRuleITokenStream(adaptor,"token THEN");
		RewriteRuleITokenStream stream_IF=new RewriteRuleITokenStream(adaptor,"token IF");
		RewriteRuleITokenStream stream_ELSE=new RewriteRuleITokenStream(adaptor,"token ELSE");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "if_expression");
		DebugLocation(435, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:436:2: ( IF conditionalExpression= expression THEN thenExpression= expression ( ( ELSE )=> ELSE elseExpression= expression -> ^( IF_THEN_ELSE $conditionalExpression $thenExpression $elseExpression) | -> ^( IF_THEN $conditionalExpression $thenExpression) ) )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:436:4: IF conditionalExpression= expression THEN thenExpression= expression ( ( ELSE )=> ELSE elseExpression= expression -> ^( IF_THEN_ELSE $conditionalExpression $thenExpression $elseExpression) | -> ^( IF_THEN $conditionalExpression $thenExpression) )
			{
			DebugLocation(436, 4);
			IF44=(IToken)Match(input,IF,Follow._IF_in_if_expression1922); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IF.Add(IF44);

			DebugLocation(436, 29);
			PushFollow(Follow._expression_in_if_expression1928);
			conditionalExpression=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(conditionalExpression.Tree);
			DebugLocation(436, 42);
			THEN45=(IToken)Match(input,THEN,Follow._THEN_in_if_expression1930); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_THEN.Add(THEN45);

			DebugLocation(436, 62);
			PushFollow(Follow._expression_in_if_expression1936);
			thenExpression=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(thenExpression.Tree);
			DebugLocation(436, 75);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:436:75: ( ( ELSE )=> ELSE elseExpression= expression -> ^( IF_THEN_ELSE $conditionalExpression $thenExpression $elseExpression) | -> ^( IF_THEN $conditionalExpression $thenExpression) )
			int alt23=2;
			try { DebugEnterSubRule(23);
			try { DebugEnterDecision(23, decisionCanBacktrack[23]);
			int LA23_0 = input.LA(1);

			if ((LA23_0==ELSE))
			{
				int LA23_1 = input.LA(2);

				if ((EvaluatePredicate(synpred2_Tiger_fragment)))
				{
					alt23=1;
				}
				else if ((true))
				{
					alt23=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 23, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else if ((LA23_0==EOF||LA23_0==DO||LA23_0==END||LA23_0==FUNCTION||LA23_0==IN||(LA23_0>=THEN && LA23_0<=VAR)||LA23_0==COMMA||LA23_0==SEMICOLON||LA23_0==RIGHT_PARENTHESIS||LA23_0==RIGHT_BRACKET||LA23_0==RIGHT_KEY||(LA23_0>=PLUS && LA23_0<=OR)))
			{
				alt23=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 23, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(23); }
			switch (alt23)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:436:76: ( ELSE )=> ELSE elseExpression= expression
				{
				DebugLocation(436, 86);
				ELSE46=(IToken)Match(input,ELSE,Follow._ELSE_in_if_expression1945); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ELSE.Add(ELSE46);

				DebugLocation(436, 106);
				PushFollow(Follow._expression_in_if_expression1951);
				elseExpression=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(elseExpression.Tree);


				{
				// AST REWRITE
				// elements: thenExpression, conditionalExpression, elseExpression
				// token labels: 
				// rule labels: elseExpression, retval, thenExpression, conditionalExpression
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_elseExpression=new RewriteRuleSubtreeStream(adaptor,"rule elseExpression",elseExpression!=null?elseExpression.Tree:null);
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
				RewriteRuleSubtreeStream stream_thenExpression=new RewriteRuleSubtreeStream(adaptor,"rule thenExpression",thenExpression!=null?thenExpression.Tree:null);
				RewriteRuleSubtreeStream stream_conditionalExpression=new RewriteRuleSubtreeStream(adaptor,"rule conditionalExpression",conditionalExpression!=null?conditionalExpression.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 436:119: -> ^( IF_THEN_ELSE $conditionalExpression $thenExpression $elseExpression)
				{
					DebugLocation(436, 122);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:436:122: ^( IF_THEN_ELSE $conditionalExpression $thenExpression $elseExpression)
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(436, 124);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IF_THEN_ELSE, "IF_THEN_ELSE"), root_1);

					DebugLocation(436, 137);
					adaptor.AddChild(root_1, stream_conditionalExpression.NextTree());
					DebugLocation(436, 160);
					adaptor.AddChild(root_1, stream_thenExpression.NextTree());
					DebugLocation(436, 176);
					adaptor.AddChild(root_1, stream_elseExpression.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:437:20: 
				{

				{
				// AST REWRITE
				// elements: conditionalExpression, thenExpression
				// token labels: 
				// rule labels: retval, thenExpression, conditionalExpression
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
				RewriteRuleSubtreeStream stream_thenExpression=new RewriteRuleSubtreeStream(adaptor,"rule thenExpression",thenExpression!=null?thenExpression.Tree:null);
				RewriteRuleSubtreeStream stream_conditionalExpression=new RewriteRuleSubtreeStream(adaptor,"rule conditionalExpression",conditionalExpression!=null?conditionalExpression.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 437:20: -> ^( IF_THEN $conditionalExpression $thenExpression)
				{
					DebugLocation(437, 23);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:437:23: ^( IF_THEN $conditionalExpression $thenExpression)
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(437, 25);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IF_THEN, "IF_THEN"), root_1);

					DebugLocation(437, 33);
					adaptor.AddChild(root_1, stream_conditionalExpression.NextTree());
					DebugLocation(437, 56);
					adaptor.AddChild(root_1, stream_thenExpression.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;

			}
			} finally { DebugExitSubRule(23); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("if_expression", 20);
			LeaveRule("if_expression", 20);
			Leave_if_expression();
		}
		DebugLocation(438, 1);
		} finally { DebugExitRule(GrammarFileName, "if_expression"); }
		return retval;

	}
	// $ANTLR end "if_expression"

	public class while_expression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_while_expression();
	partial void Leave_while_expression();

	// $ANTLR start "while_expression"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:440:1: while_expression : WHILE conditionalExpression= expression DO doExpression= expression -> ^( WHILE $conditionalExpression $doExpression) ;
	[GrammarRule("while_expression")]
	private TigerParser.while_expression_return while_expression()
	{
		Enter_while_expression();
		EnterRule("while_expression", 21);
		TraceIn("while_expression", 21);
		TigerParser.while_expression_return retval = new TigerParser.while_expression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken WHILE47=null;
		IToken DO48=null;
		TigerParser.expression_return conditionalExpression = default(TigerParser.expression_return);
		TigerParser.expression_return doExpression = default(TigerParser.expression_return);

		object WHILE47_tree=null;
		object DO48_tree=null;
		RewriteRuleITokenStream stream_DO=new RewriteRuleITokenStream(adaptor,"token DO");
		RewriteRuleITokenStream stream_WHILE=new RewriteRuleITokenStream(adaptor,"token WHILE");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "while_expression");
		DebugLocation(440, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:441:2: ( WHILE conditionalExpression= expression DO doExpression= expression -> ^( WHILE $conditionalExpression $doExpression) )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:441:4: WHILE conditionalExpression= expression DO doExpression= expression
			{
			DebugLocation(441, 4);
			WHILE47=(IToken)Match(input,WHILE,Follow._WHILE_in_while_expression2010); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_WHILE.Add(WHILE47);

			DebugLocation(441, 32);
			PushFollow(Follow._expression_in_while_expression2016);
			conditionalExpression=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(conditionalExpression.Tree);
			DebugLocation(441, 45);
			DO48=(IToken)Match(input,DO,Follow._DO_in_while_expression2018); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_DO.Add(DO48);

			DebugLocation(441, 61);
			PushFollow(Follow._expression_in_while_expression2024);
			doExpression=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(doExpression.Tree);


			{
			// AST REWRITE
			// elements: doExpression, conditionalExpression, WHILE
			// token labels: 
			// rule labels: retval, doExpression, conditionalExpression
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
			RewriteRuleSubtreeStream stream_doExpression=new RewriteRuleSubtreeStream(adaptor,"rule doExpression",doExpression!=null?doExpression.Tree:null);
			RewriteRuleSubtreeStream stream_conditionalExpression=new RewriteRuleSubtreeStream(adaptor,"rule conditionalExpression",conditionalExpression!=null?conditionalExpression.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 441:74: -> ^( WHILE $conditionalExpression $doExpression)
			{
				DebugLocation(441, 77);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:441:77: ^( WHILE $conditionalExpression $doExpression)
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(441, 79);
				root_1 = (object)adaptor.BecomeRoot(stream_WHILE.NextNode(), root_1);

				DebugLocation(441, 85);
				adaptor.AddChild(root_1, stream_conditionalExpression.NextTree());
				DebugLocation(441, 108);
				adaptor.AddChild(root_1, stream_doExpression.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("while_expression", 21);
			LeaveRule("while_expression", 21);
			Leave_while_expression();
		}
		DebugLocation(442, 1);
		} finally { DebugExitRule(GrammarFileName, "while_expression"); }
		return retval;

	}
	// $ANTLR end "while_expression"

	public class for_expression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_for_expression();
	partial void Leave_for_expression();

	// $ANTLR start "for_expression"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:444:1: for_expression : FOR ID ASSIGNMENT initialExpression= expression TO finalExpression= expression DO doExpression= expression -> ^( FOR ID $initialExpression $finalExpression $doExpression) ;
	[GrammarRule("for_expression")]
	private TigerParser.for_expression_return for_expression()
	{
		Enter_for_expression();
		EnterRule("for_expression", 22);
		TraceIn("for_expression", 22);
		TigerParser.for_expression_return retval = new TigerParser.for_expression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken FOR49=null;
		IToken ID50=null;
		IToken ASSIGNMENT51=null;
		IToken TO52=null;
		IToken DO53=null;
		TigerParser.expression_return initialExpression = default(TigerParser.expression_return);
		TigerParser.expression_return finalExpression = default(TigerParser.expression_return);
		TigerParser.expression_return doExpression = default(TigerParser.expression_return);

		object FOR49_tree=null;
		object ID50_tree=null;
		object ASSIGNMENT51_tree=null;
		object TO52_tree=null;
		object DO53_tree=null;
		RewriteRuleITokenStream stream_FOR=new RewriteRuleITokenStream(adaptor,"token FOR");
		RewriteRuleITokenStream stream_DO=new RewriteRuleITokenStream(adaptor,"token DO");
		RewriteRuleITokenStream stream_ASSIGNMENT=new RewriteRuleITokenStream(adaptor,"token ASSIGNMENT");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_TO=new RewriteRuleITokenStream(adaptor,"token TO");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "for_expression");
		DebugLocation(444, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:445:2: ( FOR ID ASSIGNMENT initialExpression= expression TO finalExpression= expression DO doExpression= expression -> ^( FOR ID $initialExpression $finalExpression $doExpression) )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:445:4: FOR ID ASSIGNMENT initialExpression= expression TO finalExpression= expression DO doExpression= expression
			{
			DebugLocation(445, 4);
			FOR49=(IToken)Match(input,FOR,Follow._FOR_in_for_expression2047); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_FOR.Add(FOR49);

			DebugLocation(445, 8);
			ID50=(IToken)Match(input,ID,Follow._ID_in_for_expression2049); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID50);

			DebugLocation(445, 11);
			ASSIGNMENT51=(IToken)Match(input,ASSIGNMENT,Follow._ASSIGNMENT_in_for_expression2051); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ASSIGNMENT.Add(ASSIGNMENT51);

			DebugLocation(445, 40);
			PushFollow(Follow._expression_in_for_expression2057);
			initialExpression=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(initialExpression.Tree);
			DebugLocation(445, 53);
			TO52=(IToken)Match(input,TO,Follow._TO_in_for_expression2059); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TO.Add(TO52);

			DebugLocation(445, 72);
			PushFollow(Follow._expression_in_for_expression2065);
			finalExpression=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(finalExpression.Tree);
			DebugLocation(445, 85);
			DO53=(IToken)Match(input,DO,Follow._DO_in_for_expression2067); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_DO.Add(DO53);

			DebugLocation(445, 101);
			PushFollow(Follow._expression_in_for_expression2073);
			doExpression=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(doExpression.Tree);


			{
			// AST REWRITE
			// elements: initialExpression, FOR, finalExpression, ID, doExpression
			// token labels: 
			// rule labels: retval, doExpression, initialExpression, finalExpression
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
			RewriteRuleSubtreeStream stream_doExpression=new RewriteRuleSubtreeStream(adaptor,"rule doExpression",doExpression!=null?doExpression.Tree:null);
			RewriteRuleSubtreeStream stream_initialExpression=new RewriteRuleSubtreeStream(adaptor,"rule initialExpression",initialExpression!=null?initialExpression.Tree:null);
			RewriteRuleSubtreeStream stream_finalExpression=new RewriteRuleSubtreeStream(adaptor,"rule finalExpression",finalExpression!=null?finalExpression.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 445:114: -> ^( FOR ID $initialExpression $finalExpression $doExpression)
			{
				DebugLocation(445, 117);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:445:117: ^( FOR ID $initialExpression $finalExpression $doExpression)
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(445, 119);
				root_1 = (object)adaptor.BecomeRoot(stream_FOR.NextNode(), root_1);

				DebugLocation(445, 123);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(445, 126);
				adaptor.AddChild(root_1, stream_initialExpression.NextTree());
				DebugLocation(445, 145);
				adaptor.AddChild(root_1, stream_finalExpression.NextTree());
				DebugLocation(445, 162);
				adaptor.AddChild(root_1, stream_doExpression.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("for_expression", 22);
			LeaveRule("for_expression", 22);
			Leave_for_expression();
		}
		DebugLocation(446, 1);
		} finally { DebugExitRule(GrammarFileName, "for_expression"); }
		return retval;

	}
	// $ANTLR end "for_expression"

	public class let_expression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_let_expression();
	partial void Leave_let_expression();

	// $ANTLR start "let_expression"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:448:1: let_expression : LET declaration_list IN ( expression_sequence )? END -> ^( LET declaration_list ( expression_sequence )? ) ;
	[GrammarRule("let_expression")]
	private TigerParser.let_expression_return let_expression()
	{
		Enter_let_expression();
		EnterRule("let_expression", 23);
		TraceIn("let_expression", 23);
		TigerParser.let_expression_return retval = new TigerParser.let_expression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken LET54=null;
		IToken IN56=null;
		IToken END58=null;
		TigerParser.declaration_list_return declaration_list55 = default(TigerParser.declaration_list_return);
		TigerParser.expression_sequence_return expression_sequence57 = default(TigerParser.expression_sequence_return);

		object LET54_tree=null;
		object IN56_tree=null;
		object END58_tree=null;
		RewriteRuleITokenStream stream_IN=new RewriteRuleITokenStream(adaptor,"token IN");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_LET=new RewriteRuleITokenStream(adaptor,"token LET");
		RewriteRuleSubtreeStream stream_declaration_list=new RewriteRuleSubtreeStream(adaptor,"rule declaration_list");
		RewriteRuleSubtreeStream stream_expression_sequence=new RewriteRuleSubtreeStream(adaptor,"rule expression_sequence");
		try { DebugEnterRule(GrammarFileName, "let_expression");
		DebugLocation(448, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:449:2: ( LET declaration_list IN ( expression_sequence )? END -> ^( LET declaration_list ( expression_sequence )? ) )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:449:4: LET declaration_list IN ( expression_sequence )? END
			{
			DebugLocation(449, 4);
			LET54=(IToken)Match(input,LET,Follow._LET_in_let_expression2101); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_LET.Add(LET54);

			DebugLocation(449, 8);
			PushFollow(Follow._declaration_list_in_let_expression2103);
			declaration_list55=declaration_list();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declaration_list.Add(declaration_list55.Tree);
			DebugLocation(449, 25);
			IN56=(IToken)Match(input,IN,Follow._IN_in_let_expression2105); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IN.Add(IN56);

			DebugLocation(449, 28);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:449:28: ( expression_sequence )?
			int alt24=2;
			try { DebugEnterSubRule(24);
			try { DebugEnterDecision(24, decisionCanBacktrack[24]);
			int LA24_0 = input.LA(1);

			if ((LA24_0==BREAK||LA24_0==FOR||LA24_0==IF||(LA24_0>=LET && LA24_0<=NIL)||LA24_0==WHILE||LA24_0==LEFT_PARENTHESIS||LA24_0==MINUS||(LA24_0>=ID && LA24_0<=INT)||LA24_0==STRING))
			{
				alt24=1;
			}
			} finally { DebugExitDecision(24); }
			switch (alt24)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:449:28: expression_sequence
				{
				DebugLocation(449, 28);
				PushFollow(Follow._expression_sequence_in_let_expression2107);
				expression_sequence57=expression_sequence();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression_sequence.Add(expression_sequence57.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(24); }

			DebugLocation(449, 49);
			END58=(IToken)Match(input,END,Follow._END_in_let_expression2110); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END58);



			{
			// AST REWRITE
			// elements: declaration_list, LET, expression_sequence
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 449:53: -> ^( LET declaration_list ( expression_sequence )? )
			{
				DebugLocation(449, 56);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:449:56: ^( LET declaration_list ( expression_sequence )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(449, 58);
				root_1 = (object)adaptor.BecomeRoot(stream_LET.NextNode(), root_1);

				DebugLocation(449, 62);
				adaptor.AddChild(root_1, stream_declaration_list.NextTree());
				DebugLocation(449, 79);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:449:79: ( expression_sequence )?
				if ( stream_expression_sequence.HasNext )
				{
					DebugLocation(449, 79);
					adaptor.AddChild(root_1, stream_expression_sequence.NextTree());

				}
				stream_expression_sequence.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("let_expression", 23);
			LeaveRule("let_expression", 23);
			Leave_let_expression();
		}
		DebugLocation(450, 1);
		} finally { DebugExitRule(GrammarFileName, "let_expression"); }
		return retval;

	}
	// $ANTLR end "let_expression"

	public class expression_sequence_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expression_sequence();
	partial void Leave_expression_sequence();

	// $ANTLR start "expression_sequence"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:452:1: expression_sequence : expression ( SEMICOLON expression )* -> ^( EXPRESSION_SET ( expression )+ ) ;
	[GrammarRule("expression_sequence")]
	private TigerParser.expression_sequence_return expression_sequence()
	{
		Enter_expression_sequence();
		EnterRule("expression_sequence", 24);
		TraceIn("expression_sequence", 24);
		TigerParser.expression_sequence_return retval = new TigerParser.expression_sequence_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken SEMICOLON60=null;
		TigerParser.expression_return expression59 = default(TigerParser.expression_return);
		TigerParser.expression_return expression61 = default(TigerParser.expression_return);

		object SEMICOLON60_tree=null;
		RewriteRuleITokenStream stream_SEMICOLON=new RewriteRuleITokenStream(adaptor,"token SEMICOLON");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "expression_sequence");
		DebugLocation(452, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:453:2: ( expression ( SEMICOLON expression )* -> ^( EXPRESSION_SET ( expression )+ ) )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:453:4: expression ( SEMICOLON expression )*
			{
			DebugLocation(453, 4);
			PushFollow(Follow._expression_in_expression_sequence2132);
			expression59=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression59.Tree);
			DebugLocation(453, 15);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:453:15: ( SEMICOLON expression )*
			try { DebugEnterSubRule(25);
			while (true)
			{
				int alt25=2;
				try { DebugEnterDecision(25, decisionCanBacktrack[25]);
				int LA25_0 = input.LA(1);

				if ((LA25_0==SEMICOLON))
				{
					alt25=1;
				}


				} finally { DebugExitDecision(25); }
				switch ( alt25 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:453:16: SEMICOLON expression
					{
					DebugLocation(453, 16);
					SEMICOLON60=(IToken)Match(input,SEMICOLON,Follow._SEMICOLON_in_expression_sequence2135); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_SEMICOLON.Add(SEMICOLON60);

					DebugLocation(453, 26);
					PushFollow(Follow._expression_in_expression_sequence2137);
					expression61=expression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_expression.Add(expression61.Tree);

					}
					break;

				default:
					goto loop25;
				}
			}

			loop25:
				;

			} finally { DebugExitSubRule(25); }



			{
			// AST REWRITE
			// elements: expression
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 453:39: -> ^( EXPRESSION_SET ( expression )+ )
			{
				DebugLocation(453, 42);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:453:42: ^( EXPRESSION_SET ( expression )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(453, 44);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(EXPRESSION_SET, "EXPRESSION_SET"), root_1);

				DebugLocation(453, 59);
				if ( !(stream_expression.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_expression.HasNext )
				{
					DebugLocation(453, 59);
					adaptor.AddChild(root_1, stream_expression.NextTree());

				}
				stream_expression.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expression_sequence", 24);
			LeaveRule("expression_sequence", 24);
			Leave_expression_sequence();
		}
		DebugLocation(454, 1);
		} finally { DebugExitRule(GrammarFileName, "expression_sequence"); }
		return retval;

	}
	// $ANTLR end "expression_sequence"

	public class expression_list_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expression_list();
	partial void Leave_expression_list();

	// $ANTLR start "expression_list"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:456:1: expression_list : expression ( COMMA expression )* -> ^( EXPRESSION_SET ( expression )+ ) ;
	[GrammarRule("expression_list")]
	private TigerParser.expression_list_return expression_list()
	{
		Enter_expression_list();
		EnterRule("expression_list", 25);
		TraceIn("expression_list", 25);
		TigerParser.expression_list_return retval = new TigerParser.expression_list_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken COMMA63=null;
		TigerParser.expression_return expression62 = default(TigerParser.expression_return);
		TigerParser.expression_return expression64 = default(TigerParser.expression_return);

		object COMMA63_tree=null;
		RewriteRuleITokenStream stream_COMMA=new RewriteRuleITokenStream(adaptor,"token COMMA");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "expression_list");
		DebugLocation(456, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:457:2: ( expression ( COMMA expression )* -> ^( EXPRESSION_SET ( expression )+ ) )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:457:4: expression ( COMMA expression )*
			{
			DebugLocation(457, 4);
			PushFollow(Follow._expression_in_expression_list2159);
			expression62=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression62.Tree);
			DebugLocation(457, 15);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:457:15: ( COMMA expression )*
			try { DebugEnterSubRule(26);
			while (true)
			{
				int alt26=2;
				try { DebugEnterDecision(26, decisionCanBacktrack[26]);
				int LA26_0 = input.LA(1);

				if ((LA26_0==COMMA))
				{
					alt26=1;
				}


				} finally { DebugExitDecision(26); }
				switch ( alt26 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:457:16: COMMA expression
					{
					DebugLocation(457, 16);
					COMMA63=(IToken)Match(input,COMMA,Follow._COMMA_in_expression_list2162); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_COMMA.Add(COMMA63);

					DebugLocation(457, 22);
					PushFollow(Follow._expression_in_expression_list2164);
					expression64=expression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_expression.Add(expression64.Tree);

					}
					break;

				default:
					goto loop26;
				}
			}

			loop26:
				;

			} finally { DebugExitSubRule(26); }



			{
			// AST REWRITE
			// elements: expression
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 457:35: -> ^( EXPRESSION_SET ( expression )+ )
			{
				DebugLocation(457, 38);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:457:38: ^( EXPRESSION_SET ( expression )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(457, 40);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(EXPRESSION_SET, "EXPRESSION_SET"), root_1);

				DebugLocation(457, 55);
				if ( !(stream_expression.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_expression.HasNext )
				{
					DebugLocation(457, 55);
					adaptor.AddChild(root_1, stream_expression.NextTree());

				}
				stream_expression.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expression_list", 25);
			LeaveRule("expression_list", 25);
			Leave_expression_list();
		}
		DebugLocation(458, 1);
		} finally { DebugExitRule(GrammarFileName, "expression_list"); }
		return retval;

	}
	// $ANTLR end "expression_list"

	public class field_list_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_field_list();
	partial void Leave_field_list();

	// $ANTLR start "field_list"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:460:1: field_list : field ( COMMA field )* -> ^( EXPRESSION_SET ( field )+ ) ;
	[GrammarRule("field_list")]
	private TigerParser.field_list_return field_list()
	{
		Enter_field_list();
		EnterRule("field_list", 26);
		TraceIn("field_list", 26);
		TigerParser.field_list_return retval = new TigerParser.field_list_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken COMMA66=null;
		TigerParser.field_return field65 = default(TigerParser.field_return);
		TigerParser.field_return field67 = default(TigerParser.field_return);

		object COMMA66_tree=null;
		RewriteRuleITokenStream stream_COMMA=new RewriteRuleITokenStream(adaptor,"token COMMA");
		RewriteRuleSubtreeStream stream_field=new RewriteRuleSubtreeStream(adaptor,"rule field");
		try { DebugEnterRule(GrammarFileName, "field_list");
		DebugLocation(460, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:461:2: ( field ( COMMA field )* -> ^( EXPRESSION_SET ( field )+ ) )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:461:4: field ( COMMA field )*
			{
			DebugLocation(461, 4);
			PushFollow(Follow._field_in_field_list2186);
			field65=field();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_field.Add(field65.Tree);
			DebugLocation(461, 10);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:461:10: ( COMMA field )*
			try { DebugEnterSubRule(27);
			while (true)
			{
				int alt27=2;
				try { DebugEnterDecision(27, decisionCanBacktrack[27]);
				int LA27_0 = input.LA(1);

				if ((LA27_0==COMMA))
				{
					alt27=1;
				}


				} finally { DebugExitDecision(27); }
				switch ( alt27 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:461:11: COMMA field
					{
					DebugLocation(461, 11);
					COMMA66=(IToken)Match(input,COMMA,Follow._COMMA_in_field_list2189); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_COMMA.Add(COMMA66);

					DebugLocation(461, 17);
					PushFollow(Follow._field_in_field_list2191);
					field67=field();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_field.Add(field67.Tree);

					}
					break;

				default:
					goto loop27;
				}
			}

			loop27:
				;

			} finally { DebugExitSubRule(27); }



			{
			// AST REWRITE
			// elements: field
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 461:25: -> ^( EXPRESSION_SET ( field )+ )
			{
				DebugLocation(461, 28);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:461:28: ^( EXPRESSION_SET ( field )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(461, 30);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(EXPRESSION_SET, "EXPRESSION_SET"), root_1);

				DebugLocation(461, 45);
				if ( !(stream_field.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_field.HasNext )
				{
					DebugLocation(461, 45);
					adaptor.AddChild(root_1, stream_field.NextTree());

				}
				stream_field.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("field_list", 26);
			LeaveRule("field_list", 26);
			Leave_field_list();
		}
		DebugLocation(462, 1);
		} finally { DebugExitRule(GrammarFileName, "field_list"); }
		return retval;

	}
	// $ANTLR end "field_list"

	public class field_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_field();
	partial void Leave_field();

	// $ANTLR start "field"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:464:1: field : ID EQUAL expression -> ^( FIELD ID expression ) ;
	[GrammarRule("field")]
	private TigerParser.field_return field()
	{
		Enter_field();
		EnterRule("field", 27);
		TraceIn("field", 27);
		TigerParser.field_return retval = new TigerParser.field_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID68=null;
		IToken EQUAL69=null;
		TigerParser.expression_return expression70 = default(TigerParser.expression_return);

		object ID68_tree=null;
		object EQUAL69_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_EQUAL=new RewriteRuleITokenStream(adaptor,"token EQUAL");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "field");
		DebugLocation(464, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:464:7: ( ID EQUAL expression -> ^( FIELD ID expression ) )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:464:9: ID EQUAL expression
			{
			DebugLocation(464, 9);
			ID68=(IToken)Match(input,ID,Follow._ID_in_field2212); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID68);

			DebugLocation(464, 12);
			EQUAL69=(IToken)Match(input,EQUAL,Follow._EQUAL_in_field2214); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_EQUAL.Add(EQUAL69);

			DebugLocation(464, 18);
			PushFollow(Follow._expression_in_field2216);
			expression70=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression70.Tree);


			{
			// AST REWRITE
			// elements: ID, expression
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 464:29: -> ^( FIELD ID expression )
			{
				DebugLocation(464, 32);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:464:32: ^( FIELD ID expression )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(464, 34);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FIELD, "FIELD"), root_1);

				DebugLocation(464, 40);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(464, 43);
				adaptor.AddChild(root_1, stream_expression.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("field", 27);
			LeaveRule("field", 27);
			Leave_field();
		}
		DebugLocation(465, 1);
		} finally { DebugExitRule(GrammarFileName, "field"); }
		return retval;

	}
	// $ANTLR end "field"

	public class declaration_list_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_declaration_list();
	partial void Leave_declaration_list();

	// $ANTLR start "declaration_list"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:467:1: declaration_list : ( declaration )+ -> ^( EXPRESSION_SET ( declaration )+ ) ;
	[GrammarRule("declaration_list")]
	private TigerParser.declaration_list_return declaration_list()
	{
		Enter_declaration_list();
		EnterRule("declaration_list", 28);
		TraceIn("declaration_list", 28);
		TigerParser.declaration_list_return retval = new TigerParser.declaration_list_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		TigerParser.declaration_return declaration71 = default(TigerParser.declaration_return);

		RewriteRuleSubtreeStream stream_declaration=new RewriteRuleSubtreeStream(adaptor,"rule declaration");
		try { DebugEnterRule(GrammarFileName, "declaration_list");
		DebugLocation(467, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:468:2: ( ( declaration )+ -> ^( EXPRESSION_SET ( declaration )+ ) )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:468:4: ( declaration )+
			{
			DebugLocation(468, 4);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:468:4: ( declaration )+
			int cnt28=0;
			try { DebugEnterSubRule(28);
			while (true)
			{
				int alt28=2;
				try { DebugEnterDecision(28, decisionCanBacktrack[28]);
				int LA28_0 = input.LA(1);

				if ((LA28_0==FUNCTION||(LA28_0>=TYPE && LA28_0<=VAR)))
				{
					alt28=1;
				}


				} finally { DebugExitDecision(28); }
				switch (alt28)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:468:4: declaration
					{
					DebugLocation(468, 4);
					PushFollow(Follow._declaration_in_declaration_list2237);
					declaration71=declaration();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_declaration.Add(declaration71.Tree);

					}
					break;

				default:
					if (cnt28 >= 1)
						goto loop28;

					if (state.backtracking>0) {state.failed=true; return retval;}
					EarlyExitException eee28 = new EarlyExitException( 28, input );
					DebugRecognitionException(eee28);
					throw eee28;
				}
				cnt28++;
			}
			loop28:
				;

			} finally { DebugExitSubRule(28); }



			{
			// AST REWRITE
			// elements: declaration
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 468:17: -> ^( EXPRESSION_SET ( declaration )+ )
			{
				DebugLocation(468, 20);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:468:20: ^( EXPRESSION_SET ( declaration )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(468, 22);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(EXPRESSION_SET, "EXPRESSION_SET"), root_1);

				DebugLocation(468, 37);
				if ( !(stream_declaration.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_declaration.HasNext )
				{
					DebugLocation(468, 37);
					adaptor.AddChild(root_1, stream_declaration.NextTree());

				}
				stream_declaration.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("declaration_list", 28);
			LeaveRule("declaration_list", 28);
			Leave_declaration_list();
		}
		DebugLocation(469, 1);
		} finally { DebugExitRule(GrammarFileName, "declaration_list"); }
		return retval;

	}
	// $ANTLR end "declaration_list"

	public class declaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_declaration();
	partial void Leave_declaration();

	// $ANTLR start "declaration"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:471:1: declaration : ( type_declaration | variable_declaration | function_declaration );
	[GrammarRule("declaration")]
	private TigerParser.declaration_return declaration()
	{
		Enter_declaration();
		EnterRule("declaration", 29);
		TraceIn("declaration", 29);
		TigerParser.declaration_return retval = new TigerParser.declaration_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		TigerParser.type_declaration_return type_declaration72 = default(TigerParser.type_declaration_return);
		TigerParser.variable_declaration_return variable_declaration73 = default(TigerParser.variable_declaration_return);
		TigerParser.function_declaration_return function_declaration74 = default(TigerParser.function_declaration_return);


		try { DebugEnterRule(GrammarFileName, "declaration");
		DebugLocation(471, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:472:2: ( type_declaration | variable_declaration | function_declaration )
			int alt29=3;
			try { DebugEnterDecision(29, decisionCanBacktrack[29]);
			switch (input.LA(1))
			{
			case TYPE:
				{
				alt29=1;
				}
				break;
			case VAR:
				{
				alt29=2;
				}
				break;
			case FUNCTION:
				{
				alt29=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 29, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(29); }
			switch (alt29)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:472:4: type_declaration
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(472, 4);
				PushFollow(Follow._type_declaration_in_declaration2258);
				type_declaration72=type_declaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type_declaration72.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:473:4: variable_declaration
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(473, 4);
				PushFollow(Follow._variable_declaration_in_declaration2263);
				variable_declaration73=variable_declaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variable_declaration73.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:474:4: function_declaration
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(474, 4);
				PushFollow(Follow._function_declaration_in_declaration2268);
				function_declaration74=function_declaration();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, function_declaration74.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("declaration", 29);
			LeaveRule("declaration", 29);
			Leave_declaration();
		}
		DebugLocation(475, 1);
		} finally { DebugExitRule(GrammarFileName, "declaration"); }
		return retval;

	}
	// $ANTLR end "declaration"

	public class type_declaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_type_declaration();
	partial void Leave_type_declaration();

	// $ANTLR start "type_declaration"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:477:1: type_declaration : TYPE typeId= ID EQUAL (existingType= ID -> ^( EXPLICIT_TYPE_DECLARATION $typeId $existingType) | LEFT_KEY ( type_fields )? RIGHT_KEY -> ^( RECORD_TYPE_DECLARATION $typeId ( type_fields )? ) | ARRAY OF arrayType= ID -> ^( ARRAY_TYPE_DECLARATION $typeId $arrayType) ) ;
	[GrammarRule("type_declaration")]
	private TigerParser.type_declaration_return type_declaration()
	{
		Enter_type_declaration();
		EnterRule("type_declaration", 30);
		TraceIn("type_declaration", 30);
		TigerParser.type_declaration_return retval = new TigerParser.type_declaration_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken typeId=null;
		IToken existingType=null;
		IToken arrayType=null;
		IToken TYPE75=null;
		IToken EQUAL76=null;
		IToken LEFT_KEY77=null;
		IToken RIGHT_KEY79=null;
		IToken ARRAY80=null;
		IToken OF81=null;
		TigerParser.type_fields_return type_fields78 = default(TigerParser.type_fields_return);

		object typeId_tree=null;
		object existingType_tree=null;
		object arrayType_tree=null;
		object TYPE75_tree=null;
		object EQUAL76_tree=null;
		object LEFT_KEY77_tree=null;
		object RIGHT_KEY79_tree=null;
		object ARRAY80_tree=null;
		object OF81_tree=null;
		RewriteRuleITokenStream stream_RIGHT_KEY=new RewriteRuleITokenStream(adaptor,"token RIGHT_KEY");
		RewriteRuleITokenStream stream_LEFT_KEY=new RewriteRuleITokenStream(adaptor,"token LEFT_KEY");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_OF=new RewriteRuleITokenStream(adaptor,"token OF");
		RewriteRuleITokenStream stream_ARRAY=new RewriteRuleITokenStream(adaptor,"token ARRAY");
		RewriteRuleITokenStream stream_EQUAL=new RewriteRuleITokenStream(adaptor,"token EQUAL");
		RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");
		RewriteRuleSubtreeStream stream_type_fields=new RewriteRuleSubtreeStream(adaptor,"rule type_fields");
		try { DebugEnterRule(GrammarFileName, "type_declaration");
		DebugLocation(477, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:478:2: ( TYPE typeId= ID EQUAL (existingType= ID -> ^( EXPLICIT_TYPE_DECLARATION $typeId $existingType) | LEFT_KEY ( type_fields )? RIGHT_KEY -> ^( RECORD_TYPE_DECLARATION $typeId ( type_fields )? ) | ARRAY OF arrayType= ID -> ^( ARRAY_TYPE_DECLARATION $typeId $arrayType) ) )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:478:4: TYPE typeId= ID EQUAL (existingType= ID -> ^( EXPLICIT_TYPE_DECLARATION $typeId $existingType) | LEFT_KEY ( type_fields )? RIGHT_KEY -> ^( RECORD_TYPE_DECLARATION $typeId ( type_fields )? ) | ARRAY OF arrayType= ID -> ^( ARRAY_TYPE_DECLARATION $typeId $arrayType) )
			{
			DebugLocation(478, 4);
			TYPE75=(IToken)Match(input,TYPE,Follow._TYPE_in_type_declaration2279); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE75);

			DebugLocation(478, 16);
			typeId=(IToken)Match(input,ID,Follow._ID_in_type_declaration2285); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(typeId);

			DebugLocation(478, 21);
			EQUAL76=(IToken)Match(input,EQUAL,Follow._EQUAL_in_type_declaration2287); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_EQUAL.Add(EQUAL76);

			DebugLocation(478, 27);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:478:27: (existingType= ID -> ^( EXPLICIT_TYPE_DECLARATION $typeId $existingType) | LEFT_KEY ( type_fields )? RIGHT_KEY -> ^( RECORD_TYPE_DECLARATION $typeId ( type_fields )? ) | ARRAY OF arrayType= ID -> ^( ARRAY_TYPE_DECLARATION $typeId $arrayType) )
			int alt31=3;
			try { DebugEnterSubRule(31);
			try { DebugEnterDecision(31, decisionCanBacktrack[31]);
			switch (input.LA(1))
			{
			case ID:
				{
				alt31=1;
				}
				break;
			case LEFT_KEY:
				{
				alt31=2;
				}
				break;
			case ARRAY:
				{
				alt31=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 31, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(31); }
			switch (alt31)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:478:29: existingType= ID
				{
				DebugLocation(478, 42);
				existingType=(IToken)Match(input,ID,Follow._ID_in_type_declaration2295); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(existingType);



				{
				// AST REWRITE
				// elements: typeId, existingType
				// token labels: existingType, typeId
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleITokenStream stream_existingType=new RewriteRuleITokenStream(adaptor,"token existingType",existingType);
				RewriteRuleITokenStream stream_typeId=new RewriteRuleITokenStream(adaptor,"token typeId",typeId);
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 478:47: -> ^( EXPLICIT_TYPE_DECLARATION $typeId $existingType)
				{
					DebugLocation(478, 50);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:478:50: ^( EXPLICIT_TYPE_DECLARATION $typeId $existingType)
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(478, 52);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(EXPLICIT_TYPE_DECLARATION, "EXPLICIT_TYPE_DECLARATION"), root_1);

					DebugLocation(478, 78);
					adaptor.AddChild(root_1, stream_typeId.NextNode());
					DebugLocation(478, 86);
					adaptor.AddChild(root_1, stream_existingType.NextNode());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:479:14: LEFT_KEY ( type_fields )? RIGHT_KEY
				{
				DebugLocation(479, 14);
				LEFT_KEY77=(IToken)Match(input,LEFT_KEY,Follow._LEFT_KEY_in_type_declaration2322); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LEFT_KEY.Add(LEFT_KEY77);

				DebugLocation(479, 23);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:479:23: ( type_fields )?
				int alt30=2;
				try { DebugEnterSubRule(30);
				try { DebugEnterDecision(30, decisionCanBacktrack[30]);
				int LA30_0 = input.LA(1);

				if ((LA30_0==ID))
				{
					alt30=1;
				}
				} finally { DebugExitDecision(30); }
				switch (alt30)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:479:23: type_fields
					{
					DebugLocation(479, 23);
					PushFollow(Follow._type_fields_in_type_declaration2324);
					type_fields78=type_fields();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_type_fields.Add(type_fields78.Tree);

					}
					break;

				}
				} finally { DebugExitSubRule(30); }

				DebugLocation(479, 36);
				RIGHT_KEY79=(IToken)Match(input,RIGHT_KEY,Follow._RIGHT_KEY_in_type_declaration2327); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_RIGHT_KEY.Add(RIGHT_KEY79);



				{
				// AST REWRITE
				// elements: typeId, type_fields
				// token labels: typeId
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleITokenStream stream_typeId=new RewriteRuleITokenStream(adaptor,"token typeId",typeId);
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 479:46: -> ^( RECORD_TYPE_DECLARATION $typeId ( type_fields )? )
				{
					DebugLocation(479, 49);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:479:49: ^( RECORD_TYPE_DECLARATION $typeId ( type_fields )? )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(479, 51);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(RECORD_TYPE_DECLARATION, "RECORD_TYPE_DECLARATION"), root_1);

					DebugLocation(479, 75);
					adaptor.AddChild(root_1, stream_typeId.NextNode());
					DebugLocation(479, 83);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:479:83: ( type_fields )?
					if ( stream_type_fields.HasNext )
					{
						DebugLocation(479, 83);
						adaptor.AddChild(root_1, stream_type_fields.NextTree());

					}
					stream_type_fields.Reset();

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:480:14: ARRAY OF arrayType= ID
				{
				DebugLocation(480, 14);
				ARRAY80=(IToken)Match(input,ARRAY,Follow._ARRAY_in_type_declaration2354); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ARRAY.Add(ARRAY80);

				DebugLocation(480, 20);
				OF81=(IToken)Match(input,OF,Follow._OF_in_type_declaration2356); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_OF.Add(OF81);

				DebugLocation(480, 33);
				arrayType=(IToken)Match(input,ID,Follow._ID_in_type_declaration2362); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(arrayType);



				{
				// AST REWRITE
				// elements: typeId, arrayType
				// token labels: arrayType, typeId
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleITokenStream stream_arrayType=new RewriteRuleITokenStream(adaptor,"token arrayType",arrayType);
				RewriteRuleITokenStream stream_typeId=new RewriteRuleITokenStream(adaptor,"token typeId",typeId);
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 480:38: -> ^( ARRAY_TYPE_DECLARATION $typeId $arrayType)
				{
					DebugLocation(480, 41);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:480:41: ^( ARRAY_TYPE_DECLARATION $typeId $arrayType)
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(480, 43);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARRAY_TYPE_DECLARATION, "ARRAY_TYPE_DECLARATION"), root_1);

					DebugLocation(480, 66);
					adaptor.AddChild(root_1, stream_typeId.NextNode());
					DebugLocation(480, 74);
					adaptor.AddChild(root_1, stream_arrayType.NextNode());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;

			}
			} finally { DebugExitSubRule(31); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("type_declaration", 30);
			LeaveRule("type_declaration", 30);
			Leave_type_declaration();
		}
		DebugLocation(481, 1);
		} finally { DebugExitRule(GrammarFileName, "type_declaration"); }
		return retval;

	}
	// $ANTLR end "type_declaration"

	public class type_fields_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_type_fields();
	partial void Leave_type_fields();

	// $ANTLR start "type_fields"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:483:1: type_fields : type_field ( COMMA type_field )* -> ^( EXPRESSION_SET ( type_field )+ ) ;
	[GrammarRule("type_fields")]
	private TigerParser.type_fields_return type_fields()
	{
		Enter_type_fields();
		EnterRule("type_fields", 31);
		TraceIn("type_fields", 31);
		TigerParser.type_fields_return retval = new TigerParser.type_fields_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken COMMA83=null;
		TigerParser.type_field_return type_field82 = default(TigerParser.type_field_return);
		TigerParser.type_field_return type_field84 = default(TigerParser.type_field_return);

		object COMMA83_tree=null;
		RewriteRuleITokenStream stream_COMMA=new RewriteRuleITokenStream(adaptor,"token COMMA");
		RewriteRuleSubtreeStream stream_type_field=new RewriteRuleSubtreeStream(adaptor,"rule type_field");
		try { DebugEnterRule(GrammarFileName, "type_fields");
		DebugLocation(483, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:484:2: ( type_field ( COMMA type_field )* -> ^( EXPRESSION_SET ( type_field )+ ) )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:484:4: type_field ( COMMA type_field )*
			{
			DebugLocation(484, 4);
			PushFollow(Follow._type_field_in_type_fields2386);
			type_field82=type_field();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type_field.Add(type_field82.Tree);
			DebugLocation(484, 15);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:484:15: ( COMMA type_field )*
			try { DebugEnterSubRule(32);
			while (true)
			{
				int alt32=2;
				try { DebugEnterDecision(32, decisionCanBacktrack[32]);
				int LA32_0 = input.LA(1);

				if ((LA32_0==COMMA))
				{
					alt32=1;
				}


				} finally { DebugExitDecision(32); }
				switch ( alt32 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:484:16: COMMA type_field
					{
					DebugLocation(484, 16);
					COMMA83=(IToken)Match(input,COMMA,Follow._COMMA_in_type_fields2389); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_COMMA.Add(COMMA83);

					DebugLocation(484, 22);
					PushFollow(Follow._type_field_in_type_fields2391);
					type_field84=type_field();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_type_field.Add(type_field84.Tree);

					}
					break;

				default:
					goto loop32;
				}
			}

			loop32:
				;

			} finally { DebugExitSubRule(32); }



			{
			// AST REWRITE
			// elements: type_field
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 484:35: -> ^( EXPRESSION_SET ( type_field )+ )
			{
				DebugLocation(484, 38);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:484:38: ^( EXPRESSION_SET ( type_field )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(484, 40);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(EXPRESSION_SET, "EXPRESSION_SET"), root_1);

				DebugLocation(484, 55);
				if ( !(stream_type_field.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_type_field.HasNext )
				{
					DebugLocation(484, 55);
					adaptor.AddChild(root_1, stream_type_field.NextTree());

				}
				stream_type_field.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("type_fields", 31);
			LeaveRule("type_fields", 31);
			Leave_type_fields();
		}
		DebugLocation(485, 1);
		} finally { DebugExitRule(GrammarFileName, "type_fields"); }
		return retval;

	}
	// $ANTLR end "type_fields"

	public class type_field_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_type_field();
	partial void Leave_type_field();

	// $ANTLR start "type_field"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:487:1: type_field : leftId= ID COLON rightId= ID -> ^( TYPE_FIELD $leftId $rightId) ;
	[GrammarRule("type_field")]
	private TigerParser.type_field_return type_field()
	{
		Enter_type_field();
		EnterRule("type_field", 32);
		TraceIn("type_field", 32);
		TigerParser.type_field_return retval = new TigerParser.type_field_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken leftId=null;
		IToken rightId=null;
		IToken COLON85=null;

		object leftId_tree=null;
		object rightId_tree=null;
		object COLON85_tree=null;
		RewriteRuleITokenStream stream_COLON=new RewriteRuleITokenStream(adaptor,"token COLON");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");

		try { DebugEnterRule(GrammarFileName, "type_field");
		DebugLocation(487, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:488:2: (leftId= ID COLON rightId= ID -> ^( TYPE_FIELD $leftId $rightId) )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:488:4: leftId= ID COLON rightId= ID
			{
			DebugLocation(488, 11);
			leftId=(IToken)Match(input,ID,Follow._ID_in_type_field2417); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(leftId);

			DebugLocation(488, 16);
			COLON85=(IToken)Match(input,COLON,Follow._COLON_in_type_field2419); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_COLON.Add(COLON85);

			DebugLocation(488, 30);
			rightId=(IToken)Match(input,ID,Follow._ID_in_type_field2425); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(rightId);



			{
			// AST REWRITE
			// elements: rightId, leftId
			// token labels: leftId, rightId
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleITokenStream stream_leftId=new RewriteRuleITokenStream(adaptor,"token leftId",leftId);
			RewriteRuleITokenStream stream_rightId=new RewriteRuleITokenStream(adaptor,"token rightId",rightId);
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 488:35: -> ^( TYPE_FIELD $leftId $rightId)
			{
				DebugLocation(488, 38);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:488:38: ^( TYPE_FIELD $leftId $rightId)
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(488, 40);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE_FIELD, "TYPE_FIELD"), root_1);

				DebugLocation(488, 51);
				adaptor.AddChild(root_1, stream_leftId.NextNode());
				DebugLocation(488, 59);
				adaptor.AddChild(root_1, stream_rightId.NextNode());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("type_field", 32);
			LeaveRule("type_field", 32);
			Leave_type_field();
		}
		DebugLocation(489, 1);
		} finally { DebugExitRule(GrammarFileName, "type_field"); }
		return retval;

	}
	// $ANTLR end "type_field"

	public class variable_declaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_variable_declaration();
	partial void Leave_variable_declaration();

	// $ANTLR start "variable_declaration"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:491:1: variable_declaration : VAR variableId= ID ( ASSIGNMENT expression -> ^( VARIABLE_DECLARATION $variableId expression ) | COLON typeId= ID ASSIGNMENT expression -> ^( VARIABLE_TYPE_DECLARATION $variableId expression $typeId) ) ;
	[GrammarRule("variable_declaration")]
	private TigerParser.variable_declaration_return variable_declaration()
	{
		Enter_variable_declaration();
		EnterRule("variable_declaration", 33);
		TraceIn("variable_declaration", 33);
		TigerParser.variable_declaration_return retval = new TigerParser.variable_declaration_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken variableId=null;
		IToken typeId=null;
		IToken VAR86=null;
		IToken ASSIGNMENT87=null;
		IToken COLON89=null;
		IToken ASSIGNMENT90=null;
		TigerParser.expression_return expression88 = default(TigerParser.expression_return);
		TigerParser.expression_return expression91 = default(TigerParser.expression_return);

		object variableId_tree=null;
		object typeId_tree=null;
		object VAR86_tree=null;
		object ASSIGNMENT87_tree=null;
		object COLON89_tree=null;
		object ASSIGNMENT90_tree=null;
		RewriteRuleITokenStream stream_COLON=new RewriteRuleITokenStream(adaptor,"token COLON");
		RewriteRuleITokenStream stream_VAR=new RewriteRuleITokenStream(adaptor,"token VAR");
		RewriteRuleITokenStream stream_ASSIGNMENT=new RewriteRuleITokenStream(adaptor,"token ASSIGNMENT");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "variable_declaration");
		DebugLocation(491, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:492:2: ( VAR variableId= ID ( ASSIGNMENT expression -> ^( VARIABLE_DECLARATION $variableId expression ) | COLON typeId= ID ASSIGNMENT expression -> ^( VARIABLE_TYPE_DECLARATION $variableId expression $typeId) ) )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:492:4: VAR variableId= ID ( ASSIGNMENT expression -> ^( VARIABLE_DECLARATION $variableId expression ) | COLON typeId= ID ASSIGNMENT expression -> ^( VARIABLE_TYPE_DECLARATION $variableId expression $typeId) )
			{
			DebugLocation(492, 4);
			VAR86=(IToken)Match(input,VAR,Follow._VAR_in_variable_declaration2448); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_VAR.Add(VAR86);

			DebugLocation(492, 19);
			variableId=(IToken)Match(input,ID,Follow._ID_in_variable_declaration2454); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(variableId);

			DebugLocation(492, 24);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:492:24: ( ASSIGNMENT expression -> ^( VARIABLE_DECLARATION $variableId expression ) | COLON typeId= ID ASSIGNMENT expression -> ^( VARIABLE_TYPE_DECLARATION $variableId expression $typeId) )
			int alt33=2;
			try { DebugEnterSubRule(33);
			try { DebugEnterDecision(33, decisionCanBacktrack[33]);
			int LA33_0 = input.LA(1);

			if ((LA33_0==ASSIGNMENT))
			{
				alt33=1;
			}
			else if ((LA33_0==COLON))
			{
				alt33=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 33, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(33); }
			switch (alt33)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:492:26: ASSIGNMENT expression
				{
				DebugLocation(492, 26);
				ASSIGNMENT87=(IToken)Match(input,ASSIGNMENT,Follow._ASSIGNMENT_in_variable_declaration2458); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGNMENT.Add(ASSIGNMENT87);

				DebugLocation(492, 37);
				PushFollow(Follow._expression_in_variable_declaration2460);
				expression88=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression88.Tree);


				{
				// AST REWRITE
				// elements: variableId, expression
				// token labels: variableId
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleITokenStream stream_variableId=new RewriteRuleITokenStream(adaptor,"token variableId",variableId);
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 492:48: -> ^( VARIABLE_DECLARATION $variableId expression )
				{
					DebugLocation(492, 51);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:492:51: ^( VARIABLE_DECLARATION $variableId expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(492, 53);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARIABLE_DECLARATION, "VARIABLE_DECLARATION"), root_1);

					DebugLocation(492, 74);
					adaptor.AddChild(root_1, stream_variableId.NextNode());
					DebugLocation(492, 86);
					adaptor.AddChild(root_1, stream_expression.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:493:11: COLON typeId= ID ASSIGNMENT expression
				{
				DebugLocation(493, 11);
				COLON89=(IToken)Match(input,COLON,Follow._COLON_in_variable_declaration2483); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_COLON.Add(COLON89);

				DebugLocation(493, 24);
				typeId=(IToken)Match(input,ID,Follow._ID_in_variable_declaration2489); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(typeId);

				DebugLocation(493, 29);
				ASSIGNMENT90=(IToken)Match(input,ASSIGNMENT,Follow._ASSIGNMENT_in_variable_declaration2491); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGNMENT.Add(ASSIGNMENT90);

				DebugLocation(493, 40);
				PushFollow(Follow._expression_in_variable_declaration2493);
				expression91=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression91.Tree);


				{
				// AST REWRITE
				// elements: expression, variableId, typeId
				// token labels: variableId, typeId
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleITokenStream stream_variableId=new RewriteRuleITokenStream(adaptor,"token variableId",variableId);
				RewriteRuleITokenStream stream_typeId=new RewriteRuleITokenStream(adaptor,"token typeId",typeId);
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 493:51: -> ^( VARIABLE_TYPE_DECLARATION $variableId expression $typeId)
				{
					DebugLocation(493, 54);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:493:54: ^( VARIABLE_TYPE_DECLARATION $variableId expression $typeId)
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(493, 56);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARIABLE_TYPE_DECLARATION, "VARIABLE_TYPE_DECLARATION"), root_1);

					DebugLocation(493, 82);
					adaptor.AddChild(root_1, stream_variableId.NextNode());
					DebugLocation(493, 94);
					adaptor.AddChild(root_1, stream_expression.NextTree());
					DebugLocation(493, 105);
					adaptor.AddChild(root_1, stream_typeId.NextNode());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;

			}
			} finally { DebugExitSubRule(33); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("variable_declaration", 33);
			LeaveRule("variable_declaration", 33);
			Leave_variable_declaration();
		}
		DebugLocation(494, 1);
		} finally { DebugExitRule(GrammarFileName, "variable_declaration"); }
		return retval;

	}
	// $ANTLR end "variable_declaration"

	public class function_declaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_function_declaration();
	partial void Leave_function_declaration();

	// $ANTLR start "function_declaration"
	// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:496:1: function_declaration : FUNCTION functionId= ID LEFT_PARENTHESIS ( type_fields )? RIGHT_PARENTHESIS ( EQUAL expression -> ^( FUNCTION_DECLARATION $functionId ( type_fields )? expression ) | COLON returnType= ID EQUAL expression -> ^( FUNCTION_DECLARATION $functionId ( type_fields )? $returnType expression ) ) ;
	[GrammarRule("function_declaration")]
	private TigerParser.function_declaration_return function_declaration()
	{
		Enter_function_declaration();
		EnterRule("function_declaration", 34);
		TraceIn("function_declaration", 34);
		TigerParser.function_declaration_return retval = new TigerParser.function_declaration_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken functionId=null;
		IToken returnType=null;
		IToken FUNCTION92=null;
		IToken LEFT_PARENTHESIS93=null;
		IToken RIGHT_PARENTHESIS95=null;
		IToken EQUAL96=null;
		IToken COLON98=null;
		IToken EQUAL99=null;
		TigerParser.type_fields_return type_fields94 = default(TigerParser.type_fields_return);
		TigerParser.expression_return expression97 = default(TigerParser.expression_return);
		TigerParser.expression_return expression100 = default(TigerParser.expression_return);

		object functionId_tree=null;
		object returnType_tree=null;
		object FUNCTION92_tree=null;
		object LEFT_PARENTHESIS93_tree=null;
		object RIGHT_PARENTHESIS95_tree=null;
		object EQUAL96_tree=null;
		object COLON98_tree=null;
		object EQUAL99_tree=null;
		RewriteRuleITokenStream stream_FUNCTION=new RewriteRuleITokenStream(adaptor,"token FUNCTION");
		RewriteRuleITokenStream stream_COLON=new RewriteRuleITokenStream(adaptor,"token COLON");
		RewriteRuleITokenStream stream_RIGHT_PARENTHESIS=new RewriteRuleITokenStream(adaptor,"token RIGHT_PARENTHESIS");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_LEFT_PARENTHESIS=new RewriteRuleITokenStream(adaptor,"token LEFT_PARENTHESIS");
		RewriteRuleITokenStream stream_EQUAL=new RewriteRuleITokenStream(adaptor,"token EQUAL");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		RewriteRuleSubtreeStream stream_type_fields=new RewriteRuleSubtreeStream(adaptor,"rule type_fields");
		try { DebugEnterRule(GrammarFileName, "function_declaration");
		DebugLocation(496, 1);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:497:2: ( FUNCTION functionId= ID LEFT_PARENTHESIS ( type_fields )? RIGHT_PARENTHESIS ( EQUAL expression -> ^( FUNCTION_DECLARATION $functionId ( type_fields )? expression ) | COLON returnType= ID EQUAL expression -> ^( FUNCTION_DECLARATION $functionId ( type_fields )? $returnType expression ) ) )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:497:4: FUNCTION functionId= ID LEFT_PARENTHESIS ( type_fields )? RIGHT_PARENTHESIS ( EQUAL expression -> ^( FUNCTION_DECLARATION $functionId ( type_fields )? expression ) | COLON returnType= ID EQUAL expression -> ^( FUNCTION_DECLARATION $functionId ( type_fields )? $returnType expression ) )
			{
			DebugLocation(497, 4);
			FUNCTION92=(IToken)Match(input,FUNCTION,Follow._FUNCTION_in_function_declaration2519); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_FUNCTION.Add(FUNCTION92);

			DebugLocation(497, 24);
			functionId=(IToken)Match(input,ID,Follow._ID_in_function_declaration2525); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(functionId);

			DebugLocation(497, 29);
			LEFT_PARENTHESIS93=(IToken)Match(input,LEFT_PARENTHESIS,Follow._LEFT_PARENTHESIS_in_function_declaration2527); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_LEFT_PARENTHESIS.Add(LEFT_PARENTHESIS93);

			DebugLocation(497, 46);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:497:46: ( type_fields )?
			int alt34=2;
			try { DebugEnterSubRule(34);
			try { DebugEnterDecision(34, decisionCanBacktrack[34]);
			int LA34_0 = input.LA(1);

			if ((LA34_0==ID))
			{
				alt34=1;
			}
			} finally { DebugExitDecision(34); }
			switch (alt34)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:497:46: type_fields
				{
				DebugLocation(497, 46);
				PushFollow(Follow._type_fields_in_function_declaration2529);
				type_fields94=type_fields();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type_fields.Add(type_fields94.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(34); }

			DebugLocation(497, 59);
			RIGHT_PARENTHESIS95=(IToken)Match(input,RIGHT_PARENTHESIS,Follow._RIGHT_PARENTHESIS_in_function_declaration2532); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_RIGHT_PARENTHESIS.Add(RIGHT_PARENTHESIS95);

			DebugLocation(497, 77);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:497:77: ( EQUAL expression -> ^( FUNCTION_DECLARATION $functionId ( type_fields )? expression ) | COLON returnType= ID EQUAL expression -> ^( FUNCTION_DECLARATION $functionId ( type_fields )? $returnType expression ) )
			int alt35=2;
			try { DebugEnterSubRule(35);
			try { DebugEnterDecision(35, decisionCanBacktrack[35]);
			int LA35_0 = input.LA(1);

			if ((LA35_0==EQUAL))
			{
				alt35=1;
			}
			else if ((LA35_0==COLON))
			{
				alt35=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 35, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(35); }
			switch (alt35)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:497:79: EQUAL expression
				{
				DebugLocation(497, 79);
				EQUAL96=(IToken)Match(input,EQUAL,Follow._EQUAL_in_function_declaration2536); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_EQUAL.Add(EQUAL96);

				DebugLocation(497, 85);
				PushFollow(Follow._expression_in_function_declaration2538);
				expression97=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression97.Tree);


				{
				// AST REWRITE
				// elements: type_fields, functionId, expression
				// token labels: functionId
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleITokenStream stream_functionId=new RewriteRuleITokenStream(adaptor,"token functionId",functionId);
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 497:96: -> ^( FUNCTION_DECLARATION $functionId ( type_fields )? expression )
				{
					DebugLocation(497, 99);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:497:99: ^( FUNCTION_DECLARATION $functionId ( type_fields )? expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(497, 101);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNCTION_DECLARATION, "FUNCTION_DECLARATION"), root_1);

					DebugLocation(497, 122);
					adaptor.AddChild(root_1, stream_functionId.NextNode());
					DebugLocation(497, 134);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:497:134: ( type_fields )?
					if ( stream_type_fields.HasNext )
					{
						DebugLocation(497, 134);
						adaptor.AddChild(root_1, stream_type_fields.NextTree());

					}
					stream_type_fields.Reset();
					DebugLocation(497, 147);
					adaptor.AddChild(root_1, stream_expression.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:498:15: COLON returnType= ID EQUAL expression
				{
				DebugLocation(498, 15);
				COLON98=(IToken)Match(input,COLON,Follow._COLON_in_function_declaration2568); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_COLON.Add(COLON98);

				DebugLocation(498, 32);
				returnType=(IToken)Match(input,ID,Follow._ID_in_function_declaration2574); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(returnType);

				DebugLocation(498, 37);
				EQUAL99=(IToken)Match(input,EQUAL,Follow._EQUAL_in_function_declaration2576); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_EQUAL.Add(EQUAL99);

				DebugLocation(498, 43);
				PushFollow(Follow._expression_in_function_declaration2578);
				expression100=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression100.Tree);


				{
				// AST REWRITE
				// elements: expression, type_fields, returnType, functionId
				// token labels: functionId, returnType
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleITokenStream stream_functionId=new RewriteRuleITokenStream(adaptor,"token functionId",functionId);
				RewriteRuleITokenStream stream_returnType=new RewriteRuleITokenStream(adaptor,"token returnType",returnType);
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 498:54: -> ^( FUNCTION_DECLARATION $functionId ( type_fields )? $returnType expression )
				{
					DebugLocation(498, 57);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:498:57: ^( FUNCTION_DECLARATION $functionId ( type_fields )? $returnType expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(498, 59);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNCTION_DECLARATION, "FUNCTION_DECLARATION"), root_1);

					DebugLocation(498, 80);
					adaptor.AddChild(root_1, stream_functionId.NextNode());
					DebugLocation(498, 92);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:498:92: ( type_fields )?
					if ( stream_type_fields.HasNext )
					{
						DebugLocation(498, 92);
						adaptor.AddChild(root_1, stream_type_fields.NextTree());

					}
					stream_type_fields.Reset();
					DebugLocation(498, 105);
					adaptor.AddChild(root_1, stream_returnType.NextNode());
					DebugLocation(498, 117);
					adaptor.AddChild(root_1, stream_expression.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;

			}
			} finally { DebugExitSubRule(35); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("function_declaration", 34);
			LeaveRule("function_declaration", 34);
			Leave_function_declaration();
		}
		DebugLocation(499, 1);
		} finally { DebugExitRule(GrammarFileName, "function_declaration"); }
		return retval;

	}
	// $ANTLR end "function_declaration"

	partial void Enter_synpred1_Tiger_fragment();
	partial void Leave_synpred1_Tiger_fragment();

	// $ANTLR start synpred1_Tiger
	public void synpred1_Tiger_fragment()
	{
		Enter_synpred1_Tiger_fragment();
		EnterRule("synpred1_Tiger_fragment", 35);
		TraceIn("synpred1_Tiger_fragment", 35);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:339:4: ( left_value_assignment ASSIGNMENT )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:339:5: left_value_assignment ASSIGNMENT
			{
			DebugLocation(339, 5);
			PushFollow(Follow._left_value_assignment_in_synpred1_Tiger1100);
			left_value_assignment();
			PopFollow();
			if (state.failed) return;
			DebugLocation(339, 27);
			Match(input,ASSIGNMENT,Follow._ASSIGNMENT_in_synpred1_Tiger1102); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred1_Tiger_fragment", 35);
			LeaveRule("synpred1_Tiger_fragment", 35);
			Leave_synpred1_Tiger_fragment();
		}
	}
	// $ANTLR end synpred1_Tiger

	partial void Enter_synpred2_Tiger_fragment();
	partial void Leave_synpred2_Tiger_fragment();

	// $ANTLR start synpred2_Tiger
	public void synpred2_Tiger_fragment()
	{
		Enter_synpred2_Tiger_fragment();
		EnterRule("synpred2_Tiger_fragment", 36);
		TraceIn("synpred2_Tiger_fragment", 36);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:436:76: ( ELSE )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:436:77: ELSE
			{
			DebugLocation(436, 77);
			Match(input,ELSE,Follow._ELSE_in_synpred2_Tiger1940); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred2_Tiger_fragment", 36);
			LeaveRule("synpred2_Tiger_fragment", 36);
			Leave_synpred2_Tiger_fragment();
		}
	}
	// $ANTLR end synpred2_Tiger
	#endregion Rules

	#region Synpreds
	private bool EvaluatePredicate(System.Action fragment)
	{
		bool success = false;
		state.backtracking++;
		try { DebugBeginBacktrack(state.backtracking);
		int start = input.Mark();
		try
		{
			fragment();
		}
		catch ( RecognitionException re )
		{
			System.Console.Error.WriteLine("impossible: "+re);
		}
		success = !state.failed;
		input.Rewind(start);
		} finally { DebugEndBacktrack(state.backtracking, success); }
		state.backtracking--;
		state.failed=false;
		return success;
	}
	#endregion Synpreds


	#region DFA
	DFA1 dfa1;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa1 = new DFA1( this, SpecialStateTransition1 );
	}

	private class DFA1 : DFA
	{
		private const string DFA1_eotS =
			"\xD\xFFFF";
		private const string DFA1_eofS =
			"\xD\xFFFF";
		private const string DFA1_minS =
			"\x1\x5\x1\x0\xB\xFFFF";
		private const string DFA1_maxS =
			"\x1\x4C\x1\x0\xB\xFFFF";
		private const string DFA1_acceptS =
			"\x2\xFFFF\x1\x2\x9\xFFFF\x1\x1";
		private const string DFA1_specialS =
			"\x1\xFFFF\x1\x0\xB\xFFFF}>";
		private static readonly string[] DFA1_transitionS =
			{
				"\x1\x2\x3\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\xFFFF\x2\x2\x5\xFFFF\x1\x2"+
				"\x3\xFFFF\x1\x2\x7\xFFFF\x1\x2\x22\xFFFF\x1\x1\x1\x2\x7\xFFFF\x1\x2",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA1_eot = DFA.UnpackEncodedString(DFA1_eotS);
		private static readonly short[] DFA1_eof = DFA.UnpackEncodedString(DFA1_eofS);
		private static readonly char[] DFA1_min = DFA.UnpackEncodedStringToUnsignedChars(DFA1_minS);
		private static readonly char[] DFA1_max = DFA.UnpackEncodedStringToUnsignedChars(DFA1_maxS);
		private static readonly short[] DFA1_accept = DFA.UnpackEncodedString(DFA1_acceptS);
		private static readonly short[] DFA1_special = DFA.UnpackEncodedString(DFA1_specialS);
		private static readonly short[][] DFA1_transition;

		static DFA1()
		{
			int numStates = DFA1_transitionS.Length;
			DFA1_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA1_transition[i] = DFA.UnpackEncodedString(DFA1_transitionS[i]);
			}
		}

		public DFA1( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 1;
			this.eot = DFA1_eot;
			this.eof = DFA1_eof;
			this.min = DFA1_min;
			this.max = DFA1_max;
			this.accept = DFA1_accept;
			this.special = DFA1_special;
			this.transition = DFA1_transition;
		}

		public override string Description { get { return "338:1: expression : ( ( left_value_assignment ASSIGNMENT )=>leftValue= left_value_assignment ASSIGNMENT rightConjunctiveExpression= conjunctive_expression | conjunctive_expression );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition1(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA1_1 = input.LA(1);


				int index1_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred1_Tiger_fragment)) ) {s = 12;}

				else if ( (true) ) {s = 2;}


				input.Seek(index1_1);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 1, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}

	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _expression_in_program1085 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_program1087 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _left_value_assignment_in_expression1111 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _ASSIGNMENT_in_expression1113 = new BitSet(new ulong[]{0x101106A20UL,0x1018UL});
		public static readonly BitSet _conjunctive_expression_in_expression1120 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _conjunctive_expression_in_expression1126 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _id_in_left_value_assignment1141 = new BitSet(new ulong[]{0x44000002UL});
		public static readonly BitSet _record_access_in_left_value_assignment1151 = new BitSet(new ulong[]{0x44000000UL});
		public static readonly BitSet _left_value_in_left_value_assignment1158 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _indexer_in_left_value_assignment1174 = new BitSet(new ulong[]{0x44000000UL});
		public static readonly BitSet _left_value_in_left_value_assignment1181 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _disjunctive_expression_in_conjunctive_expression1215 = new BitSet(new ulong[]{0x40000000002UL});
		public static readonly BitSet _OR_in_conjunctive_expression1218 = new BitSet(new ulong[]{0x101106A20UL,0x1018UL});
		public static readonly BitSet _disjunctive_expression_in_conjunctive_expression1225 = new BitSet(new ulong[]{0x40000000002UL});
		public static readonly BitSet _relational_expression_in_disjunctive_expression1242 = new BitSet(new ulong[]{0x20000000002UL});
		public static readonly BitSet _AND_in_disjunctive_expression1245 = new BitSet(new ulong[]{0x101106A20UL,0x1018UL});
		public static readonly BitSet _relational_expression_in_disjunctive_expression1252 = new BitSet(new ulong[]{0x20000000002UL});
		public static readonly BitSet _arithmetic_expression_in_relational_expression1268 = new BitSet(new ulong[]{0x1F800000002UL});
		public static readonly BitSet _EQUAL_in_relational_expression1271 = new BitSet(new ulong[]{0x101106A20UL,0x1018UL});
		public static readonly BitSet _NOT_EQUAL_in_relational_expression1276 = new BitSet(new ulong[]{0x101106A20UL,0x1018UL});
		public static readonly BitSet _LESS_THAN_in_relational_expression1281 = new BitSet(new ulong[]{0x101106A20UL,0x1018UL});
		public static readonly BitSet _LESS_EQUAL_THAN_in_relational_expression1286 = new BitSet(new ulong[]{0x101106A20UL,0x1018UL});
		public static readonly BitSet _GREATHER_THAN_in_relational_expression1291 = new BitSet(new ulong[]{0x101106A20UL,0x1018UL});
		public static readonly BitSet _GREATHER_EQUAL_THAN_in_relational_expression1296 = new BitSet(new ulong[]{0x101106A20UL,0x1018UL});
		public static readonly BitSet _arithmetic_expression_in_relational_expression1303 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _term_in_arithmetic_expression1320 = new BitSet(new ulong[]{0x180000002UL});
		public static readonly BitSet _PLUS_in_arithmetic_expression1324 = new BitSet(new ulong[]{0x101106A20UL,0x1018UL});
		public static readonly BitSet _MINUS_in_arithmetic_expression1329 = new BitSet(new ulong[]{0x101106A20UL,0x1018UL});
		public static readonly BitSet _term_in_arithmetic_expression1337 = new BitSet(new ulong[]{0x180000002UL});
		public static readonly BitSet _factor_in_term1353 = new BitSet(new ulong[]{0x600000002UL});
		public static readonly BitSet _MULTIPLICATION_in_term1357 = new BitSet(new ulong[]{0x101106A20UL,0x1018UL});
		public static readonly BitSet _DIVISION_in_term1362 = new BitSet(new ulong[]{0x101106A20UL,0x1018UL});
		public static readonly BitSet _factor_in_term1370 = new BitSet(new ulong[]{0x600000002UL});
		public static readonly BitSet _MINUS_in_factor1382 = new BitSet(new ulong[]{0x101106A20UL,0x1018UL});
		public static readonly BitSet _factor_in_factor1384 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _value_returner_in_factor1397 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _not_value_returner_in_factor1402 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _STRING_in_value_returner1413 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _INT_in_value_returner1418 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NIL_in_value_returner1423 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _id_in_value_returner1432 = new BitSet(new ulong[]{0x55000002UL});
		public static readonly BitSet _record_access_in_value_returner1442 = new BitSet(new ulong[]{0x44000000UL});
		public static readonly BitSet _left_value_in_value_returner1449 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _indexer_in_value_returner1465 = new BitSet(new ulong[]{0x44008000UL});
		public static readonly BitSet _OF_in_value_returner1470 = new BitSet(new ulong[]{0x101106A20UL,0x1018UL});
		public static readonly BitSet _expression_in_value_returner1472 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _left_value_in_value_returner1501 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _function_call_in_value_returner1527 = new BitSet(new ulong[]{0x44000000UL});
		public static readonly BitSet _left_value_in_value_returner1534 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _record_assignment_in_value_returner1550 = new BitSet(new ulong[]{0x40000002UL});
		public static readonly BitSet _record_access_in_value_returner1559 = new BitSet(new ulong[]{0x44000000UL});
		public static readonly BitSet _left_value_in_value_returner1566 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _tuple_expression_in_value_returner1623 = new BitSet(new ulong[]{0x44000000UL});
		public static readonly BitSet _left_value_in_value_returner1629 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _let_expression_in_value_returner1644 = new BitSet(new ulong[]{0x44000000UL});
		public static readonly BitSet _left_value_in_value_returner1650 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_id1666 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LEFT_PARENTHESIS_in_function_call1679 = new BitSet(new ulong[]{0x103106A20UL,0x1018UL});
		public static readonly BitSet _expression_list_in_function_call1681 = new BitSet(new ulong[]{0x2000000UL});
		public static readonly BitSet _RIGHT_PARENTHESIS_in_function_call1684 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LEFT_KEY_in_record_assignment1707 = new BitSet(new ulong[]{0x20000000UL,0x8UL});
		public static readonly BitSet _field_list_in_record_assignment1709 = new BitSet(new ulong[]{0x20000000UL});
		public static readonly BitSet _RIGHT_KEY_in_record_assignment1712 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _DOT_in_record_access1735 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _ID_in_record_access1741 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LEFT_BRACKET_in_indexer1768 = new BitSet(new ulong[]{0x101106A20UL,0x1018UL});
		public static readonly BitSet _expression_in_indexer1774 = new BitSet(new ulong[]{0x8000000UL});
		public static readonly BitSet _RIGHT_BRACKET_in_indexer1776 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _record_access_in_left_value1807 = new BitSet(new ulong[]{0x44000000UL});
		public static readonly BitSet _left_value_in_left_value1814 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _indexer_in_left_value1825 = new BitSet(new ulong[]{0x44000000UL});
		public static readonly BitSet _left_value_in_left_value1832 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _BREAK_in_not_value_returner1860 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _control_expression_in_not_value_returner1865 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LEFT_PARENTHESIS_in_tuple_expression1876 = new BitSet(new ulong[]{0x103106A20UL,0x1018UL});
		public static readonly BitSet _expression_sequence_in_tuple_expression1878 = new BitSet(new ulong[]{0x2000000UL});
		public static readonly BitSet _RIGHT_PARENTHESIS_in_tuple_expression1881 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _if_expression_in_control_expression1901 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _while_expression_in_control_expression1906 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _for_expression_in_control_expression1911 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_if_expression1922 = new BitSet(new ulong[]{0x101106A20UL,0x1018UL});
		public static readonly BitSet _expression_in_if_expression1928 = new BitSet(new ulong[]{0x10000UL});
		public static readonly BitSet _THEN_in_if_expression1930 = new BitSet(new ulong[]{0x101106A20UL,0x1018UL});
		public static readonly BitSet _expression_in_if_expression1936 = new BitSet(new ulong[]{0x82UL});
		public static readonly BitSet _ELSE_in_if_expression1945 = new BitSet(new ulong[]{0x101106A20UL,0x1018UL});
		public static readonly BitSet _expression_in_if_expression1951 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WHILE_in_while_expression2010 = new BitSet(new ulong[]{0x101106A20UL,0x1018UL});
		public static readonly BitSet _expression_in_while_expression2016 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _DO_in_while_expression2018 = new BitSet(new ulong[]{0x101106A20UL,0x1018UL});
		public static readonly BitSet _expression_in_while_expression2024 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_for_expression2047 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _ID_in_for_expression2049 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _ASSIGNMENT_in_for_expression2051 = new BitSet(new ulong[]{0x101106A20UL,0x1018UL});
		public static readonly BitSet _expression_in_for_expression2057 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _TO_in_for_expression2059 = new BitSet(new ulong[]{0x101106A20UL,0x1018UL});
		public static readonly BitSet _expression_in_for_expression2065 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _DO_in_for_expression2067 = new BitSet(new ulong[]{0x101106A20UL,0x1018UL});
		public static readonly BitSet _expression_in_for_expression2073 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LET_in_let_expression2101 = new BitSet(new ulong[]{0xC0400UL});
		public static readonly BitSet _declaration_list_in_let_expression2103 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _IN_in_let_expression2105 = new BitSet(new ulong[]{0x101106B20UL,0x1018UL});
		public static readonly BitSet _expression_sequence_in_let_expression2107 = new BitSet(new ulong[]{0x100UL});
		public static readonly BitSet _END_in_let_expression2110 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_expression_sequence2132 = new BitSet(new ulong[]{0x800002UL});
		public static readonly BitSet _SEMICOLON_in_expression_sequence2135 = new BitSet(new ulong[]{0x101106A20UL,0x1018UL});
		public static readonly BitSet _expression_in_expression_sequence2137 = new BitSet(new ulong[]{0x800002UL});
		public static readonly BitSet _expression_in_expression_list2159 = new BitSet(new ulong[]{0x200002UL});
		public static readonly BitSet _COMMA_in_expression_list2162 = new BitSet(new ulong[]{0x101106A20UL,0x1018UL});
		public static readonly BitSet _expression_in_expression_list2164 = new BitSet(new ulong[]{0x200002UL});
		public static readonly BitSet _field_in_field_list2186 = new BitSet(new ulong[]{0x200002UL});
		public static readonly BitSet _COMMA_in_field_list2189 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _field_in_field_list2191 = new BitSet(new ulong[]{0x200002UL});
		public static readonly BitSet _ID_in_field2212 = new BitSet(new ulong[]{0x800000000UL});
		public static readonly BitSet _EQUAL_in_field2214 = new BitSet(new ulong[]{0x101106A20UL,0x1018UL});
		public static readonly BitSet _expression_in_field2216 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declaration_in_declaration_list2237 = new BitSet(new ulong[]{0xC0402UL});
		public static readonly BitSet _type_declaration_in_declaration2258 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _variable_declaration_in_declaration2263 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _function_declaration_in_declaration2268 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_type_declaration2279 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _ID_in_type_declaration2285 = new BitSet(new ulong[]{0x800000000UL});
		public static readonly BitSet _EQUAL_in_type_declaration2287 = new BitSet(new ulong[]{0x10000010UL,0x8UL});
		public static readonly BitSet _ID_in_type_declaration2295 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LEFT_KEY_in_type_declaration2322 = new BitSet(new ulong[]{0x20000000UL,0x8UL});
		public static readonly BitSet _type_fields_in_type_declaration2324 = new BitSet(new ulong[]{0x20000000UL});
		public static readonly BitSet _RIGHT_KEY_in_type_declaration2327 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ARRAY_in_type_declaration2354 = new BitSet(new ulong[]{0x8000UL});
		public static readonly BitSet _OF_in_type_declaration2356 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _ID_in_type_declaration2362 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_field_in_type_fields2386 = new BitSet(new ulong[]{0x200002UL});
		public static readonly BitSet _COMMA_in_type_fields2389 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _type_field_in_type_fields2391 = new BitSet(new ulong[]{0x200002UL});
		public static readonly BitSet _ID_in_type_field2417 = new BitSet(new ulong[]{0x400000UL});
		public static readonly BitSet _COLON_in_type_field2419 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _ID_in_type_field2425 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _VAR_in_variable_declaration2448 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _ID_in_variable_declaration2454 = new BitSet(new ulong[]{0x80000400000UL});
		public static readonly BitSet _ASSIGNMENT_in_variable_declaration2458 = new BitSet(new ulong[]{0x101106A20UL,0x1018UL});
		public static readonly BitSet _expression_in_variable_declaration2460 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _COLON_in_variable_declaration2483 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _ID_in_variable_declaration2489 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _ASSIGNMENT_in_variable_declaration2491 = new BitSet(new ulong[]{0x101106A20UL,0x1018UL});
		public static readonly BitSet _expression_in_variable_declaration2493 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FUNCTION_in_function_declaration2519 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _ID_in_function_declaration2525 = new BitSet(new ulong[]{0x1000000UL});
		public static readonly BitSet _LEFT_PARENTHESIS_in_function_declaration2527 = new BitSet(new ulong[]{0x2000000UL,0x8UL});
		public static readonly BitSet _type_fields_in_function_declaration2529 = new BitSet(new ulong[]{0x2000000UL});
		public static readonly BitSet _RIGHT_PARENTHESIS_in_function_declaration2532 = new BitSet(new ulong[]{0x800400000UL});
		public static readonly BitSet _EQUAL_in_function_declaration2536 = new BitSet(new ulong[]{0x101106A20UL,0x1018UL});
		public static readonly BitSet _expression_in_function_declaration2538 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _COLON_in_function_declaration2568 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _ID_in_function_declaration2574 = new BitSet(new ulong[]{0x800000000UL});
		public static readonly BitSet _EQUAL_in_function_declaration2576 = new BitSet(new ulong[]{0x101106A20UL,0x1018UL});
		public static readonly BitSet _expression_in_function_declaration2578 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _left_value_assignment_in_synpred1_Tiger1100 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _ASSIGNMENT_in_synpred1_Tiger1102 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ELSE_in_synpred2_Tiger1940 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}
