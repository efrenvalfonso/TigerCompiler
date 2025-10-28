grammar Tiger;

options
{
	language = CSharp3;
	output = AST;
}

tokens
{

/* --------- Reserved Words ---------- */

ARRAY			=	'array'	;

BREAK			=	'break'	;

DO			=	'do'	;

ELSE			=	'else'	;

END			=	'end'	;

FOR			=	'for'	;

FUNCTION		=	'function';

IF			=	'if'	;

IN			=	'in'	;

LET			=	'let'	;

NIL			=	'nil'	;

OF			=	'of'	;

THEN			=	'then'	;

TO			=	'to'	;

TYPE			=	'type'	;

VAR			=	'var'	;

WHILE			=	'while'	;

/* ----------------------------------- */

/* ------- Punctuation Symbols ------- */

COMMA			=	','	;

COLON			=	':'	;

SEMICOLON		=	';'	;

LEFT_PARENTHESIS	=	'('	;
	
RIGHT_PARENTHESIS	=	')'	;
	
LEFT_BRACKET		=	'['	;
	
RIGHT_BRACKET		=	']'	;
	
LEFT_KEY		=	'{'	;
	
RIGHT_KEY		=	'}'	;
	
DOT			=	'.'	;
	
PLUS			=	'+'	;
	
MINUS			=	'-'	;
	
MULTIPLICATION		=	'*'	;
	
DIVISION		=	'/'	;
	
EQUAL			=	'='	;
	
NOT_EQUAL		=	'<>'	;
	
LESS_THAN		=	'<'	;
	
LESS_EQUAL_THAN		=	'<='	;
	
GREATHER_THAN		=	'>'	;
	
GREATHER_EQUAL_THAN	=	'>='	;
	
AND			=	'&'	;
	
OR			=	'|'	;
	
ASSIGNMENT		=	':='	;

/* ----------------------------------- */

/* ---------- VIRTUAL NODES ---------- */

UNARY_MINUS				;

IF_THEN					;

IF_THEN_ELSE				;

EXPRESSION_SET				;

INDEXER					;

TUPLE					;

FIELD					;

TYPE_FIELD				;

VARIABLE_DECLARATION			;

ARRAY_DECLARATION			;

RECORD_ASSIGNMENT			;

RECORD_ASSIGNMENT_ACCESS		;

PROCEDURE_DECLARATION			;

EXPLICIT_TYPE_DECLARATION		;

RECORD_TYPE_DECLARATION			;

ARRAY_TYPE_DECLARATION			;

VARIABLE_TYPE_DECLARATION		;

FUNCTION_DECLARATION			;

RECORD_ACCESS				;

FUNCTION_CALL				;

FUNCTION_CALL_INDEXER			;

/* ----------------------------------- */

}

@lexer::header
{
	using TigerCompiler;
}

@lexer::members
{
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
}

@parser::header
{
	using TigerCompiler;
}

@parser::members
{
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
}

/* -------------- LEXER -------------- */
	
ID	:	LETTER (LETTER | DIGIT | '_')*
	;

INT	:	DIGIT+
	;

fragment LETTER
	:	'a'..'z' | 'A'..'Z'
	;

fragment DIGIT
	:	'0'..'9'
	;
	
fragment HEX_DIGIT
	:	DIGIT | 'A'..'F'
	;
	
fragment CLOSE_LINE_COMMENT
	:	'*/'
	;
	
COMMENT
	:	'/' ( LINE_COMMENT | BLOCK_COMMENT ) { $channel = Hidden; }
	;

fragment LINE_COMMENT
	:	'/'  (options { greedy = false; } : .)* ('\n' | '\r')
	;
	
fragment BLOCK_COMMENT
	:	'*' ( '/' BLOCK_COMMENT | ~('/' | '*') )* CLOSE_LINE_COMMENT
	;

WHITE_SPACE
	:	(' ' | '\t' | '\n' | '\r' | '\f')+ 
		{ $channel = Hidden; }
	;

STRING	:	'"' ( '\\' (ESC_SEQ | WHITE_SPACE '\\') 
		    | ~('\\' | '"')
		    )* '"'
	;

fragment ESC_SEQ
	:	'\'' | '\"' | '\\' | '0' | 'a' | 'b' |'f' | 'n' | 'r' | 't' | 'v' 
	|	('U0000' | 'u') HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT
	|	'x' ( '0' | '1')? DIGIT? DIGIT
	;

/* ----------------------------------- */

/* -------------- PARSER ------------- */

public program	
	:	expression EOF!
	;

expression
	:	(left_value_assignment ASSIGNMENT) => leftValue = left_value_assignment ASSIGNMENT^ rightConjunctiveExpression = conjunctive_expression
	|	 conjunctive_expression
	;

left_value_assignment
	:	leftId = id
		( recordAccess = record_access[(CommonTree)leftId.Tree] leftValue = left_value[(CommonTree)recordAccess.Tree] -> $leftValue
		| ind = indexer[(CommonTree)leftId.Tree] leftValue = left_value[(CommonTree)ind.Tree] -> $leftValue
		| -> $leftId
		)
	;

conjunctive_expression
	:	leftDisjunctiveExpression = disjunctive_expression (OR^ rightDisjunctiveExpression = disjunctive_expression)*
	;

disjunctive_expression
	:	leftRelationalExpression = relational_expression (AND^ rightRelationalExpression = relational_expression)*
	;

relational_expression
	:	leftArithmetic= arithmetic_expression((EQUAL^ | NOT_EQUAL^ | LESS_THAN^ | LESS_EQUAL_THAN^ | GREATHER_THAN^ | GREATHER_EQUAL_THAN^)rigthArithmetic = arithmetic_expression)?
	;

arithmetic_expression
	:	leftTerm = term ((PLUS^ | MINUS^) rightTerm = term)*
	;

term	:	leftFactor = factor ((MULTIPLICATION^ | DIVISION^) rightFactor = factor)*
	;

factor	:	MINUS factor -> ^(UNARY_MINUS factor)
	|	value_returner
	|	not_value_returner
	;

value_returner
	:	STRING
	|	INT
	|	NIL
	|	leftId = id
		( recordAccess = record_access[(CommonTree)leftId.Tree] leftValue = left_value[(CommonTree)recordAccess.Tree] -> $leftValue
		| ind = indexer[(CommonTree)leftId.Tree] ( OF expression -> ^(ARRAY_DECLARATION $leftId {$ind.betweenBracketsExpression} expression)
							 | leftValue = left_value[(CommonTree)ind.Tree] -> $leftValue
							 )
		| functionCall = function_call[(CommonTree)leftId.Tree] leftValue = left_value[(CommonTree)functionCall.Tree] -> $leftValue
		| recordAssignment = record_assignment[(CommonTree)leftId.Tree] ( recordAccess = record_access[(CommonTree)recordAssignment.Tree] leftValue = left_value[(CommonTree)recordAccess.Tree] -> $leftValue
										| -> $recordAssignment
										)
		| -> $leftId
		)
	|	tupleExpression = tuple_expression leftValue = left_value[(CommonTree)tupleExpression.Tree] -> $leftValue
	|	letExpression = let_expression leftValue = left_value[(CommonTree)letExpression.Tree] -> $leftValue
	;

id	:	ID^
	;

function_call[CommonTree leftId]
	:	LEFT_PARENTHESIS expression_list? RIGHT_PARENTHESIS -> ^(FUNCTION_CALL {leftId} expression_list?)
	;

record_assignment[CommonTree leftId]
	:	LEFT_KEY field_list? RIGHT_KEY -> ^(RECORD_ASSIGNMENT {leftId} field_list?)
	;

record_access[CommonTree leftValue]
	:	DOT rightId = ID -> ^(RECORD_ACCESS {leftValue} $rightId)
	;
	
indexer[CommonTree leftValue] returns[ITree betweenBracketsExpression]
	:	LEFT_BRACKET expr = expression RIGHT_BRACKET {$betweenBracketsExpression = (ITree)expr.Tree;} -> ^(INDEXER {leftValue} $expr)
	;

left_value[CommonTree leftValue]
	:	( recordAccess = record_access[leftValue] newLeftValue = left_value[(CommonTree)recordAccess.Tree]
		| ind = indexer[leftValue] newLeftValue = left_value[(CommonTree)ind.Tree]
		) -> $newLeftValue
	|	-> {leftValue}
	;

not_value_returner
	:	BREAK
	|	control_expression
	;

tuple_expression
	:	LEFT_PARENTHESIS expression_sequence? RIGHT_PARENTHESIS -> ^(TUPLE expression_sequence?)
	;

control_expression
	:	if_expression
	|	while_expression
	|	for_expression
	;

if_expression
	:	IF conditionalExpression = expression THEN thenExpression = expression ((ELSE) => ELSE elseExpression = expression -> ^(IF_THEN_ELSE $conditionalExpression $thenExpression $elseExpression) 
										       | -> ^(IF_THEN $conditionalExpression $thenExpression))
	;

while_expression
	:	WHILE conditionalExpression = expression DO doExpression = expression -> ^(WHILE $conditionalExpression $doExpression)
	;

for_expression
	:	FOR ID ASSIGNMENT initialExpression = expression TO finalExpression = expression DO doExpression = expression -> ^(FOR ID $initialExpression $finalExpression $doExpression)
	;

let_expression
	:	LET declaration_list IN expression_sequence? END -> ^(LET declaration_list expression_sequence?)
	;

expression_sequence
	:	expression (SEMICOLON expression)* -> ^(EXPRESSION_SET expression+)
	;

expression_list
	:	expression (COMMA expression)* -> ^(EXPRESSION_SET expression+)
	;

field_list
	:	field (COMMA field)* -> ^(EXPRESSION_SET field+)
	;

field	:	ID EQUAL expression -> ^(FIELD ID expression)
	;

declaration_list
	:	declaration+ -> ^(EXPRESSION_SET declaration+)
	;

declaration
	:	type_declaration
	|	variable_declaration
	|	function_declaration
	;

type_declaration
	:	TYPE typeId = ID EQUAL ( existingType = ID -> ^(EXPLICIT_TYPE_DECLARATION $typeId $existingType)
				       | LEFT_KEY type_fields? RIGHT_KEY -> ^(RECORD_TYPE_DECLARATION $typeId type_fields?)
				       | ARRAY OF arrayType = ID -> ^(ARRAY_TYPE_DECLARATION $typeId $arrayType))
	;

type_fields
	:	type_field (COMMA type_field)* -> ^(EXPRESSION_SET type_field+)
	;

type_field
	:	leftId = ID COLON rightId = ID -> ^(TYPE_FIELD $leftId $rightId)
	;

variable_declaration
	:	VAR variableId = ID ( ASSIGNMENT expression -> ^(VARIABLE_DECLARATION $variableId expression)
				    | COLON typeId = ID ASSIGNMENT expression -> ^(VARIABLE_TYPE_DECLARATION $variableId expression $typeId))
	;

function_declaration
	:	FUNCTION functionId = ID LEFT_PARENTHESIS type_fields? RIGHT_PARENTHESIS ( EQUAL expression -> ^(FUNCTION_DECLARATION $functionId type_fields? expression)
											 | COLON returnType = ID EQUAL expression -> ^(FUNCTION_DECLARATION $functionId type_fields? $returnType expression))
	;
	
/* ----------------------------------- */