using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using MathFrontier.Exceptions;
using System.Collections.Generic;
using System.IO;
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
        public string Interpret(string formula)
        {
            AntlrInputStream input = new AntlrInputStream(formula);
            FormulaLexer lexer = new FormulaLexer(input);
            lexer.RemoveErrorListeners();
            lexer.AddErrorListener(LexerErrorListener.Instance);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            FormulaParser parser = new FormulaParser(tokens);
            parser.RemoveErrorListeners();
            parser.AddErrorListener(ParserErrorListener.Instance);
            FormulaCSListener listener = new FormulaCSListener();

            ParseTreeWalker walker = new ParseTreeWalker();

            walker.Walk(listener, parser.formula());
            return listener.Result;
        }

        internal class MethodParamInfo
        {
            public int Total { get; set; }
            public int Current { get; set; }
        }

        internal class FormulaCSListener : FormulaBaseListener
        {
            private Stack<Stack<string>> opStacks = new Stack<Stack<string>>(); //符号栈
            private Stack<MethodParamInfo> methodParamsStack = new Stack<MethodParamInfo>(); //方法栈

            private StringBuilder resultBuilder = new StringBuilder();

            public string Result
            {
                get
                {
                    return resultBuilder.ToString();
                }
            }

            public override void EnterMethodInvocation([NotNull] FormulaParser.MethodInvocationContext context)
            {
                methodParamsStack.Push(new MethodParamInfo());
                opStacks.Push(new Stack<string>());
            }

            public override void ExitMethodInvocation([NotNull] FormulaParser.MethodInvocationContext context)
            {
                opStacks.Pop();
                TryPopOp();
            }

            public override void EnterMethodName([NotNull] FormulaParser.MethodNameContext context)
            {
                resultBuilder.Append(context.GetText());
            }

            public override void EnterMethodParameterPart([NotNull] FormulaParser.MethodParameterPartContext context)
            {
                resultBuilder.Append("(");
                methodParamsStack.Peek().Total = context.ChildCount - 2; // 去掉括号，所以-2
            }

            public override void ExitMethodParameterPart([NotNull] FormulaParser.MethodParameterPartContext context)
            {
                resultBuilder.Append(")");
                methodParamsStack.Pop();
                TryPopOp();
            }

            public override void EnterMethodParameter([NotNull] FormulaParser.MethodParameterContext context)
            {
                if (methodParamsStack.Peek().Current > 0)
                {
                    resultBuilder.Append(",");
                }
                methodParamsStack.Peek().Current++;
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

            public override void ExitPropertyInvocation([NotNull] FormulaParser.PropertyInvocationContext context)
            {
                var propertyName = context.GetText();
                resultBuilder.Append(propertyName);
                TryPopOp();
            }

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