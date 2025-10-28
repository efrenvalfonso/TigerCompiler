// $ANTLR 3.3 Nov 30, 2010 12:45:30 C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g 2010-01-12 16:32:04

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

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:45:30")]
[System.CLSCompliant(false)]
public partial class TigerLexer : Antlr.Runtime.Lexer
{
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

		public List<Error> Errors = new List<Error>();

		public override string GetErrorMessage(RecognitionException e, string[] tokenNames)
		{
		    string message = string.Format("Unexpected character {0}.", GetCharErrorDisplay(e.Character));
		    
		    if (e is MismatchedTokenException)
		    {
		        var mismatchedTokenException = (MismatchedTokenException) e;
		        message = string.Format("Unexpected character {0}. {1} expected.", GetCharErrorDisplay(e.Character),
		                                GetCharErrorDisplay(mismatchedTokenException.Expecting));
		    }
		    
		    if (e is MismatchedRangeException)
		    {
		        var mismatchedRangeException = (MismatchedRangeException) e;
		        message = string.Format("Unexpected character {0}. {1}..{2} expected.",
		                                GetCharErrorDisplay(mismatchedRangeException.Character),
		                                GetCharErrorDisplay(mismatchedRangeException.A),
		                                GetCharErrorDisplay(mismatchedRangeException.B));
		    }
		    if(e is MismatchedSetException)
		    {
		    	var mismatchedSetException = (MismatchedSetException) e;
		        message = string.Format("Unexpected token {0}. {1} expected.",
		                                GetTokenErrorDisplay(e.Token),
		                                mismatchedSetException.Expecting);
		    }
		    	
		    
		    	
		    Errors.Add(new Error(message, e.Line, e.CharPositionInLine));
		    return message;
		}


    // delegates
    // delegators

	public TigerLexer()
	{
		OnCreated();
	}

	public TigerLexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public TigerLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{


		OnCreated();
	}
	public override string GrammarFileName { get { return "C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g"; } }

	private static readonly bool[] decisionCanBacktrack = new bool[0];


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void Enter_ARRAY();
	partial void Leave_ARRAY();

	// $ANTLR start "ARRAY"
	[GrammarRule("ARRAY")]
	private void mARRAY()
	{
		Enter_ARRAY();
		EnterRule("ARRAY", 1);
		TraceIn("ARRAY", 1);
		try
		{
			int _type = ARRAY;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:47:7: ( 'array' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:47:9: 'array'
			{
			DebugLocation(47, 9);
			Match("array"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ARRAY", 1);
			LeaveRule("ARRAY", 1);
			Leave_ARRAY();
		}
	}
	// $ANTLR end "ARRAY"

	partial void Enter_BREAK();
	partial void Leave_BREAK();

	// $ANTLR start "BREAK"
	[GrammarRule("BREAK")]
	private void mBREAK()
	{
		Enter_BREAK();
		EnterRule("BREAK", 2);
		TraceIn("BREAK", 2);
		try
		{
			int _type = BREAK;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:48:7: ( 'break' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:48:9: 'break'
			{
			DebugLocation(48, 9);
			Match("break"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("BREAK", 2);
			LeaveRule("BREAK", 2);
			Leave_BREAK();
		}
	}
	// $ANTLR end "BREAK"

	partial void Enter_DO();
	partial void Leave_DO();

	// $ANTLR start "DO"
	[GrammarRule("DO")]
	private void mDO()
	{
		Enter_DO();
		EnterRule("DO", 3);
		TraceIn("DO", 3);
		try
		{
			int _type = DO;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:49:4: ( 'do' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:49:6: 'do'
			{
			DebugLocation(49, 6);
			Match("do"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DO", 3);
			LeaveRule("DO", 3);
			Leave_DO();
		}
	}
	// $ANTLR end "DO"

	partial void Enter_ELSE();
	partial void Leave_ELSE();

	// $ANTLR start "ELSE"
	[GrammarRule("ELSE")]
	private void mELSE()
	{
		Enter_ELSE();
		EnterRule("ELSE", 4);
		TraceIn("ELSE", 4);
		try
		{
			int _type = ELSE;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:50:6: ( 'else' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:50:8: 'else'
			{
			DebugLocation(50, 8);
			Match("else"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ELSE", 4);
			LeaveRule("ELSE", 4);
			Leave_ELSE();
		}
	}
	// $ANTLR end "ELSE"

	partial void Enter_END();
	partial void Leave_END();

	// $ANTLR start "END"
	[GrammarRule("END")]
	private void mEND()
	{
		Enter_END();
		EnterRule("END", 5);
		TraceIn("END", 5);
		try
		{
			int _type = END;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:51:5: ( 'end' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:51:7: 'end'
			{
			DebugLocation(51, 7);
			Match("end"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("END", 5);
			LeaveRule("END", 5);
			Leave_END();
		}
	}
	// $ANTLR end "END"

	partial void Enter_FOR();
	partial void Leave_FOR();

	// $ANTLR start "FOR"
	[GrammarRule("FOR")]
	private void mFOR()
	{
		Enter_FOR();
		EnterRule("FOR", 6);
		TraceIn("FOR", 6);
		try
		{
			int _type = FOR;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:52:5: ( 'for' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:52:7: 'for'
			{
			DebugLocation(52, 7);
			Match("for"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FOR", 6);
			LeaveRule("FOR", 6);
			Leave_FOR();
		}
	}
	// $ANTLR end "FOR"

	partial void Enter_FUNCTION();
	partial void Leave_FUNCTION();

	// $ANTLR start "FUNCTION"
	[GrammarRule("FUNCTION")]
	private void mFUNCTION()
	{
		Enter_FUNCTION();
		EnterRule("FUNCTION", 7);
		TraceIn("FUNCTION", 7);
		try
		{
			int _type = FUNCTION;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:53:10: ( 'function' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:53:12: 'function'
			{
			DebugLocation(53, 12);
			Match("function"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FUNCTION", 7);
			LeaveRule("FUNCTION", 7);
			Leave_FUNCTION();
		}
	}
	// $ANTLR end "FUNCTION"

	partial void Enter_IF();
	partial void Leave_IF();

	// $ANTLR start "IF"
	[GrammarRule("IF")]
	private void mIF()
	{
		Enter_IF();
		EnterRule("IF", 8);
		TraceIn("IF", 8);
		try
		{
			int _type = IF;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:54:4: ( 'if' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:54:6: 'if'
			{
			DebugLocation(54, 6);
			Match("if"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IF", 8);
			LeaveRule("IF", 8);
			Leave_IF();
		}
	}
	// $ANTLR end "IF"

	partial void Enter_IN();
	partial void Leave_IN();

	// $ANTLR start "IN"
	[GrammarRule("IN")]
	private void mIN()
	{
		Enter_IN();
		EnterRule("IN", 9);
		TraceIn("IN", 9);
		try
		{
			int _type = IN;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:55:4: ( 'in' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:55:6: 'in'
			{
			DebugLocation(55, 6);
			Match("in"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IN", 9);
			LeaveRule("IN", 9);
			Leave_IN();
		}
	}
	// $ANTLR end "IN"

	partial void Enter_LET();
	partial void Leave_LET();

	// $ANTLR start "LET"
	[GrammarRule("LET")]
	private void mLET()
	{
		Enter_LET();
		EnterRule("LET", 10);
		TraceIn("LET", 10);
		try
		{
			int _type = LET;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:56:5: ( 'let' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:56:7: 'let'
			{
			DebugLocation(56, 7);
			Match("let"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LET", 10);
			LeaveRule("LET", 10);
			Leave_LET();
		}
	}
	// $ANTLR end "LET"

	partial void Enter_NIL();
	partial void Leave_NIL();

	// $ANTLR start "NIL"
	[GrammarRule("NIL")]
	private void mNIL()
	{
		Enter_NIL();
		EnterRule("NIL", 11);
		TraceIn("NIL", 11);
		try
		{
			int _type = NIL;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:57:5: ( 'nil' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:57:7: 'nil'
			{
			DebugLocation(57, 7);
			Match("nil"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NIL", 11);
			LeaveRule("NIL", 11);
			Leave_NIL();
		}
	}
	// $ANTLR end "NIL"

	partial void Enter_OF();
	partial void Leave_OF();

	// $ANTLR start "OF"
	[GrammarRule("OF")]
	private void mOF()
	{
		Enter_OF();
		EnterRule("OF", 12);
		TraceIn("OF", 12);
		try
		{
			int _type = OF;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:58:4: ( 'of' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:58:6: 'of'
			{
			DebugLocation(58, 6);
			Match("of"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OF", 12);
			LeaveRule("OF", 12);
			Leave_OF();
		}
	}
	// $ANTLR end "OF"

	partial void Enter_THEN();
	partial void Leave_THEN();

	// $ANTLR start "THEN"
	[GrammarRule("THEN")]
	private void mTHEN()
	{
		Enter_THEN();
		EnterRule("THEN", 13);
		TraceIn("THEN", 13);
		try
		{
			int _type = THEN;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:59:6: ( 'then' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:59:8: 'then'
			{
			DebugLocation(59, 8);
			Match("then"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("THEN", 13);
			LeaveRule("THEN", 13);
			Leave_THEN();
		}
	}
	// $ANTLR end "THEN"

	partial void Enter_TO();
	partial void Leave_TO();

	// $ANTLR start "TO"
	[GrammarRule("TO")]
	private void mTO()
	{
		Enter_TO();
		EnterRule("TO", 14);
		TraceIn("TO", 14);
		try
		{
			int _type = TO;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:60:4: ( 'to' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:60:6: 'to'
			{
			DebugLocation(60, 6);
			Match("to"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TO", 14);
			LeaveRule("TO", 14);
			Leave_TO();
		}
	}
	// $ANTLR end "TO"

	partial void Enter_TYPE();
	partial void Leave_TYPE();

	// $ANTLR start "TYPE"
	[GrammarRule("TYPE")]
	private void mTYPE()
	{
		Enter_TYPE();
		EnterRule("TYPE", 15);
		TraceIn("TYPE", 15);
		try
		{
			int _type = TYPE;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:61:6: ( 'type' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:61:8: 'type'
			{
			DebugLocation(61, 8);
			Match("type"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TYPE", 15);
			LeaveRule("TYPE", 15);
			Leave_TYPE();
		}
	}
	// $ANTLR end "TYPE"

	partial void Enter_VAR();
	partial void Leave_VAR();

	// $ANTLR start "VAR"
	[GrammarRule("VAR")]
	private void mVAR()
	{
		Enter_VAR();
		EnterRule("VAR", 16);
		TraceIn("VAR", 16);
		try
		{
			int _type = VAR;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:62:5: ( 'var' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:62:7: 'var'
			{
			DebugLocation(62, 7);
			Match("var"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("VAR", 16);
			LeaveRule("VAR", 16);
			Leave_VAR();
		}
	}
	// $ANTLR end "VAR"

	partial void Enter_WHILE();
	partial void Leave_WHILE();

	// $ANTLR start "WHILE"
	[GrammarRule("WHILE")]
	private void mWHILE()
	{
		Enter_WHILE();
		EnterRule("WHILE", 17);
		TraceIn("WHILE", 17);
		try
		{
			int _type = WHILE;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:63:7: ( 'while' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:63:9: 'while'
			{
			DebugLocation(63, 9);
			Match("while"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WHILE", 17);
			LeaveRule("WHILE", 17);
			Leave_WHILE();
		}
	}
	// $ANTLR end "WHILE"

	partial void Enter_COMMA();
	partial void Leave_COMMA();

	// $ANTLR start "COMMA"
	[GrammarRule("COMMA")]
	private void mCOMMA()
	{
		Enter_COMMA();
		EnterRule("COMMA", 18);
		TraceIn("COMMA", 18);
		try
		{
			int _type = COMMA;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:64:7: ( ',' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:64:9: ','
			{
			DebugLocation(64, 9);
			Match(','); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("COMMA", 18);
			LeaveRule("COMMA", 18);
			Leave_COMMA();
		}
	}
	// $ANTLR end "COMMA"

	partial void Enter_COLON();
	partial void Leave_COLON();

	// $ANTLR start "COLON"
	[GrammarRule("COLON")]
	private void mCOLON()
	{
		Enter_COLON();
		EnterRule("COLON", 19);
		TraceIn("COLON", 19);
		try
		{
			int _type = COLON;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:65:7: ( ':' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:65:9: ':'
			{
			DebugLocation(65, 9);
			Match(':'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("COLON", 19);
			LeaveRule("COLON", 19);
			Leave_COLON();
		}
	}
	// $ANTLR end "COLON"

	partial void Enter_SEMICOLON();
	partial void Leave_SEMICOLON();

	// $ANTLR start "SEMICOLON"
	[GrammarRule("SEMICOLON")]
	private void mSEMICOLON()
	{
		Enter_SEMICOLON();
		EnterRule("SEMICOLON", 20);
		TraceIn("SEMICOLON", 20);
		try
		{
			int _type = SEMICOLON;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:66:11: ( ';' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:66:13: ';'
			{
			DebugLocation(66, 13);
			Match(';'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SEMICOLON", 20);
			LeaveRule("SEMICOLON", 20);
			Leave_SEMICOLON();
		}
	}
	// $ANTLR end "SEMICOLON"

	partial void Enter_LEFT_PARENTHESIS();
	partial void Leave_LEFT_PARENTHESIS();

	// $ANTLR start "LEFT_PARENTHESIS"
	[GrammarRule("LEFT_PARENTHESIS")]
	private void mLEFT_PARENTHESIS()
	{
		Enter_LEFT_PARENTHESIS();
		EnterRule("LEFT_PARENTHESIS", 21);
		TraceIn("LEFT_PARENTHESIS", 21);
		try
		{
			int _type = LEFT_PARENTHESIS;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:67:18: ( '(' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:67:20: '('
			{
			DebugLocation(67, 20);
			Match('('); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LEFT_PARENTHESIS", 21);
			LeaveRule("LEFT_PARENTHESIS", 21);
			Leave_LEFT_PARENTHESIS();
		}
	}
	// $ANTLR end "LEFT_PARENTHESIS"

	partial void Enter_RIGHT_PARENTHESIS();
	partial void Leave_RIGHT_PARENTHESIS();

	// $ANTLR start "RIGHT_PARENTHESIS"
	[GrammarRule("RIGHT_PARENTHESIS")]
	private void mRIGHT_PARENTHESIS()
	{
		Enter_RIGHT_PARENTHESIS();
		EnterRule("RIGHT_PARENTHESIS", 22);
		TraceIn("RIGHT_PARENTHESIS", 22);
		try
		{
			int _type = RIGHT_PARENTHESIS;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:68:19: ( ')' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:68:21: ')'
			{
			DebugLocation(68, 21);
			Match(')'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("RIGHT_PARENTHESIS", 22);
			LeaveRule("RIGHT_PARENTHESIS", 22);
			Leave_RIGHT_PARENTHESIS();
		}
	}
	// $ANTLR end "RIGHT_PARENTHESIS"

	partial void Enter_LEFT_BRACKET();
	partial void Leave_LEFT_BRACKET();

	// $ANTLR start "LEFT_BRACKET"
	[GrammarRule("LEFT_BRACKET")]
	private void mLEFT_BRACKET()
	{
		Enter_LEFT_BRACKET();
		EnterRule("LEFT_BRACKET", 23);
		TraceIn("LEFT_BRACKET", 23);
		try
		{
			int _type = LEFT_BRACKET;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:69:14: ( '[' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:69:16: '['
			{
			DebugLocation(69, 16);
			Match('['); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LEFT_BRACKET", 23);
			LeaveRule("LEFT_BRACKET", 23);
			Leave_LEFT_BRACKET();
		}
	}
	// $ANTLR end "LEFT_BRACKET"

	partial void Enter_RIGHT_BRACKET();
	partial void Leave_RIGHT_BRACKET();

	// $ANTLR start "RIGHT_BRACKET"
	[GrammarRule("RIGHT_BRACKET")]
	private void mRIGHT_BRACKET()
	{
		Enter_RIGHT_BRACKET();
		EnterRule("RIGHT_BRACKET", 24);
		TraceIn("RIGHT_BRACKET", 24);
		try
		{
			int _type = RIGHT_BRACKET;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:70:15: ( ']' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:70:17: ']'
			{
			DebugLocation(70, 17);
			Match(']'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("RIGHT_BRACKET", 24);
			LeaveRule("RIGHT_BRACKET", 24);
			Leave_RIGHT_BRACKET();
		}
	}
	// $ANTLR end "RIGHT_BRACKET"

	partial void Enter_LEFT_KEY();
	partial void Leave_LEFT_KEY();

	// $ANTLR start "LEFT_KEY"
	[GrammarRule("LEFT_KEY")]
	private void mLEFT_KEY()
	{
		Enter_LEFT_KEY();
		EnterRule("LEFT_KEY", 25);
		TraceIn("LEFT_KEY", 25);
		try
		{
			int _type = LEFT_KEY;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:71:10: ( '{' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:71:12: '{'
			{
			DebugLocation(71, 12);
			Match('{'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LEFT_KEY", 25);
			LeaveRule("LEFT_KEY", 25);
			Leave_LEFT_KEY();
		}
	}
	// $ANTLR end "LEFT_KEY"

	partial void Enter_RIGHT_KEY();
	partial void Leave_RIGHT_KEY();

	// $ANTLR start "RIGHT_KEY"
	[GrammarRule("RIGHT_KEY")]
	private void mRIGHT_KEY()
	{
		Enter_RIGHT_KEY();
		EnterRule("RIGHT_KEY", 26);
		TraceIn("RIGHT_KEY", 26);
		try
		{
			int _type = RIGHT_KEY;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:72:11: ( '}' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:72:13: '}'
			{
			DebugLocation(72, 13);
			Match('}'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("RIGHT_KEY", 26);
			LeaveRule("RIGHT_KEY", 26);
			Leave_RIGHT_KEY();
		}
	}
	// $ANTLR end "RIGHT_KEY"

	partial void Enter_DOT();
	partial void Leave_DOT();

	// $ANTLR start "DOT"
	[GrammarRule("DOT")]
	private void mDOT()
	{
		Enter_DOT();
		EnterRule("DOT", 27);
		TraceIn("DOT", 27);
		try
		{
			int _type = DOT;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:73:5: ( '.' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:73:7: '.'
			{
			DebugLocation(73, 7);
			Match('.'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DOT", 27);
			LeaveRule("DOT", 27);
			Leave_DOT();
		}
	}
	// $ANTLR end "DOT"

	partial void Enter_PLUS();
	partial void Leave_PLUS();

	// $ANTLR start "PLUS"
	[GrammarRule("PLUS")]
	private void mPLUS()
	{
		Enter_PLUS();
		EnterRule("PLUS", 28);
		TraceIn("PLUS", 28);
		try
		{
			int _type = PLUS;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:74:6: ( '+' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:74:8: '+'
			{
			DebugLocation(74, 8);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PLUS", 28);
			LeaveRule("PLUS", 28);
			Leave_PLUS();
		}
	}
	// $ANTLR end "PLUS"

	partial void Enter_MINUS();
	partial void Leave_MINUS();

	// $ANTLR start "MINUS"
	[GrammarRule("MINUS")]
	private void mMINUS()
	{
		Enter_MINUS();
		EnterRule("MINUS", 29);
		TraceIn("MINUS", 29);
		try
		{
			int _type = MINUS;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:75:7: ( '-' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:75:9: '-'
			{
			DebugLocation(75, 9);
			Match('-'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MINUS", 29);
			LeaveRule("MINUS", 29);
			Leave_MINUS();
		}
	}
	// $ANTLR end "MINUS"

	partial void Enter_MULTIPLICATION();
	partial void Leave_MULTIPLICATION();

	// $ANTLR start "MULTIPLICATION"
	[GrammarRule("MULTIPLICATION")]
	private void mMULTIPLICATION()
	{
		Enter_MULTIPLICATION();
		EnterRule("MULTIPLICATION", 30);
		TraceIn("MULTIPLICATION", 30);
		try
		{
			int _type = MULTIPLICATION;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:76:16: ( '*' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:76:18: '*'
			{
			DebugLocation(76, 18);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MULTIPLICATION", 30);
			LeaveRule("MULTIPLICATION", 30);
			Leave_MULTIPLICATION();
		}
	}
	// $ANTLR end "MULTIPLICATION"

	partial void Enter_DIVISION();
	partial void Leave_DIVISION();

	// $ANTLR start "DIVISION"
	[GrammarRule("DIVISION")]
	private void mDIVISION()
	{
		Enter_DIVISION();
		EnterRule("DIVISION", 31);
		TraceIn("DIVISION", 31);
		try
		{
			int _type = DIVISION;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:77:10: ( '/' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:77:12: '/'
			{
			DebugLocation(77, 12);
			Match('/'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DIVISION", 31);
			LeaveRule("DIVISION", 31);
			Leave_DIVISION();
		}
	}
	// $ANTLR end "DIVISION"

	partial void Enter_EQUAL();
	partial void Leave_EQUAL();

	// $ANTLR start "EQUAL"
	[GrammarRule("EQUAL")]
	private void mEQUAL()
	{
		Enter_EQUAL();
		EnterRule("EQUAL", 32);
		TraceIn("EQUAL", 32);
		try
		{
			int _type = EQUAL;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:78:7: ( '=' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:78:9: '='
			{
			DebugLocation(78, 9);
			Match('='); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EQUAL", 32);
			LeaveRule("EQUAL", 32);
			Leave_EQUAL();
		}
	}
	// $ANTLR end "EQUAL"

	partial void Enter_NOT_EQUAL();
	partial void Leave_NOT_EQUAL();

	// $ANTLR start "NOT_EQUAL"
	[GrammarRule("NOT_EQUAL")]
	private void mNOT_EQUAL()
	{
		Enter_NOT_EQUAL();
		EnterRule("NOT_EQUAL", 33);
		TraceIn("NOT_EQUAL", 33);
		try
		{
			int _type = NOT_EQUAL;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:79:11: ( '<>' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:79:13: '<>'
			{
			DebugLocation(79, 13);
			Match("<>"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NOT_EQUAL", 33);
			LeaveRule("NOT_EQUAL", 33);
			Leave_NOT_EQUAL();
		}
	}
	// $ANTLR end "NOT_EQUAL"

	partial void Enter_LESS_THAN();
	partial void Leave_LESS_THAN();

	// $ANTLR start "LESS_THAN"
	[GrammarRule("LESS_THAN")]
	private void mLESS_THAN()
	{
		Enter_LESS_THAN();
		EnterRule("LESS_THAN", 34);
		TraceIn("LESS_THAN", 34);
		try
		{
			int _type = LESS_THAN;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:80:11: ( '<' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:80:13: '<'
			{
			DebugLocation(80, 13);
			Match('<'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LESS_THAN", 34);
			LeaveRule("LESS_THAN", 34);
			Leave_LESS_THAN();
		}
	}
	// $ANTLR end "LESS_THAN"

	partial void Enter_LESS_EQUAL_THAN();
	partial void Leave_LESS_EQUAL_THAN();

	// $ANTLR start "LESS_EQUAL_THAN"
	[GrammarRule("LESS_EQUAL_THAN")]
	private void mLESS_EQUAL_THAN()
	{
		Enter_LESS_EQUAL_THAN();
		EnterRule("LESS_EQUAL_THAN", 35);
		TraceIn("LESS_EQUAL_THAN", 35);
		try
		{
			int _type = LESS_EQUAL_THAN;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:81:17: ( '<=' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:81:19: '<='
			{
			DebugLocation(81, 19);
			Match("<="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LESS_EQUAL_THAN", 35);
			LeaveRule("LESS_EQUAL_THAN", 35);
			Leave_LESS_EQUAL_THAN();
		}
	}
	// $ANTLR end "LESS_EQUAL_THAN"

	partial void Enter_GREATHER_THAN();
	partial void Leave_GREATHER_THAN();

	// $ANTLR start "GREATHER_THAN"
	[GrammarRule("GREATHER_THAN")]
	private void mGREATHER_THAN()
	{
		Enter_GREATHER_THAN();
		EnterRule("GREATHER_THAN", 36);
		TraceIn("GREATHER_THAN", 36);
		try
		{
			int _type = GREATHER_THAN;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:82:15: ( '>' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:82:17: '>'
			{
			DebugLocation(82, 17);
			Match('>'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GREATHER_THAN", 36);
			LeaveRule("GREATHER_THAN", 36);
			Leave_GREATHER_THAN();
		}
	}
	// $ANTLR end "GREATHER_THAN"

	partial void Enter_GREATHER_EQUAL_THAN();
	partial void Leave_GREATHER_EQUAL_THAN();

	// $ANTLR start "GREATHER_EQUAL_THAN"
	[GrammarRule("GREATHER_EQUAL_THAN")]
	private void mGREATHER_EQUAL_THAN()
	{
		Enter_GREATHER_EQUAL_THAN();
		EnterRule("GREATHER_EQUAL_THAN", 37);
		TraceIn("GREATHER_EQUAL_THAN", 37);
		try
		{
			int _type = GREATHER_EQUAL_THAN;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:83:21: ( '>=' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:83:23: '>='
			{
			DebugLocation(83, 23);
			Match(">="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GREATHER_EQUAL_THAN", 37);
			LeaveRule("GREATHER_EQUAL_THAN", 37);
			Leave_GREATHER_EQUAL_THAN();
		}
	}
	// $ANTLR end "GREATHER_EQUAL_THAN"

	partial void Enter_AND();
	partial void Leave_AND();

	// $ANTLR start "AND"
	[GrammarRule("AND")]
	private void mAND()
	{
		Enter_AND();
		EnterRule("AND", 38);
		TraceIn("AND", 38);
		try
		{
			int _type = AND;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:84:5: ( '&' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:84:7: '&'
			{
			DebugLocation(84, 7);
			Match('&'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("AND", 38);
			LeaveRule("AND", 38);
			Leave_AND();
		}
	}
	// $ANTLR end "AND"

	partial void Enter_OR();
	partial void Leave_OR();

	// $ANTLR start "OR"
	[GrammarRule("OR")]
	private void mOR()
	{
		Enter_OR();
		EnterRule("OR", 39);
		TraceIn("OR", 39);
		try
		{
			int _type = OR;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:85:4: ( '|' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:85:6: '|'
			{
			DebugLocation(85, 6);
			Match('|'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OR", 39);
			LeaveRule("OR", 39);
			Leave_OR();
		}
	}
	// $ANTLR end "OR"

	partial void Enter_ASSIGNMENT();
	partial void Leave_ASSIGNMENT();

	// $ANTLR start "ASSIGNMENT"
	[GrammarRule("ASSIGNMENT")]
	private void mASSIGNMENT()
	{
		Enter_ASSIGNMENT();
		EnterRule("ASSIGNMENT", 40);
		TraceIn("ASSIGNMENT", 40);
		try
		{
			int _type = ASSIGNMENT;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:86:12: ( ':=' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:86:14: ':='
			{
			DebugLocation(86, 14);
			Match(":="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ASSIGNMENT", 40);
			LeaveRule("ASSIGNMENT", 40);
			Leave_ASSIGNMENT();
		}
	}
	// $ANTLR end "ASSIGNMENT"

	partial void Enter_ID();
	partial void Leave_ID();

	// $ANTLR start "ID"
	[GrammarRule("ID")]
	private void mID()
	{
		Enter_ID();
		EnterRule("ID", 41);
		TraceIn("ID", 41);
		try
		{
			int _type = ID;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:280:4: ( LETTER ( LETTER | DIGIT | '_' )* )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:280:6: LETTER ( LETTER | DIGIT | '_' )*
			{
			DebugLocation(280, 6);
			mLETTER(); 
			DebugLocation(280, 13);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:280:13: ( LETTER | DIGIT | '_' )*
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, decisionCanBacktrack[1]);
				int LA1_0 = input.LA(1);

				if (((LA1_0>='0' && LA1_0<='9')||(LA1_0>='A' && LA1_0<='Z')||LA1_0=='_'||(LA1_0>='a' && LA1_0<='z')))
				{
					alt1=1;
				}


				} finally { DebugExitDecision(1); }
				switch ( alt1 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:
					{
					DebugLocation(280, 13);
					if ((input.LA(1)>='0' && input.LA(1)<='9')||(input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z'))
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				default:
					goto loop1;
				}
			}

			loop1:
				;

			} finally { DebugExitSubRule(1); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ID", 41);
			LeaveRule("ID", 41);
			Leave_ID();
		}
	}
	// $ANTLR end "ID"

	partial void Enter_INT();
	partial void Leave_INT();

	// $ANTLR start "INT"
	[GrammarRule("INT")]
	private void mINT()
	{
		Enter_INT();
		EnterRule("INT", 42);
		TraceIn("INT", 42);
		try
		{
			int _type = INT;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:283:5: ( ( DIGIT )+ )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:283:7: ( DIGIT )+
			{
			DebugLocation(283, 7);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:283:7: ( DIGIT )+
			int cnt2=0;
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
				int LA2_0 = input.LA(1);

				if (((LA2_0>='0' && LA2_0<='9')))
				{
					alt2=1;
				}


				} finally { DebugExitDecision(2); }
				switch (alt2)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:283:7: DIGIT
					{
					DebugLocation(283, 7);
					mDIGIT(); 

					}
					break;

				default:
					if (cnt2 >= 1)
						goto loop2;

					EarlyExitException eee2 = new EarlyExitException( 2, input );
					DebugRecognitionException(eee2);
					throw eee2;
				}
				cnt2++;
			}
			loop2:
				;

			} finally { DebugExitSubRule(2); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("INT", 42);
			LeaveRule("INT", 42);
			Leave_INT();
		}
	}
	// $ANTLR end "INT"

	partial void Enter_LETTER();
	partial void Leave_LETTER();

	// $ANTLR start "LETTER"
	[GrammarRule("LETTER")]
	private void mLETTER()
	{
		Enter_LETTER();
		EnterRule("LETTER", 43);
		TraceIn("LETTER", 43);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:287:2: ( 'a' .. 'z' | 'A' .. 'Z' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:
			{
			DebugLocation(287, 2);
			if ((input.LA(1)>='A' && input.LA(1)<='Z')||(input.LA(1)>='a' && input.LA(1)<='z'))
			{
				input.Consume();

			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;}


			}

		}
		finally
		{
			TraceOut("LETTER", 43);
			LeaveRule("LETTER", 43);
			Leave_LETTER();
		}
	}
	// $ANTLR end "LETTER"

	partial void Enter_DIGIT();
	partial void Leave_DIGIT();

	// $ANTLR start "DIGIT"
	[GrammarRule("DIGIT")]
	private void mDIGIT()
	{
		Enter_DIGIT();
		EnterRule("DIGIT", 44);
		TraceIn("DIGIT", 44);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:291:2: ( '0' .. '9' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:291:4: '0' .. '9'
			{
			DebugLocation(291, 4);
			MatchRange('0','9'); 

			}

		}
		finally
		{
			TraceOut("DIGIT", 44);
			LeaveRule("DIGIT", 44);
			Leave_DIGIT();
		}
	}
	// $ANTLR end "DIGIT"

	partial void Enter_HEX_DIGIT();
	partial void Leave_HEX_DIGIT();

	// $ANTLR start "HEX_DIGIT"
	[GrammarRule("HEX_DIGIT")]
	private void mHEX_DIGIT()
	{
		Enter_HEX_DIGIT();
		EnterRule("HEX_DIGIT", 45);
		TraceIn("HEX_DIGIT", 45);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:295:2: ( DIGIT | 'A' .. 'F' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:
			{
			DebugLocation(295, 2);
			if ((input.LA(1)>='0' && input.LA(1)<='9')||(input.LA(1)>='A' && input.LA(1)<='F'))
			{
				input.Consume();

			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;}


			}

		}
		finally
		{
			TraceOut("HEX_DIGIT", 45);
			LeaveRule("HEX_DIGIT", 45);
			Leave_HEX_DIGIT();
		}
	}
	// $ANTLR end "HEX_DIGIT"

	partial void Enter_CLOSE_LINE_COMMENT();
	partial void Leave_CLOSE_LINE_COMMENT();

	// $ANTLR start "CLOSE_LINE_COMMENT"
	[GrammarRule("CLOSE_LINE_COMMENT")]
	private void mCLOSE_LINE_COMMENT()
	{
		Enter_CLOSE_LINE_COMMENT();
		EnterRule("CLOSE_LINE_COMMENT", 46);
		TraceIn("CLOSE_LINE_COMMENT", 46);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:299:2: ( '*/' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:299:4: '*/'
			{
			DebugLocation(299, 4);
			Match("*/"); 


			}

		}
		finally
		{
			TraceOut("CLOSE_LINE_COMMENT", 46);
			LeaveRule("CLOSE_LINE_COMMENT", 46);
			Leave_CLOSE_LINE_COMMENT();
		}
	}
	// $ANTLR end "CLOSE_LINE_COMMENT"

	partial void Enter_COMMENT();
	partial void Leave_COMMENT();

	// $ANTLR start "COMMENT"
	[GrammarRule("COMMENT")]
	private void mCOMMENT()
	{
		Enter_COMMENT();
		EnterRule("COMMENT", 47);
		TraceIn("COMMENT", 47);
		try
		{
			int _type = COMMENT;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:303:2: ( '/' ( LINE_COMMENT | BLOCK_COMMENT ) )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:303:4: '/' ( LINE_COMMENT | BLOCK_COMMENT )
			{
			DebugLocation(303, 4);
			Match('/'); 
			DebugLocation(303, 8);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:303:8: ( LINE_COMMENT | BLOCK_COMMENT )
			int alt3=2;
			try { DebugEnterSubRule(3);
			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
			int LA3_0 = input.LA(1);

			if ((LA3_0=='/'))
			{
				alt3=1;
			}
			else if ((LA3_0=='*'))
			{
				alt3=2;
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 3, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(3); }
			switch (alt3)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:303:10: LINE_COMMENT
				{
				DebugLocation(303, 10);
				mLINE_COMMENT(); 

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:303:25: BLOCK_COMMENT
				{
				DebugLocation(303, 25);
				mBLOCK_COMMENT(); 

				}
				break;

			}
			} finally { DebugExitSubRule(3); }

			DebugLocation(303, 41);
			 _channel = Hidden; 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("COMMENT", 47);
			LeaveRule("COMMENT", 47);
			Leave_COMMENT();
		}
	}
	// $ANTLR end "COMMENT"

	partial void Enter_LINE_COMMENT();
	partial void Leave_LINE_COMMENT();

	// $ANTLR start "LINE_COMMENT"
	[GrammarRule("LINE_COMMENT")]
	private void mLINE_COMMENT()
	{
		Enter_LINE_COMMENT();
		EnterRule("LINE_COMMENT", 48);
		TraceIn("LINE_COMMENT", 48);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:307:2: ( '/' ( options {greedy=false; } : . )* ( '\\n' | '\\r' ) )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:307:4: '/' ( options {greedy=false; } : . )* ( '\\n' | '\\r' )
			{
			DebugLocation(307, 4);
			Match('/'); 
			DebugLocation(307, 9);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:307:9: ( options {greedy=false; } : . )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				int LA4_0 = input.LA(1);

				if ((LA4_0=='\n'||LA4_0=='\r'))
				{
					alt4=2;
				}
				else if (((LA4_0>='\u0000' && LA4_0<='\t')||(LA4_0>='\u000B' && LA4_0<='\f')||(LA4_0>='\u000E' && LA4_0<='\uFFFF')))
				{
					alt4=1;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:307:40: .
					{
					DebugLocation(307, 40);
					MatchAny(); 

					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }

			DebugLocation(307, 44);
			if (input.LA(1)=='\n'||input.LA(1)=='\r')
			{
				input.Consume();

			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;}


			}

		}
		finally
		{
			TraceOut("LINE_COMMENT", 48);
			LeaveRule("LINE_COMMENT", 48);
			Leave_LINE_COMMENT();
		}
	}
	// $ANTLR end "LINE_COMMENT"

	partial void Enter_BLOCK_COMMENT();
	partial void Leave_BLOCK_COMMENT();

	// $ANTLR start "BLOCK_COMMENT"
	[GrammarRule("BLOCK_COMMENT")]
	private void mBLOCK_COMMENT()
	{
		Enter_BLOCK_COMMENT();
		EnterRule("BLOCK_COMMENT", 49);
		TraceIn("BLOCK_COMMENT", 49);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:311:2: ( '*' ( '/' BLOCK_COMMENT | ~ ( '/' | '*' ) )* CLOSE_LINE_COMMENT )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:311:4: '*' ( '/' BLOCK_COMMENT | ~ ( '/' | '*' ) )* CLOSE_LINE_COMMENT
			{
			DebugLocation(311, 4);
			Match('*'); 
			DebugLocation(311, 8);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:311:8: ( '/' BLOCK_COMMENT | ~ ( '/' | '*' ) )*
			try { DebugEnterSubRule(5);
			while (true)
			{
				int alt5=3;
				try { DebugEnterDecision(5, decisionCanBacktrack[5]);
				int LA5_0 = input.LA(1);

				if ((LA5_0=='/'))
				{
					alt5=1;
				}
				else if (((LA5_0>='\u0000' && LA5_0<=')')||(LA5_0>='+' && LA5_0<='.')||(LA5_0>='0' && LA5_0<='\uFFFF')))
				{
					alt5=2;
				}


				} finally { DebugExitDecision(5); }
				switch ( alt5 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:311:10: '/' BLOCK_COMMENT
					{
					DebugLocation(311, 10);
					Match('/'); 
					DebugLocation(311, 14);
					mBLOCK_COMMENT(); 

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:311:30: ~ ( '/' | '*' )
					{
					DebugLocation(311, 30);
					if ((input.LA(1)>='\u0000' && input.LA(1)<=')')||(input.LA(1)>='+' && input.LA(1)<='.')||(input.LA(1)>='0' && input.LA(1)<='\uFFFF'))
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				default:
					goto loop5;
				}
			}

			loop5:
				;

			} finally { DebugExitSubRule(5); }

			DebugLocation(311, 46);
			mCLOSE_LINE_COMMENT(); 

			}

		}
		finally
		{
			TraceOut("BLOCK_COMMENT", 49);
			LeaveRule("BLOCK_COMMENT", 49);
			Leave_BLOCK_COMMENT();
		}
	}
	// $ANTLR end "BLOCK_COMMENT"

	partial void Enter_WHITE_SPACE();
	partial void Leave_WHITE_SPACE();

	// $ANTLR start "WHITE_SPACE"
	[GrammarRule("WHITE_SPACE")]
	private void mWHITE_SPACE()
	{
		Enter_WHITE_SPACE();
		EnterRule("WHITE_SPACE", 50);
		TraceIn("WHITE_SPACE", 50);
		try
		{
			int _type = WHITE_SPACE;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:315:2: ( ( ' ' | '\\t' | '\\n' | '\\r' | '\\f' )+ )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:315:4: ( ' ' | '\\t' | '\\n' | '\\r' | '\\f' )+
			{
			DebugLocation(315, 4);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:315:4: ( ' ' | '\\t' | '\\n' | '\\r' | '\\f' )+
			int cnt6=0;
			try { DebugEnterSubRule(6);
			while (true)
			{
				int alt6=2;
				try { DebugEnterDecision(6, decisionCanBacktrack[6]);
				int LA6_0 = input.LA(1);

				if (((LA6_0>='\t' && LA6_0<='\n')||(LA6_0>='\f' && LA6_0<='\r')||LA6_0==' '))
				{
					alt6=1;
				}


				} finally { DebugExitDecision(6); }
				switch (alt6)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:
					{
					DebugLocation(315, 4);
					if ((input.LA(1)>='\t' && input.LA(1)<='\n')||(input.LA(1)>='\f' && input.LA(1)<='\r')||input.LA(1)==' ')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				default:
					if (cnt6 >= 1)
						goto loop6;

					EarlyExitException eee6 = new EarlyExitException( 6, input );
					DebugRecognitionException(eee6);
					throw eee6;
				}
				cnt6++;
			}
			loop6:
				;

			} finally { DebugExitSubRule(6); }

			DebugLocation(316, 3);
			 _channel = Hidden; 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WHITE_SPACE", 50);
			LeaveRule("WHITE_SPACE", 50);
			Leave_WHITE_SPACE();
		}
	}
	// $ANTLR end "WHITE_SPACE"

	partial void Enter_STRING();
	partial void Leave_STRING();

	// $ANTLR start "STRING"
	[GrammarRule("STRING")]
	private void mSTRING()
	{
		Enter_STRING();
		EnterRule("STRING", 51);
		TraceIn("STRING", 51);
		try
		{
			int _type = STRING;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:319:8: ( '\"' ( '\\\\' ( ESC_SEQ | WHITE_SPACE '\\\\' ) | ~ ( '\\\\' | '\"' ) )* '\"' )
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:319:10: '\"' ( '\\\\' ( ESC_SEQ | WHITE_SPACE '\\\\' ) | ~ ( '\\\\' | '\"' ) )* '\"'
			{
			DebugLocation(319, 10);
			Match('\"'); 
			DebugLocation(319, 14);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:319:14: ( '\\\\' ( ESC_SEQ | WHITE_SPACE '\\\\' ) | ~ ( '\\\\' | '\"' ) )*
			try { DebugEnterSubRule(8);
			while (true)
			{
				int alt8=3;
				try { DebugEnterDecision(8, decisionCanBacktrack[8]);
				int LA8_0 = input.LA(1);

				if ((LA8_0=='\\'))
				{
					alt8=1;
				}
				else if (((LA8_0>='\u0000' && LA8_0<='!')||(LA8_0>='#' && LA8_0<='[')||(LA8_0>=']' && LA8_0<='\uFFFF')))
				{
					alt8=2;
				}


				} finally { DebugExitDecision(8); }
				switch ( alt8 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:319:16: '\\\\' ( ESC_SEQ | WHITE_SPACE '\\\\' )
					{
					DebugLocation(319, 16);
					Match('\\'); 
					DebugLocation(319, 21);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:319:21: ( ESC_SEQ | WHITE_SPACE '\\\\' )
					int alt7=2;
					try { DebugEnterSubRule(7);
					try { DebugEnterDecision(7, decisionCanBacktrack[7]);
					int LA7_0 = input.LA(1);

					if ((LA7_0=='\"'||LA7_0=='\''||LA7_0=='0'||LA7_0=='U'||LA7_0=='\\'||(LA7_0>='a' && LA7_0<='b')||LA7_0=='f'||LA7_0=='n'||LA7_0=='r'||(LA7_0>='t' && LA7_0<='v')||LA7_0=='x'))
					{
						alt7=1;
					}
					else if (((LA7_0>='\t' && LA7_0<='\n')||(LA7_0>='\f' && LA7_0<='\r')||LA7_0==' '))
					{
						alt7=2;
					}
					else
					{
						NoViableAltException nvae = new NoViableAltException("", 7, 0, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
					} finally { DebugExitDecision(7); }
					switch (alt7)
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:319:22: ESC_SEQ
						{
						DebugLocation(319, 22);
						mESC_SEQ(); 

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:319:32: WHITE_SPACE '\\\\'
						{
						DebugLocation(319, 32);
						mWHITE_SPACE(); 
						DebugLocation(319, 44);
						Match('\\'); 

						}
						break;

					}
					} finally { DebugExitSubRule(7); }


					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:320:9: ~ ( '\\\\' | '\"' )
					{
					DebugLocation(320, 9);
					if ((input.LA(1)>='\u0000' && input.LA(1)<='!')||(input.LA(1)>='#' && input.LA(1)<='[')||(input.LA(1)>=']' && input.LA(1)<='\uFFFF'))
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				default:
					goto loop8;
				}
			}

			loop8:
				;

			} finally { DebugExitSubRule(8); }

			DebugLocation(321, 10);
			Match('\"'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("STRING", 51);
			LeaveRule("STRING", 51);
			Leave_STRING();
		}
	}
	// $ANTLR end "STRING"

	partial void Enter_ESC_SEQ();
	partial void Leave_ESC_SEQ();

	// $ANTLR start "ESC_SEQ"
	[GrammarRule("ESC_SEQ")]
	private void mESC_SEQ()
	{
		Enter_ESC_SEQ();
		EnterRule("ESC_SEQ", 52);
		TraceIn("ESC_SEQ", 52);
		try
		{
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:325:2: ( '\\'' | '\\\"' | '\\\\' | '0' | 'a' | 'b' | 'f' | 'n' | 'r' | 't' | 'v' | ( 'U0000' | 'u' ) HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT | 'x' ( '0' | '1' )? ( DIGIT )? DIGIT )
			int alt12=13;
			try { DebugEnterDecision(12, decisionCanBacktrack[12]);
			switch (input.LA(1))
			{
			case '\'':
				{
				alt12=1;
				}
				break;
			case '\"':
				{
				alt12=2;
				}
				break;
			case '\\':
				{
				alt12=3;
				}
				break;
			case '0':
				{
				alt12=4;
				}
				break;
			case 'a':
				{
				alt12=5;
				}
				break;
			case 'b':
				{
				alt12=6;
				}
				break;
			case 'f':
				{
				alt12=7;
				}
				break;
			case 'n':
				{
				alt12=8;
				}
				break;
			case 'r':
				{
				alt12=9;
				}
				break;
			case 't':
				{
				alt12=10;
				}
				break;
			case 'v':
				{
				alt12=11;
				}
				break;
			case 'U':
			case 'u':
				{
				alt12=12;
				}
				break;
			case 'x':
				{
				alt12=13;
				}
				break;
			default:
				{
					NoViableAltException nvae = new NoViableAltException("", 12, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(12); }
			switch (alt12)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:325:4: '\\''
				{
				DebugLocation(325, 4);
				Match('\''); 

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:325:11: '\\\"'
				{
				DebugLocation(325, 11);
				Match('\"'); 

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:325:18: '\\\\'
				{
				DebugLocation(325, 18);
				Match('\\'); 

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:325:25: '0'
				{
				DebugLocation(325, 25);
				Match('0'); 

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:325:31: 'a'
				{
				DebugLocation(325, 31);
				Match('a'); 

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:325:37: 'b'
				{
				DebugLocation(325, 37);
				Match('b'); 

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:325:42: 'f'
				{
				DebugLocation(325, 42);
				Match('f'); 

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:325:48: 'n'
				{
				DebugLocation(325, 48);
				Match('n'); 

				}
				break;
			case 9:
				DebugEnterAlt(9);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:325:54: 'r'
				{
				DebugLocation(325, 54);
				Match('r'); 

				}
				break;
			case 10:
				DebugEnterAlt(10);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:325:60: 't'
				{
				DebugLocation(325, 60);
				Match('t'); 

				}
				break;
			case 11:
				DebugEnterAlt(11);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:325:66: 'v'
				{
				DebugLocation(325, 66);
				Match('v'); 

				}
				break;
			case 12:
				DebugEnterAlt(12);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:326:4: ( 'U0000' | 'u' ) HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT
				{
				DebugLocation(326, 4);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:326:4: ( 'U0000' | 'u' )
				int alt9=2;
				try { DebugEnterSubRule(9);
				try { DebugEnterDecision(9, decisionCanBacktrack[9]);
				int LA9_0 = input.LA(1);

				if ((LA9_0=='U'))
				{
					alt9=1;
				}
				else if ((LA9_0=='u'))
				{
					alt9=2;
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 9, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				} finally { DebugExitDecision(9); }
				switch (alt9)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:326:5: 'U0000'
					{
					DebugLocation(326, 5);
					Match("U0000"); 


					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:326:15: 'u'
					{
					DebugLocation(326, 15);
					Match('u'); 

					}
					break;

				}
				} finally { DebugExitSubRule(9); }

				DebugLocation(326, 20);
				mHEX_DIGIT(); 
				DebugLocation(326, 30);
				mHEX_DIGIT(); 
				DebugLocation(326, 40);
				mHEX_DIGIT(); 
				DebugLocation(326, 50);
				mHEX_DIGIT(); 

				}
				break;
			case 13:
				DebugEnterAlt(13);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:327:4: 'x' ( '0' | '1' )? ( DIGIT )? DIGIT
				{
				DebugLocation(327, 4);
				Match('x'); 
				DebugLocation(327, 8);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:327:8: ( '0' | '1' )?
				int alt10=2;
				try { DebugEnterSubRule(10);
				try { DebugEnterDecision(10, decisionCanBacktrack[10]);
				int LA10_0 = input.LA(1);

				if (((LA10_0>='0' && LA10_0<='1')))
				{
					alt10=1;
				}
				} finally { DebugExitDecision(10); }
				switch (alt10)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:
					{
					DebugLocation(327, 8);
					if ((input.LA(1)>='0' && input.LA(1)<='1'))
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				}
				} finally { DebugExitSubRule(10); }

				DebugLocation(327, 22);
				// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:327:22: ( DIGIT )?
				int alt11=2;
				try { DebugEnterSubRule(11);
				try { DebugEnterDecision(11, decisionCanBacktrack[11]);
				int LA11_0 = input.LA(1);

				if (((LA11_0>='0' && LA11_0<='9')))
				{
					int LA11_1 = input.LA(2);

					if (((LA11_1>='0' && LA11_1<='9')))
					{
						alt11=1;
					}
				}
				} finally { DebugExitDecision(11); }
				switch (alt11)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:327:22: DIGIT
					{
					DebugLocation(327, 22);
					mDIGIT(); 

					}
					break;

				}
				} finally { DebugExitSubRule(11); }

				DebugLocation(327, 29);
				mDIGIT(); 

				}
				break;

			}
		}
		finally
		{
			TraceOut("ESC_SEQ", 52);
			LeaveRule("ESC_SEQ", 52);
			Leave_ESC_SEQ();
		}
	}
	// $ANTLR end "ESC_SEQ"

	public override void mTokens()
	{
		// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:8: ( ARRAY | BREAK | DO | ELSE | END | FOR | FUNCTION | IF | IN | LET | NIL | OF | THEN | TO | TYPE | VAR | WHILE | COMMA | COLON | SEMICOLON | LEFT_PARENTHESIS | RIGHT_PARENTHESIS | LEFT_BRACKET | RIGHT_BRACKET | LEFT_KEY | RIGHT_KEY | DOT | PLUS | MINUS | MULTIPLICATION | DIVISION | EQUAL | NOT_EQUAL | LESS_THAN | LESS_EQUAL_THAN | GREATHER_THAN | GREATHER_EQUAL_THAN | AND | OR | ASSIGNMENT | ID | INT | COMMENT | WHITE_SPACE | STRING )
		int alt13=45;
		try { DebugEnterDecision(13, decisionCanBacktrack[13]);
		try
		{
			alt13 = dfa13.Predict(input);
		}
		catch (NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
			throw;
		}
		} finally { DebugExitDecision(13); }
		switch (alt13)
		{
		case 1:
			DebugEnterAlt(1);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:10: ARRAY
			{
			DebugLocation(1, 10);
			mARRAY(); 

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:16: BREAK
			{
			DebugLocation(1, 16);
			mBREAK(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:22: DO
			{
			DebugLocation(1, 22);
			mDO(); 

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:25: ELSE
			{
			DebugLocation(1, 25);
			mELSE(); 

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:30: END
			{
			DebugLocation(1, 30);
			mEND(); 

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:34: FOR
			{
			DebugLocation(1, 34);
			mFOR(); 

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:38: FUNCTION
			{
			DebugLocation(1, 38);
			mFUNCTION(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:47: IF
			{
			DebugLocation(1, 47);
			mIF(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:50: IN
			{
			DebugLocation(1, 50);
			mIN(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:53: LET
			{
			DebugLocation(1, 53);
			mLET(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:57: NIL
			{
			DebugLocation(1, 57);
			mNIL(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:61: OF
			{
			DebugLocation(1, 61);
			mOF(); 

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:64: THEN
			{
			DebugLocation(1, 64);
			mTHEN(); 

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:69: TO
			{
			DebugLocation(1, 69);
			mTO(); 

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:72: TYPE
			{
			DebugLocation(1, 72);
			mTYPE(); 

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:77: VAR
			{
			DebugLocation(1, 77);
			mVAR(); 

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:81: WHILE
			{
			DebugLocation(1, 81);
			mWHILE(); 

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:87: COMMA
			{
			DebugLocation(1, 87);
			mCOMMA(); 

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:93: COLON
			{
			DebugLocation(1, 93);
			mCOLON(); 

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:99: SEMICOLON
			{
			DebugLocation(1, 99);
			mSEMICOLON(); 

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:109: LEFT_PARENTHESIS
			{
			DebugLocation(1, 109);
			mLEFT_PARENTHESIS(); 

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:126: RIGHT_PARENTHESIS
			{
			DebugLocation(1, 126);
			mRIGHT_PARENTHESIS(); 

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:144: LEFT_BRACKET
			{
			DebugLocation(1, 144);
			mLEFT_BRACKET(); 

			}
			break;
		case 24:
			DebugEnterAlt(24);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:157: RIGHT_BRACKET
			{
			DebugLocation(1, 157);
			mRIGHT_BRACKET(); 

			}
			break;
		case 25:
			DebugEnterAlt(25);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:171: LEFT_KEY
			{
			DebugLocation(1, 171);
			mLEFT_KEY(); 

			}
			break;
		case 26:
			DebugEnterAlt(26);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:180: RIGHT_KEY
			{
			DebugLocation(1, 180);
			mRIGHT_KEY(); 

			}
			break;
		case 27:
			DebugEnterAlt(27);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:190: DOT
			{
			DebugLocation(1, 190);
			mDOT(); 

			}
			break;
		case 28:
			DebugEnterAlt(28);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:194: PLUS
			{
			DebugLocation(1, 194);
			mPLUS(); 

			}
			break;
		case 29:
			DebugEnterAlt(29);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:199: MINUS
			{
			DebugLocation(1, 199);
			mMINUS(); 

			}
			break;
		case 30:
			DebugEnterAlt(30);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:205: MULTIPLICATION
			{
			DebugLocation(1, 205);
			mMULTIPLICATION(); 

			}
			break;
		case 31:
			DebugEnterAlt(31);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:220: DIVISION
			{
			DebugLocation(1, 220);
			mDIVISION(); 

			}
			break;
		case 32:
			DebugEnterAlt(32);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:229: EQUAL
			{
			DebugLocation(1, 229);
			mEQUAL(); 

			}
			break;
		case 33:
			DebugEnterAlt(33);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:235: NOT_EQUAL
			{
			DebugLocation(1, 235);
			mNOT_EQUAL(); 

			}
			break;
		case 34:
			DebugEnterAlt(34);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:245: LESS_THAN
			{
			DebugLocation(1, 245);
			mLESS_THAN(); 

			}
			break;
		case 35:
			DebugEnterAlt(35);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:255: LESS_EQUAL_THAN
			{
			DebugLocation(1, 255);
			mLESS_EQUAL_THAN(); 

			}
			break;
		case 36:
			DebugEnterAlt(36);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:271: GREATHER_THAN
			{
			DebugLocation(1, 271);
			mGREATHER_THAN(); 

			}
			break;
		case 37:
			DebugEnterAlt(37);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:285: GREATHER_EQUAL_THAN
			{
			DebugLocation(1, 285);
			mGREATHER_EQUAL_THAN(); 

			}
			break;
		case 38:
			DebugEnterAlt(38);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:305: AND
			{
			DebugLocation(1, 305);
			mAND(); 

			}
			break;
		case 39:
			DebugEnterAlt(39);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:309: OR
			{
			DebugLocation(1, 309);
			mOR(); 

			}
			break;
		case 40:
			DebugEnterAlt(40);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:312: ASSIGNMENT
			{
			DebugLocation(1, 312);
			mASSIGNMENT(); 

			}
			break;
		case 41:
			DebugEnterAlt(41);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:323: ID
			{
			DebugLocation(1, 323);
			mID(); 

			}
			break;
		case 42:
			DebugEnterAlt(42);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:326: INT
			{
			DebugLocation(1, 326);
			mINT(); 

			}
			break;
		case 43:
			DebugEnterAlt(43);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:330: COMMENT
			{
			DebugLocation(1, 330);
			mCOMMENT(); 

			}
			break;
		case 44:
			DebugEnterAlt(44);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:338: WHITE_SPACE
			{
			DebugLocation(1, 338);
			mWHITE_SPACE(); 

			}
			break;
		case 45:
			DebugEnterAlt(45);
			// C:\\Users\\chino23\\Desktop\\CODIGO\\Tiger.g:1:350: STRING
			{
			DebugLocation(1, 350);
			mSTRING(); 

			}
			break;

		}

	}


	#region DFA
	DFA13 dfa13;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa13 = new DFA13(this);
	}

	private class DFA13 : DFA
	{
		private const string DFA13_eotS =
			"\x1\xFFFF\xC\x20\x1\xFFFF\x1\x36\xB\xFFFF\x1\x37\x1\xFFFF\x1\x3B\x1"+
			"\x3D\x6\xFFFF\x2\x20\x1\x40\x4\x20\x1\x45\x1\x46\x2\x20\x1\x49\x1\x20"+
			"\x1\x4B\x3\x20\x9\xFFFF\x2\x20\x1\xFFFF\x1\x20\x1\x52\x1\x53\x1\x20\x2"+
			"\xFFFF\x1\x55\x1\x56\x1\xFFFF\x1\x20\x1\xFFFF\x1\x20\x1\x59\x3\x20\x1"+
			"\x5D\x2\xFFFF\x1\x20\x2\xFFFF\x1\x5F\x1\x60\x1\xFFFF\x1\x20\x1\x62\x1"+
			"\x63\x1\xFFFF\x1\x20\x2\xFFFF\x1\x65\x2\xFFFF\x1\x20\x1\xFFFF\x1\x20"+
			"\x1\x68\x1\xFFFF";
		private const string DFA13_eofS =
			"\x69\xFFFF";
		private const string DFA13_minS =
			"\x1\x9\x2\x72\x1\x6F\x1\x6C\x1\x6F\x1\x66\x1\x65\x1\x69\x1\x66\x1\x68"+
			"\x1\x61\x1\x68\x1\xFFFF\x1\x3D\xB\xFFFF\x1\x2A\x1\xFFFF\x2\x3D\x6\xFFFF"+
			"\x1\x72\x1\x65\x1\x30\x1\x73\x1\x64\x1\x72\x1\x6E\x2\x30\x1\x74\x1\x6C"+
			"\x1\x30\x1\x65\x1\x30\x1\x70\x1\x72\x1\x69\x9\xFFFF\x2\x61\x1\xFFFF\x1"+
			"\x65\x2\x30\x1\x63\x2\xFFFF\x2\x30\x1\xFFFF\x1\x6E\x1\xFFFF\x1\x65\x1"+
			"\x30\x1\x6C\x1\x79\x1\x6B\x1\x30\x2\xFFFF\x1\x74\x2\xFFFF\x2\x30\x1\xFFFF"+
			"\x1\x65\x2\x30\x1\xFFFF\x1\x69\x2\xFFFF\x1\x30\x2\xFFFF\x1\x6F\x1\xFFFF"+
			"\x1\x6E\x1\x30\x1\xFFFF";
		private const string DFA13_maxS =
			"\x1\x7D\x2\x72\x1\x6F\x1\x6E\x1\x75\x1\x6E\x1\x65\x1\x69\x1\x66\x1\x79"+
			"\x1\x61\x1\x68\x1\xFFFF\x1\x3D\xB\xFFFF\x1\x2F\x1\xFFFF\x1\x3E\x1\x3D"+
			"\x6\xFFFF\x1\x72\x1\x65\x1\x7A\x1\x73\x1\x64\x1\x72\x1\x6E\x2\x7A\x1"+
			"\x74\x1\x6C\x1\x7A\x1\x65\x1\x7A\x1\x70\x1\x72\x1\x69\x9\xFFFF\x2\x61"+
			"\x1\xFFFF\x1\x65\x2\x7A\x1\x63\x2\xFFFF\x2\x7A\x1\xFFFF\x1\x6E\x1\xFFFF"+
			"\x1\x65\x1\x7A\x1\x6C\x1\x79\x1\x6B\x1\x7A\x2\xFFFF\x1\x74\x2\xFFFF\x2"+
			"\x7A\x1\xFFFF\x1\x65\x2\x7A\x1\xFFFF\x1\x69\x2\xFFFF\x1\x7A\x2\xFFFF"+
			"\x1\x6F\x1\xFFFF\x1\x6E\x1\x7A\x1\xFFFF";
		private const string DFA13_acceptS =
			"\xD\xFFFF\x1\x12\x1\xFFFF\x1\x14\x1\x15\x1\x16\x1\x17\x1\x18\x1\x19"+
			"\x1\x1A\x1\x1B\x1\x1C\x1\x1D\x1\x1E\x1\xFFFF\x1\x20\x2\xFFFF\x1\x26\x1"+
			"\x27\x1\x29\x1\x2A\x1\x2C\x1\x2D\x11\xFFFF\x1\x28\x1\x13\x1\x1F\x1\x2B"+
			"\x1\x21\x1\x23\x1\x22\x1\x25\x1\x24\x2\xFFFF\x1\x3\x4\xFFFF\x1\x8\x1"+
			"\x9\x2\xFFFF\x1\xC\x1\xFFFF\x1\xE\x6\xFFFF\x1\x5\x1\x6\x1\xFFFF\x1\xA"+
			"\x1\xB\x2\xFFFF\x1\x10\x3\xFFFF\x1\x4\x1\xFFFF\x1\xD\x1\xF\x1\xFFFF\x1"+
			"\x1\x1\x2\x1\xFFFF\x1\x11\x2\xFFFF\x1\x7";
		private const string DFA13_specialS =
			"\x69\xFFFF}>";
		private static readonly string[] DFA13_transitionS =
			{
				"\x2\x22\x1\xFFFF\x2\x22\x12\xFFFF\x1\x22\x1\xFFFF\x1\x23\x3\xFFFF\x1"+
				"\x1E\x1\xFFFF\x1\x10\x1\x11\x1\x19\x1\x17\x1\xD\x1\x18\x1\x16\x1\x1A"+
				"\xA\x21\x1\xE\x1\xF\x1\x1C\x1\x1B\x1\x1D\x2\xFFFF\x1A\x20\x1\x12\x1"+
				"\xFFFF\x1\x13\x3\xFFFF\x1\x1\x1\x2\x1\x20\x1\x3\x1\x4\x1\x5\x2\x20\x1"+
				"\x6\x2\x20\x1\x7\x1\x20\x1\x8\x1\x9\x4\x20\x1\xA\x1\x20\x1\xB\x1\xC"+
				"\x3\x20\x1\x14\x1\x1F\x1\x15",
				"\x1\x24",
				"\x1\x25",
				"\x1\x26",
				"\x1\x27\x1\xFFFF\x1\x28",
				"\x1\x29\x5\xFFFF\x1\x2A",
				"\x1\x2B\x7\xFFFF\x1\x2C",
				"\x1\x2D",
				"\x1\x2E",
				"\x1\x2F",
				"\x1\x30\x6\xFFFF\x1\x31\x9\xFFFF\x1\x32",
				"\x1\x33",
				"\x1\x34",
				"",
				"\x1\x35",
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
				"",
				"\x1\x38\x4\xFFFF\x1\x38",
				"",
				"\x1\x3A\x1\x39",
				"\x1\x3C",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x3E",
				"\x1\x3F",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\x1\x41",
				"\x1\x42",
				"\x1\x43",
				"\x1\x44",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\x1\x47",
				"\x1\x48",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\x1\x4A",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\x1\x4C",
				"\x1\x4D",
				"\x1\x4E",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x4F",
				"\x1\x50",
				"",
				"\x1\x51",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\x1\x54",
				"",
				"",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"",
				"\x1\x57",
				"",
				"\x1\x58",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\x1\x5A",
				"\x1\x5B",
				"\x1\x5C",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"",
				"",
				"\x1\x5E",
				"",
				"",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"",
				"\x1\x61",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"",
				"\x1\x64",
				"",
				"",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				"",
				"",
				"\x1\x66",
				"",
				"\x1\x67",
				"\xA\x20\x7\xFFFF\x1A\x20\x4\xFFFF\x1\x20\x1\xFFFF\x1A\x20",
				""
			};

		private static readonly short[] DFA13_eot = DFA.UnpackEncodedString(DFA13_eotS);
		private static readonly short[] DFA13_eof = DFA.UnpackEncodedString(DFA13_eofS);
		private static readonly char[] DFA13_min = DFA.UnpackEncodedStringToUnsignedChars(DFA13_minS);
		private static readonly char[] DFA13_max = DFA.UnpackEncodedStringToUnsignedChars(DFA13_maxS);
		private static readonly short[] DFA13_accept = DFA.UnpackEncodedString(DFA13_acceptS);
		private static readonly short[] DFA13_special = DFA.UnpackEncodedString(DFA13_specialS);
		private static readonly short[][] DFA13_transition;

		static DFA13()
		{
			int numStates = DFA13_transitionS.Length;
			DFA13_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA13_transition[i] = DFA.UnpackEncodedString(DFA13_transitionS[i]);
			}
		}

		public DFA13( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 13;
			this.eot = DFA13_eot;
			this.eof = DFA13_eof;
			this.min = DFA13_min;
			this.max = DFA13_max;
			this.accept = DFA13_accept;
			this.special = DFA13_special;
			this.transition = DFA13_transition;
		}

		public override string Description { get { return "1:1: Tokens : ( ARRAY | BREAK | DO | ELSE | END | FOR | FUNCTION | IF | IN | LET | NIL | OF | THEN | TO | TYPE | VAR | WHILE | COMMA | COLON | SEMICOLON | LEFT_PARENTHESIS | RIGHT_PARENTHESIS | LEFT_BRACKET | RIGHT_BRACKET | LEFT_KEY | RIGHT_KEY | DOT | PLUS | MINUS | MULTIPLICATION | DIVISION | EQUAL | NOT_EQUAL | LESS_THAN | LESS_EQUAL_THAN | GREATHER_THAN | GREATHER_EQUAL_THAN | AND | OR | ASSIGNMENT | ID | INT | COMMENT | WHITE_SPACE | STRING );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}
