using MathFrontier.Exceptions;
using MathFrontier.Impl.Interpreters;
using Xunit;

namespace MathFrontier.Tests.Impl.Intepreter
{
    public class FormulaCSInterpreterTests
    {
        [Theory]
        [InlineData("1", "1")]
        [InlineData("-1", "-1")]
        [InlineData("1%", "1/100.0")]
        [InlineData("-1%", "-1/100.0")]
        [InlineData("1 + 2", "1+2")]
        [InlineData("1 + -2", "1+-2")]
        [InlineData("( 1 )", "(1)")]
        [InlineData("(1+2) * 3", "(1+2)*3")]
        //
        [InlineData("1.0", "1.0")]
        [InlineData("-1.0", "-1.0")]
        [InlineData("1.0%", "1.0/100.0")]
        [InlineData("-1.0%", "-1.0/100.0")]
        [InlineData("1.0 + 2.0", "1.0+2.0")]
        [InlineData("1.0 + -2.0", "1.0+-2.0")]
        [InlineData("( 1.0 )", "(1.0)")]
        [InlineData("(1.0+2.0) * 3.0", "(1.0+2.0)*3.0")]
        //
        [InlineData("${a}", "await Var(\"a\")")]
        [InlineData("${参数}", "await Var(\"参数\")")]
        //[InlineData("${参数@`{\"foo\":\"ba\\\"r\"}`}", "await Var(\"参数\",\"{\\\"foo\\\":\\\"ba\\\\\\\"r\\\"}\")")]
        [InlineData("${参数}+1", "await Var(\"参数\")+1")]
        [InlineData("1 + ${参数}", "1+await Var(\"参数\")")]
        [InlineData("(${参数} + 2) * 3", "(await Var(\"参数\")+2)*3")]
        //
        [InlineData("Cls.Call0()", "Cls.Call0()")]
        [InlineData("Cls.Call(1)", "Cls.Call(1)")]
        [InlineData("Cls.Call(${参数})", "Cls.Call(await Var(\"参数\"))")]
        [InlineData("Cls.Call(${参数}) + 2", "Cls.Call(await Var(\"参数\"))+2")]
        [InlineData("1 + Cls.Call(${参数})", "1+Cls.Call(await Var(\"参数\"))")]
        [InlineData("Cls.Call2(${参数}+1, 2)", "Cls.Call2(await Var(\"参数\")+1,2)")]
        [InlineData("Cls.Call2(Cls.SubCall(1), 2)", "Cls.Call2(Cls.SubCall(1),2)")]
        //
        //[InlineData("Math.PI", "Math.PI")]
        //[InlineData("Math.PI + 2", "Math.PI+2")]
        //[InlineData("1 + Math.PI", "1+Math.PI")]
        public void InterpretTest(string expression, string expected)
        {
            var interpreter = new FormulaCSInterpreter();

            var actual = interpreter.Interpret(expression,typeof(Cls));

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Foo.Bar()", "不支持的方法: Foo.Bar")]
        [InlineData("Cls.Bar()", "不支持的方法: Cls.Bar")]
        [InlineData("Cls.Call0(1)", "Cls.Call0 需要 0 个参数，实际 1 个")]
        public void InvalidMethodCallTest(string formula,string messageSegment)
        {
            var interpreter = new FormulaCSInterpreter();
            try
            {
                var actual = interpreter.Interpret(formula, typeof(Cls));
                Assert.False(true);
            }
            catch (SyntaxErrorException see)
            {
                Assert.Contains(messageSegment,see.Message);
            }
        }

        public class Cls
        {
            public static double Call0()
            {
                return 0;
            }
            public static double Call(double a)
            {
                return a;
            }
            public static double Call2(double a,double b)
            {
                return a+b;
            }

            public static double SubCall(double a)
            {
                return a;
            }
        }
    }
}