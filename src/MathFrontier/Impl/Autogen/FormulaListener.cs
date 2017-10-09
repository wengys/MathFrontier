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
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="FormulaParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
internal interface IFormulaListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="FormulaParser.formula"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFormula([NotNull] FormulaParser.FormulaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FormulaParser.formula"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFormula([NotNull] FormulaParser.FormulaContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NumeralValue</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumeralValue([NotNull] FormulaParser.NumeralValueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NumeralValue</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumeralValue([NotNull] FormulaParser.NumeralValueContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ExpressionDiv</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionDiv([NotNull] FormulaParser.ExpressionDivContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExpressionDiv</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionDiv([NotNull] FormulaParser.ExpressionDivContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Variable</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariable([NotNull] FormulaParser.VariableContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Variable</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariable([NotNull] FormulaParser.VariableContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ExpressionMult</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionMult([NotNull] FormulaParser.ExpressionMultContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExpressionMult</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionMult([NotNull] FormulaParser.ExpressionMultContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ExpressionMinus</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionMinus([NotNull] FormulaParser.ExpressionMinusContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExpressionMinus</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionMinus([NotNull] FormulaParser.ExpressionMinusContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>MethodInvok</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodInvok([NotNull] FormulaParser.MethodInvokContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>MethodInvok</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodInvok([NotNull] FormulaParser.MethodInvokContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>PropertyInvok</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPropertyInvok([NotNull] FormulaParser.PropertyInvokContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>PropertyInvok</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPropertyInvok([NotNull] FormulaParser.PropertyInvokContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>BracketsExpression</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBracketsExpression([NotNull] FormulaParser.BracketsExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>BracketsExpression</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBracketsExpression([NotNull] FormulaParser.BracketsExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ExpressionPlus</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionPlus([NotNull] FormulaParser.ExpressionPlusContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExpressionPlus</c>
	/// labeled alternative in <see cref="FormulaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionPlus([NotNull] FormulaParser.ExpressionPlusContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FormulaParser.methodInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodInvocation([NotNull] FormulaParser.MethodInvocationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FormulaParser.methodInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodInvocation([NotNull] FormulaParser.MethodInvocationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FormulaParser.methodName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodName([NotNull] FormulaParser.MethodNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FormulaParser.methodName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodName([NotNull] FormulaParser.MethodNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FormulaParser.methodParameterPart"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodParameterPart([NotNull] FormulaParser.MethodParameterPartContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FormulaParser.methodParameterPart"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodParameterPart([NotNull] FormulaParser.MethodParameterPartContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FormulaParser.methodParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodParameterList([NotNull] FormulaParser.MethodParameterListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FormulaParser.methodParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodParameterList([NotNull] FormulaParser.MethodParameterListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FormulaParser.methodParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodParameter([NotNull] FormulaParser.MethodParameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FormulaParser.methodParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodParameter([NotNull] FormulaParser.MethodParameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FormulaParser.propertyInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPropertyInvocation([NotNull] FormulaParser.PropertyInvocationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FormulaParser.propertyInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPropertyInvocation([NotNull] FormulaParser.PropertyInvocationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FormulaParser.variableReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableReference([NotNull] FormulaParser.VariableReferenceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FormulaParser.variableReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableReference([NotNull] FormulaParser.VariableReferenceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FormulaParser.variableReferenceStart"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableReferenceStart([NotNull] FormulaParser.VariableReferenceStartContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FormulaParser.variableReferenceStart"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableReferenceStart([NotNull] FormulaParser.VariableReferenceStartContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FormulaParser.variableReferenceEnd"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableReferenceEnd([NotNull] FormulaParser.VariableReferenceEndContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FormulaParser.variableReferenceEnd"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableReferenceEnd([NotNull] FormulaParser.VariableReferenceEndContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FormulaParser.variableIndex"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableIndex([NotNull] FormulaParser.VariableIndexContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FormulaParser.variableIndex"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableIndex([NotNull] FormulaParser.VariableIndexContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="FormulaParser.numeral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumeral([NotNull] FormulaParser.NumeralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="FormulaParser.numeral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumeral([NotNull] FormulaParser.NumeralContext context);
}
