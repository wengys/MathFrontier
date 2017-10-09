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
        [InlineData("Cls.Call()", "Cls.Call()")]
        [InlineData("Cls.Call(1)", "Cls.Call(1)")]
        [InlineData("Cls.Call(${参数})", "Cls.Call(await Var(\"参数\"))")]
        [InlineData("Cls.Call(${参数}) + 2", "Cls.Call(await Var(\"参数\"))+2")]
        [InlineData("1 + Cls.Call(${参数})", "1+Cls.Call(await Var(\"参数\"))")]
        [InlineData("Cls.Call(${参数}+1, 2)", "Cls.Call(await Var(\"参数\")+1,2)")]
        [InlineData("Cls.Call(Cls.SubCall(1), 2)", "Cls.Call(Cls.SubCall(1),2)")]
        //
        [InlineData("Math.PI", "Math.PI")]
        [InlineData("Math.PI + 2", "Math.PI+2")]
        [InlineData("1 + Math.PI", "1+Math.PI")]
        public void InterpretTest(string expression, string expected)
        {
            var interpreter = new FormulaCSInterpreter();

            var actual = interpreter.Interpret(expression);

            Assert.Equal(expected, actual);
        }
    }
}