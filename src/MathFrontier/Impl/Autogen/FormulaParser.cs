//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from G:/workspace/antlr_formula\Formula.g4 by ANTLR 4.7

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
internal partial class FormulaParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, NumeralLiteral=11, Identifier=12, MethodOrPropertyIdentity=13, 
		WS=14;
	public const int
		RULE_formula = 0, RULE_expression = 1, RULE_methodInvocation = 2, RULE_methodName = 3, 
		RULE_methodParameterPart = 4, RULE_methodParameterList = 5, RULE_methodParameter = 6, 
		RULE_propertyInvocation = 7, RULE_variableReference = 8, RULE_variableReferenceStart = 9, 
		RULE_variableReferenceEnd = 10, RULE_variableIndex = 11, RULE_numeral = 12;
	public static readonly string[] ruleNames = {
		"formula", "expression", "methodInvocation", "methodName", "methodParameterPart", 
		"methodParameterList", "methodParameter", "propertyInvocation", "variableReference", 
		"variableReferenceStart", "variableReferenceEnd", "variableIndex", "numeral"
	};

	private static readonly string[] _LiteralNames = {
		null, "'('", "')'", "'*'", "'/'", "'+'", "'-'", "','", "'${'", "'}'", 
		"'%'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, "NumeralLiteral", 
		"Identifier", "MethodOrPropertyIdentity", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Formula.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static FormulaParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public FormulaParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public FormulaParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}
	public partial class FormulaContext : ParserRuleContext {
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode Eof() { return GetToken(FormulaParser.Eof, 0); }
		public FormulaContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_formula; } }
		public override void EnterRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.EnterFormula(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.ExitFormula(this);
		}
	}

	[RuleVersion(0)]
	public FormulaContext formula() {
		FormulaContext _localctx = new FormulaContext(Context, State);
		EnterRule(_localctx, 0, RULE_formula);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 26; expression(0);
			State = 27; Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExpressionContext : ParserRuleContext {
		public ExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expression; } }
	 
		public ExpressionContext() { }
		public virtual void CopyFrom(ExpressionContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class NumeralValueContext : ExpressionContext {
		public NumeralContext numeral() {
			return GetRuleContext<NumeralContext>(0);
		}
		public NumeralValueContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.EnterNumeralValue(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.ExitNumeralValue(this);
		}
	}
	public partial class ExpressionDivContext : ExpressionContext {
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ExpressionDivContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.EnterExpressionDiv(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.ExitExpressionDiv(this);
		}
	}
	public partial class VariableContext : ExpressionContext {
		public VariableReferenceContext variableReference() {
			return GetRuleContext<VariableReferenceContext>(0);
		}
		public VariableContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.EnterVariable(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.ExitVariable(this);
		}
	}
	public partial class ExpressionMultContext : ExpressionContext {
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ExpressionMultContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.EnterExpressionMult(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.ExitExpressionMult(this);
		}
	}
	public partial class ExpressionMinusContext : ExpressionContext {
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ExpressionMinusContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.EnterExpressionMinus(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.ExitExpressionMinus(this);
		}
	}
	public partial class MethodInvokContext : ExpressionContext {
		public MethodInvocationContext methodInvocation() {
			return GetRuleContext<MethodInvocationContext>(0);
		}
		public MethodInvokContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.EnterMethodInvok(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.ExitMethodInvok(this);
		}
	}
	public partial class PropertyInvokContext : ExpressionContext {
		public PropertyInvocationContext propertyInvocation() {
			return GetRuleContext<PropertyInvocationContext>(0);
		}
		public PropertyInvokContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.EnterPropertyInvok(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.ExitPropertyInvok(this);
		}
	}
	public partial class BracketsExpressionContext : ExpressionContext {
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public BracketsExpressionContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.EnterBracketsExpression(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.ExitBracketsExpression(this);
		}
	}
	public partial class ExpressionPlusContext : ExpressionContext {
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ExpressionPlusContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.EnterExpressionPlus(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.ExitExpressionPlus(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionContext expression() {
		return expression(0);
	}

	private ExpressionContext expression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ExpressionContext _localctx = new ExpressionContext(Context, _parentState);
		ExpressionContext _prevctx = _localctx;
		int _startState = 2;
		EnterRecursionRule(_localctx, 2, RULE_expression, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 38;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,0,Context) ) {
			case 1:
				{
				_localctx = new VariableContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;

				State = 30; variableReference();
				}
				break;
			case 2:
				{
				_localctx = new NumeralValueContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 31; numeral();
				}
				break;
			case 3:
				{
				_localctx = new MethodInvokContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 32; methodInvocation();
				}
				break;
			case 4:
				{
				_localctx = new PropertyInvokContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 33; propertyInvocation();
				}
				break;
			case 5:
				{
				_localctx = new BracketsExpressionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 34; Match(T__0);
				State = 35; expression(0);
				State = 36; Match(T__1);
				}
				break;
			}
			Context.Stop = TokenStream.LT(-1);
			State = 54;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,2,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 52;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,1,Context) ) {
					case 1:
						{
						_localctx = new ExpressionMultContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 40;
						if (!(Precpred(Context, 4))) throw new FailedPredicateException(this, "Precpred(Context, 4)");
						State = 41; Match(T__2);
						State = 42; expression(5);
						}
						break;
					case 2:
						{
						_localctx = new ExpressionDivContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 43;
						if (!(Precpred(Context, 3))) throw new FailedPredicateException(this, "Precpred(Context, 3)");
						State = 44; Match(T__3);
						State = 45; expression(4);
						}
						break;
					case 3:
						{
						_localctx = new ExpressionPlusContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 46;
						if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
						State = 47; Match(T__4);
						State = 48; expression(3);
						}
						break;
					case 4:
						{
						_localctx = new ExpressionMinusContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 49;
						if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
						State = 50; Match(T__5);
						State = 51; expression(2);
						}
						break;
					}
					} 
				}
				State = 56;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,2,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class MethodInvocationContext : ParserRuleContext {
		public MethodNameContext methodName() {
			return GetRuleContext<MethodNameContext>(0);
		}
		public MethodParameterPartContext methodParameterPart() {
			return GetRuleContext<MethodParameterPartContext>(0);
		}
		public MethodInvocationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_methodInvocation; } }
		public override void EnterRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.EnterMethodInvocation(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.ExitMethodInvocation(this);
		}
	}

	[RuleVersion(0)]
	public MethodInvocationContext methodInvocation() {
		MethodInvocationContext _localctx = new MethodInvocationContext(Context, State);
		EnterRule(_localctx, 4, RULE_methodInvocation);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 57; methodName();
			State = 58; methodParameterPart();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class MethodNameContext : ParserRuleContext {
		public ITerminalNode MethodOrPropertyIdentity() { return GetToken(FormulaParser.MethodOrPropertyIdentity, 0); }
		public MethodNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_methodName; } }
		public override void EnterRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.EnterMethodName(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.ExitMethodName(this);
		}
	}

	[RuleVersion(0)]
	public MethodNameContext methodName() {
		MethodNameContext _localctx = new MethodNameContext(Context, State);
		EnterRule(_localctx, 6, RULE_methodName);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 60; Match(MethodOrPropertyIdentity);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class MethodParameterPartContext : ParserRuleContext {
		public MethodParameterListContext methodParameterList() {
			return GetRuleContext<MethodParameterListContext>(0);
		}
		public MethodParameterPartContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_methodParameterPart; } }
		public override void EnterRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.EnterMethodParameterPart(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.ExitMethodParameterPart(this);
		}
	}

	[RuleVersion(0)]
	public MethodParameterPartContext methodParameterPart() {
		MethodParameterPartContext _localctx = new MethodParameterPartContext(Context, State);
		EnterRule(_localctx, 8, RULE_methodParameterPart);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 62; Match(T__0);
			State = 64;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__5) | (1L << T__7) | (1L << NumeralLiteral) | (1L << MethodOrPropertyIdentity))) != 0)) {
				{
				State = 63; methodParameterList();
				}
			}

			State = 66; Match(T__1);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class MethodParameterListContext : ParserRuleContext {
		public MethodParameterContext[] methodParameter() {
			return GetRuleContexts<MethodParameterContext>();
		}
		public MethodParameterContext methodParameter(int i) {
			return GetRuleContext<MethodParameterContext>(i);
		}
		public MethodParameterListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_methodParameterList; } }
		public override void EnterRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.EnterMethodParameterList(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.ExitMethodParameterList(this);
		}
	}

	[RuleVersion(0)]
	public MethodParameterListContext methodParameterList() {
		MethodParameterListContext _localctx = new MethodParameterListContext(Context, State);
		EnterRule(_localctx, 10, RULE_methodParameterList);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 68; methodParameter();
			State = 73;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==T__6) {
				{
				{
				State = 69; Match(T__6);
				State = 70; methodParameter();
				}
				}
				State = 75;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class MethodParameterContext : ParserRuleContext {
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public MethodParameterContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_methodParameter; } }
		public override void EnterRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.EnterMethodParameter(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.ExitMethodParameter(this);
		}
	}

	[RuleVersion(0)]
	public MethodParameterContext methodParameter() {
		MethodParameterContext _localctx = new MethodParameterContext(Context, State);
		EnterRule(_localctx, 12, RULE_methodParameter);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 76; expression(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PropertyInvocationContext : ParserRuleContext {
		public ITerminalNode MethodOrPropertyIdentity() { return GetToken(FormulaParser.MethodOrPropertyIdentity, 0); }
		public PropertyInvocationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_propertyInvocation; } }
		public override void EnterRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.EnterPropertyInvocation(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.ExitPropertyInvocation(this);
		}
	}

	[RuleVersion(0)]
	public PropertyInvocationContext propertyInvocation() {
		PropertyInvocationContext _localctx = new PropertyInvocationContext(Context, State);
		EnterRule(_localctx, 14, RULE_propertyInvocation);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 78; Match(MethodOrPropertyIdentity);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class VariableReferenceContext : ParserRuleContext {
		public VariableReferenceStartContext variableReferenceStart() {
			return GetRuleContext<VariableReferenceStartContext>(0);
		}
		public VariableIndexContext variableIndex() {
			return GetRuleContext<VariableIndexContext>(0);
		}
		public VariableReferenceEndContext variableReferenceEnd() {
			return GetRuleContext<VariableReferenceEndContext>(0);
		}
		public VariableReferenceContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_variableReference; } }
		public override void EnterRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.EnterVariableReference(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.ExitVariableReference(this);
		}
	}

	[RuleVersion(0)]
	public VariableReferenceContext variableReference() {
		VariableReferenceContext _localctx = new VariableReferenceContext(Context, State);
		EnterRule(_localctx, 16, RULE_variableReference);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 80; variableReferenceStart();
			State = 81; variableIndex();
			State = 82; variableReferenceEnd();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class VariableReferenceStartContext : ParserRuleContext {
		public VariableReferenceStartContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_variableReferenceStart; } }
		public override void EnterRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.EnterVariableReferenceStart(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.ExitVariableReferenceStart(this);
		}
	}

	[RuleVersion(0)]
	public VariableReferenceStartContext variableReferenceStart() {
		VariableReferenceStartContext _localctx = new VariableReferenceStartContext(Context, State);
		EnterRule(_localctx, 18, RULE_variableReferenceStart);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 84; Match(T__7);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class VariableReferenceEndContext : ParserRuleContext {
		public VariableReferenceEndContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_variableReferenceEnd; } }
		public override void EnterRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.EnterVariableReferenceEnd(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.ExitVariableReferenceEnd(this);
		}
	}

	[RuleVersion(0)]
	public VariableReferenceEndContext variableReferenceEnd() {
		VariableReferenceEndContext _localctx = new VariableReferenceEndContext(Context, State);
		EnterRule(_localctx, 20, RULE_variableReferenceEnd);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 86; Match(T__8);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class VariableIndexContext : ParserRuleContext {
		public ITerminalNode Identifier() { return GetToken(FormulaParser.Identifier, 0); }
		public VariableIndexContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_variableIndex; } }
		public override void EnterRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.EnterVariableIndex(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.ExitVariableIndex(this);
		}
	}

	[RuleVersion(0)]
	public VariableIndexContext variableIndex() {
		VariableIndexContext _localctx = new VariableIndexContext(Context, State);
		EnterRule(_localctx, 22, RULE_variableIndex);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 88; Match(Identifier);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class NumeralContext : ParserRuleContext {
		public ITerminalNode NumeralLiteral() { return GetToken(FormulaParser.NumeralLiteral, 0); }
		public NumeralContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_numeral; } }
		public override void EnterRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.EnterNumeral(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFormulaListener typedListener = listener as IFormulaListener;
			if (typedListener != null) typedListener.ExitNumeral(this);
		}
	}

	[RuleVersion(0)]
	public NumeralContext numeral() {
		NumeralContext _localctx = new NumeralContext(Context, State);
		EnterRule(_localctx, 24, RULE_numeral);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 91;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==T__5) {
				{
				State = 90; Match(T__5);
				}
			}

			State = 93; Match(NumeralLiteral);
			State = 95;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,6,Context) ) {
			case 1:
				{
				State = 94; Match(T__9);
				}
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 1: return expression_sempred((ExpressionContext)_localctx, predIndex);
		}
		return true;
	}
	private bool expression_sempred(ExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 4);
		case 1: return Precpred(Context, 3);
		case 2: return Precpred(Context, 2);
		case 3: return Precpred(Context, 1);
		}
		return true;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\x10', '\x64', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b', 
		'\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', '\t', '\v', 
		'\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', '\t', 
		'\xE', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x5', '\x3', ')', '\n', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\a', '\x3', '\x37', '\n', '\x3', '\f', '\x3', '\xE', 
		'\x3', ':', '\v', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x5', '\x6', '\x43', 
		'\n', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', 
		'\a', '\a', '\a', 'J', '\n', '\a', '\f', '\a', '\xE', '\a', 'M', '\v', 
		'\a', '\x3', '\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\n', 
		'\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', 
		'\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', '\x3', '\xE', '\x5', '\xE', 
		'^', '\n', '\xE', '\x3', '\xE', '\x3', '\xE', '\x5', '\xE', '\x62', '\n', 
		'\xE', '\x3', '\xE', '\x2', '\x3', '\x4', '\xF', '\x2', '\x4', '\x6', 
		'\b', '\n', '\f', '\xE', '\x10', '\x12', '\x14', '\x16', '\x18', '\x1A', 
		'\x2', '\x2', '\x2', '\x62', '\x2', '\x1C', '\x3', '\x2', '\x2', '\x2', 
		'\x4', '(', '\x3', '\x2', '\x2', '\x2', '\x6', ';', '\x3', '\x2', '\x2', 
		'\x2', '\b', '>', '\x3', '\x2', '\x2', '\x2', '\n', '@', '\x3', '\x2', 
		'\x2', '\x2', '\f', '\x46', '\x3', '\x2', '\x2', '\x2', '\xE', 'N', '\x3', 
		'\x2', '\x2', '\x2', '\x10', 'P', '\x3', '\x2', '\x2', '\x2', '\x12', 
		'R', '\x3', '\x2', '\x2', '\x2', '\x14', 'V', '\x3', '\x2', '\x2', '\x2', 
		'\x16', 'X', '\x3', '\x2', '\x2', '\x2', '\x18', 'Z', '\x3', '\x2', '\x2', 
		'\x2', '\x1A', ']', '\x3', '\x2', '\x2', '\x2', '\x1C', '\x1D', '\x5', 
		'\x4', '\x3', '\x2', '\x1D', '\x1E', '\a', '\x2', '\x2', '\x3', '\x1E', 
		'\x3', '\x3', '\x2', '\x2', '\x2', '\x1F', ' ', '\b', '\x3', '\x1', '\x2', 
		' ', ')', '\x5', '\x12', '\n', '\x2', '!', ')', '\x5', '\x1A', '\xE', 
		'\x2', '\"', ')', '\x5', '\x6', '\x4', '\x2', '#', ')', '\x5', '\x10', 
		'\t', '\x2', '$', '%', '\a', '\x3', '\x2', '\x2', '%', '&', '\x5', '\x4', 
		'\x3', '\x2', '&', '\'', '\a', '\x4', '\x2', '\x2', '\'', ')', '\x3', 
		'\x2', '\x2', '\x2', '(', '\x1F', '\x3', '\x2', '\x2', '\x2', '(', '!', 
		'\x3', '\x2', '\x2', '\x2', '(', '\"', '\x3', '\x2', '\x2', '\x2', '(', 
		'#', '\x3', '\x2', '\x2', '\x2', '(', '$', '\x3', '\x2', '\x2', '\x2', 
		')', '\x38', '\x3', '\x2', '\x2', '\x2', '*', '+', '\f', '\x6', '\x2', 
		'\x2', '+', ',', '\a', '\x5', '\x2', '\x2', ',', '\x37', '\x5', '\x4', 
		'\x3', '\a', '-', '.', '\f', '\x5', '\x2', '\x2', '.', '/', '\a', '\x6', 
		'\x2', '\x2', '/', '\x37', '\x5', '\x4', '\x3', '\x6', '\x30', '\x31', 
		'\f', '\x4', '\x2', '\x2', '\x31', '\x32', '\a', '\a', '\x2', '\x2', '\x32', 
		'\x37', '\x5', '\x4', '\x3', '\x5', '\x33', '\x34', '\f', '\x3', '\x2', 
		'\x2', '\x34', '\x35', '\a', '\b', '\x2', '\x2', '\x35', '\x37', '\x5', 
		'\x4', '\x3', '\x4', '\x36', '*', '\x3', '\x2', '\x2', '\x2', '\x36', 
		'-', '\x3', '\x2', '\x2', '\x2', '\x36', '\x30', '\x3', '\x2', '\x2', 
		'\x2', '\x36', '\x33', '\x3', '\x2', '\x2', '\x2', '\x37', ':', '\x3', 
		'\x2', '\x2', '\x2', '\x38', '\x36', '\x3', '\x2', '\x2', '\x2', '\x38', 
		'\x39', '\x3', '\x2', '\x2', '\x2', '\x39', '\x5', '\x3', '\x2', '\x2', 
		'\x2', ':', '\x38', '\x3', '\x2', '\x2', '\x2', ';', '<', '\x5', '\b', 
		'\x5', '\x2', '<', '=', '\x5', '\n', '\x6', '\x2', '=', '\a', '\x3', '\x2', 
		'\x2', '\x2', '>', '?', '\a', '\xF', '\x2', '\x2', '?', '\t', '\x3', '\x2', 
		'\x2', '\x2', '@', '\x42', '\a', '\x3', '\x2', '\x2', '\x41', '\x43', 
		'\x5', '\f', '\a', '\x2', '\x42', '\x41', '\x3', '\x2', '\x2', '\x2', 
		'\x42', '\x43', '\x3', '\x2', '\x2', '\x2', '\x43', '\x44', '\x3', '\x2', 
		'\x2', '\x2', '\x44', '\x45', '\a', '\x4', '\x2', '\x2', '\x45', '\v', 
		'\x3', '\x2', '\x2', '\x2', '\x46', 'K', '\x5', '\xE', '\b', '\x2', 'G', 
		'H', '\a', '\t', '\x2', '\x2', 'H', 'J', '\x5', '\xE', '\b', '\x2', 'I', 
		'G', '\x3', '\x2', '\x2', '\x2', 'J', 'M', '\x3', '\x2', '\x2', '\x2', 
		'K', 'I', '\x3', '\x2', '\x2', '\x2', 'K', 'L', '\x3', '\x2', '\x2', '\x2', 
		'L', '\r', '\x3', '\x2', '\x2', '\x2', 'M', 'K', '\x3', '\x2', '\x2', 
		'\x2', 'N', 'O', '\x5', '\x4', '\x3', '\x2', 'O', '\xF', '\x3', '\x2', 
		'\x2', '\x2', 'P', 'Q', '\a', '\xF', '\x2', '\x2', 'Q', '\x11', '\x3', 
		'\x2', '\x2', '\x2', 'R', 'S', '\x5', '\x14', '\v', '\x2', 'S', 'T', '\x5', 
		'\x18', '\r', '\x2', 'T', 'U', '\x5', '\x16', '\f', '\x2', 'U', '\x13', 
		'\x3', '\x2', '\x2', '\x2', 'V', 'W', '\a', '\n', '\x2', '\x2', 'W', '\x15', 
		'\x3', '\x2', '\x2', '\x2', 'X', 'Y', '\a', '\v', '\x2', '\x2', 'Y', '\x17', 
		'\x3', '\x2', '\x2', '\x2', 'Z', '[', '\a', '\xE', '\x2', '\x2', '[', 
		'\x19', '\x3', '\x2', '\x2', '\x2', '\\', '^', '\a', '\b', '\x2', '\x2', 
		']', '\\', '\x3', '\x2', '\x2', '\x2', ']', '^', '\x3', '\x2', '\x2', 
		'\x2', '^', '_', '\x3', '\x2', '\x2', '\x2', '_', '\x61', '\a', '\r', 
		'\x2', '\x2', '`', '\x62', '\a', '\f', '\x2', '\x2', '\x61', '`', '\x3', 
		'\x2', '\x2', '\x2', '\x61', '\x62', '\x3', '\x2', '\x2', '\x2', '\x62', 
		'\x1B', '\x3', '\x2', '\x2', '\x2', '\t', '(', '\x36', '\x38', '\x42', 
		'K', ']', '\x61',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
