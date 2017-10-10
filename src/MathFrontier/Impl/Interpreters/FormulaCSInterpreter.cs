using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using MathFrontier.Exceptions;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace MathFrontier.Impl.Interpreters
{
    /// <summary>
    /// 公式C#翻译器
    /// </summary>
    /// <remarks>
    /// 将公式转换为C#公式
    /// </remarks>
    public class FormulaCSInterpreter
    {
        /// <summary>
        /// 翻译公式
        /// </summary>
        /// <param name="formula">公式</param>
        /// <param name="availableMethodsType">包含公式中可用静态方法的类型</param>
        /// <returns></returns>
        public string Interpret(string formula,Type availableMethodsType)
        {
            AntlrInputStream input = new AntlrInputStream(formula);
            FormulaLexer lexer = new FormulaLexer(input);
            lexer.RemoveErrorListeners();
            lexer.AddErrorListener(LexerErrorListener.Instance);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            FormulaParser parser = new FormulaParser(tokens);
            parser.RemoveErrorListeners();
            parser.AddErrorListener(ParserErrorListener.Instance);
            FormulaCSListener listener = new FormulaCSListener(availableMethodsType);

            ParseTreeWalker walker = new ParseTreeWalker();

            walker.Walk(listener, parser.formula());
            return listener.Result;
        }

        internal class MethodInfo
        {
            public int CurrentParamCount { get; set; }
            public int Total { get; set; }
            public string MethodName { get; set; }
        }

        internal class FormulaCSListener : FormulaBaseListener
        {

            private static readonly ConcurrentDictionary<Type, Dictionary<string, int>> availableMethodTypes
                = new ConcurrentDictionary<Type, Dictionary<string, int>>();

            private readonly Type availableMethodsType;
            private readonly Stack<Stack<string>> opStacks = new Stack<Stack<string>>(); //符号栈
            private readonly Stack<MethodInfo> methodStack = new Stack<MethodInfo>(); //方法栈

            private readonly StringBuilder resultBuilder = new StringBuilder();

            public FormulaCSListener(Type availableMethodsType)
            {
                this.availableMethodsType = availableMethodsType;
                InitAvailableMethodTypes(availableMethodsType);
            }

            

            public string Result
            {
                get
                {
                    return resultBuilder.ToString();
                }
            }

            public override void EnterMethodInvocation([NotNull] FormulaParser.MethodInvocationContext context)
            {
                methodStack.Push(new MethodInfo());
                opStacks.Push(new Stack<string>());
            }

            public override void ExitMethodInvocation([NotNull] FormulaParser.MethodInvocationContext context)
            {
                opStacks.Pop();
                TryPopOp();
            }

            public override void EnterMethodName([NotNull] FormulaParser.MethodNameContext context)
            {
                var methodName = context.GetText();
                var methodParamCount = GetMethodParamCount(methodName);
                var methodParamInfo = methodStack.Peek();
                methodParamInfo.Total = methodParamCount;
                methodParamInfo.MethodName = methodName;
                resultBuilder.Append(context.GetText());
            }

            private int GetMethodParamCount(string methodName)
            {
                if (!availableMethodTypes.TryGetValue(this.availableMethodsType,out var availableMethodParamCounts)
                    || !availableMethodParamCounts.TryGetValue(methodName,out var availableMethodParamCount)
                    )
                {
                    throw new SyntaxErrorException("Parser", "不支持的方法: "+ methodName);
                }
                return availableMethodParamCount;
            }

            public override void EnterMethodParameterPart([NotNull] FormulaParser.MethodParameterPartContext context)
            {
                resultBuilder.Append("(");
            }

            public override void ExitMethodParameterPart([NotNull] FormulaParser.MethodParameterPartContext context)
            {
                var methodInfo = methodStack.Peek();
                if (methodInfo.CurrentParamCount!= methodInfo.Total)
                {
                    throw new SyntaxErrorException("Parser", $"参数数量错误: {methodInfo.MethodName} 需要 {methodInfo.Total} 个参数，实际 {methodInfo.CurrentParamCount} 个");
                }
                resultBuilder.Append(")");
                methodStack.Pop();
                TryPopOp();
            }

            public override void EnterMethodParameter([NotNull] FormulaParser.MethodParameterContext context)
            {
                if (methodStack.Peek().CurrentParamCount > 0)
                {
                    resultBuilder.Append(",");
                }
                methodStack.Peek().CurrentParamCount++;
            }

            public override void EnterFormula([NotNull] FormulaParser.FormulaContext context)
            {
                opStacks.Push(new Stack<string>());
            }

            public override void ExitNumeralValue([NotNull] FormulaParser.NumeralValueContext context)
            {
                var text = context.GetText();

                if (text[text.Length - 1] == '%')
                {
                    text = text.Substring(0, text.Length - 1) + "/100.0";
                }
                resultBuilder.Append(text);
                TryPopOp();
            }

            public override void EnterBracketsExpression([NotNull] FormulaParser.BracketsExpressionContext context)
            {
                opStacks.Push(new Stack<string>());
                resultBuilder.Append("(");
            }

            public override void ExitBracketsExpression([NotNull] FormulaParser.BracketsExpressionContext context)
            {
                resultBuilder.Append(")");
                opStacks.Pop();
                TryPopOp();
            }

            public override void EnterVariableReferenceStart([NotNull] FormulaParser.VariableReferenceStartContext context)
            {
                resultBuilder.Append($"await Var(");
            }

            public override void EnterVariableIndex([NotNull] FormulaParser.VariableIndexContext context)
            {
                resultBuilder.Append($"\"{context.GetText()}\"");
            }

            //public override void EnterVariableIndicator([NotNull] FormulaParser.VariableIndicatorContext context)
            //{
            //    var text = context.children[0].GetText();
            //    var indicatorString = text.Substring(2, text.Length - 3);
            //    //TODO: 检查符合JSON格式
            //    indicatorString = indicatorString.Replace("\\", "\\\\");
            //    indicatorString = indicatorString.Replace("\"", "\\\"");
            //    resultBuilder.Append($",\"{indicatorString}\"");
            //}

            public override void EnterVariableReferenceEnd([NotNull] FormulaParser.VariableReferenceEndContext context)
            {
                resultBuilder.Append($")");
                TryPopOp();
            }

            //public override void ExitPropertyInvocation([NotNull] FormulaParser.PropertyInvocationContext context)
            //{
            //    var propertyName = context.GetText();
            //    resultBuilder.Append(propertyName);
            //    TryPopOp();
            //}

            public override void EnterExpressionPlus([NotNull] FormulaParser.ExpressionPlusContext context)
            {
                opStacks.Peek().Push("+");
            }

            public override void EnterExpressionMinus([NotNull] FormulaParser.ExpressionMinusContext context)
            {
                opStacks.Peek().Push("-");
            }

            public override void EnterExpressionMult([NotNull] FormulaParser.ExpressionMultContext context)
            {
                opStacks.Peek().Push("*");
            }

            public override void EnterExpressionDiv([NotNull] FormulaParser.ExpressionDivContext context)
            {
                opStacks.Peek().Push("/");
            }

            private void TryPopOp()
            {
                var opStack = opStacks.Peek();
                if (opStack.Count > 0)
                {
                    var op = opStack.Pop();
                    resultBuilder.Append(op);
                }
            }

            private static void InitAvailableMethodTypes(Type availableMethodsType)
            {
                availableMethodTypes.GetOrAdd(availableMethodsType, (t) =>
                {
                    var availableMethodParamCounts = new Dictionary<string, int>();
                    var avaibableMethods = t.GetMethods(BindingFlags.Static | BindingFlags.Public);
                    foreach (var avaibableMethod in avaibableMethods)
                    {
                        availableMethodParamCounts[t.Name + "." + avaibableMethod.Name]=avaibableMethod.GetParameters().Length; // 不支持重载
                    }
                    return availableMethodParamCounts;
                });
            }
        }

        private class LexerErrorListener : IAntlrErrorListener<int>
        {
            public static LexerErrorListener Instance { get; } = new LexerErrorListener();

            public void SyntaxError(TextWriter output, IRecognizer recognizer, int offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
            {
                throw new SyntaxErrorException("Lexer", "line " + line + ":" + charPositionInLine + " " + msg);
            }
        }

        private class ParserErrorListener : BaseErrorListener
        {
            public static ParserErrorListener Instance { get; } = new ParserErrorListener();

            public override void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
            {
                throw new SyntaxErrorException("Parser", "line " + line + ":" + charPositionInLine + " " + msg);
            }
        }
    }
}