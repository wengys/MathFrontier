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


using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IFormulaListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
internal partial class FormulaBaseListener : IFormulaListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="FormulaParser.formula"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFormula([NotNull] FormulaParser.FormulaContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FormulaParser.formula"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFormula([NotNull] FormulaParser.FormulaContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>NumeralValue</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumeralValue([NotNull] FormulaParser.NumeralValueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>NumeralValue</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumeralValue([NotNull] FormulaParser.NumeralValueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ExpressionDiv</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpressionDiv([NotNull] FormulaParser.ExpressionDivContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExpressionDiv</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpressionDiv([NotNull] FormulaParser.ExpressionDivContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Variable</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariable([NotNull] FormulaParser.VariableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Variable</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariable([NotNull] FormulaParser.VariableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ExpressionMult</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpressionMult([NotNull] FormulaParser.ExpressionMultContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExpressionMult</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpressionMult([NotNull] FormulaParser.ExpressionMultContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ExpressionMinus</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpressionMinus([NotNull] FormulaParser.ExpressionMinusContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExpressionMinus</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpressionMinus([NotNull] FormulaParser.ExpressionMinusContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>MethodInvok</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodInvok([NotNull] FormulaParser.MethodInvokContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>MethodInvok</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodInvok([NotNull] FormulaParser.MethodInvokContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>BracketsExpression</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBracketsExpression([NotNull] FormulaParser.BracketsExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>BracketsExpression</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBracketsExpression([NotNull] FormulaParser.BracketsExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ExpressionPlus</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpressionPlus([NotNull] FormulaParser.ExpressionPlusContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExpressionPlus</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpressionPlus([NotNull] FormulaParser.ExpressionPlusContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="FormulaParser.methodInvocation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodInvocation([NotNull] FormulaParser.MethodInvocationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FormulaParser.methodInvocation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodInvocation([NotNull] FormulaParser.MethodInvocationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="FormulaParser.methodName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodName([NotNull] FormulaParser.MethodNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FormulaParser.methodName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodName([NotNull] FormulaParser.MethodNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="FormulaParser.methodParameterPart"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodParameterPart([NotNull] FormulaParser.MethodParameterPartContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FormulaParser.methodParameterPart"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodParameterPart([NotNull] FormulaParser.MethodParameterPartContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="FormulaParser.methodParameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodParameterList([NotNull] FormulaParser.MethodParameterListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FormulaParser.methodParameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodParameterList([NotNull] FormulaParser.MethodParameterListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="FormulaParser.methodParameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodParameter([NotNull] FormulaParser.MethodParameterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FormulaParser.methodParameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodParameter([NotNull] FormulaParser.MethodParameterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="FormulaParser.variableReference"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableReference([NotNull] FormulaParser.VariableReferenceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FormulaParser.variableReference"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableReference([NotNull] FormulaParser.VariableReferenceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="FormulaParser.variableReferenceStart"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableReferenceStart([NotNull] FormulaParser.VariableReferenceStartContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FormulaParser.variableReferenceStart"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableReferenceStart([NotNull] FormulaParser.VariableReferenceStartContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="FormulaParser.variableReferenceEnd"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableReferenceEnd([NotNull] FormulaParser.VariableReferenceEndContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FormulaParser.variableReferenceEnd"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableReferenceEnd([NotNull] FormulaParser.VariableReferenceEndContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="FormulaParser.variableIndex"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableIndex([NotNull] FormulaParser.VariableIndexContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FormulaParser.variableIndex"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableIndex([NotNull] FormulaParser.VariableIndexContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="FormulaParser.numeral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumeral([NotNull] FormulaParser.NumeralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="FormulaParser.numeral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumeral([NotNull] FormulaParser.NumeralContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
