using System;
using System.Threading.Tasks;
using FakeItEasy;
using MathFrontier.Exceptions;
using MathFrontier.Impl.Executors;
using MathFrontier.Impl.VariableCoercisonStrategies;
using Xunit;

namespace MathFrontier.Tests.Impl.Executors
{
    public class CSharpExecutorTests
    {
        [Theory]
        [InlineData("1", 1.0)]
        [InlineData("-1", -1.0)]
        [InlineData("1 + 2", 3.0)]
        [InlineData("1 + -2", -1.0)]
        [InlineData("( 1 )", 1.0)]
        [InlineData("(1+2) * 3", 9.0)]
        //
        [InlineData("1.0", 1.0)]
        [InlineData("-1.0", -1.0)]
        [InlineData("1.0 + 2.0", 3.0)]
        [InlineData("1.0 + -2.0", -1.0)]
        [InlineData("( 1.0 )", 1.0)]
        [InlineData("(1.0+2.0) * 3.0", 9.0)]
        //
        [InlineData("await Var(\"a\")", 10.0)]
        [InlineData("await Var(\"参数\")", 20.0)]
        [InlineData("await Var(\"参数\")+1", 21.0)]
        [InlineData("1+await Var(\"参数\")", 21.0)]
        [InlineData("(await Var(\"参数\")+2)*3", 66.0)]
        //
        [InlineData("Math.Abs(-1.0)", 1.0)]
        [InlineData("Math.Abs(await Var(\"PI\"))", Math.PI)]
        public async Task EvalExpressionTest(string formula, double expected)
        {
            //var evaluator = new CSharpExecutor(new NullNotAllowedStrategy());
            //var fakeVarProvider = A.Fake<IVariableProvider>();
            //A.CallTo(() => fakeVarProvider.GetVarAsync("a", A<VariableCriteria>.That.IsNotNull()))
            //    .Returns(10);
            //A.CallTo(() => fakeVarProvider.GetVarAsync("参数", A<VariableCriteria>.That.IsNotNull()))
            //    .Returns(20);
            //A.CallTo(() => fakeVarProvider.GetVarAsync("PI", A<VariableCriteria>.That.IsNotNull()))
            //    .Returns(Math.PI);
            //var context = new FormulaEvaluatingContext
            //{
            //    VariableProvider = fakeVarProvider,
            //    DistrictIndicatorResolver = A.Fake<IDistrictIndicatorResolver>(),
            //};

            //var actual = await evaluator.EvalAsync(formula, context);

            //Assert.Equal(expected, actual);

            var evaluator = new CSharpExecutor(typeof(Math),new NullNotAllowedStrategy());
            var fakeVarProvider = A.Fake<IVariableProvider>();
            A.CallTo(() => fakeVarProvider.GetVarAsync("a"))
                .Returns(10);
            A.CallTo(() => fakeVarProvider.GetVarAsync("参数"))
                .Returns(20);
            A.CallTo(() => fakeVarProvider.GetVarAsync("PI"))
                .Returns(Math.PI);
            var context = new FormulaEvaluatingContext
            {
                VariableProvider = fakeVarProvider,
                //DistrictIndicatorResolver = A.Fake<IDistrictIndicatorResolver>(),
            };

            var actual = await evaluator.EvalAsync(formula, context);

            Assert.Equal(expected, actual);
        }

        //[Fact]
        //public async Task EvalNullValueTest()
        //{
        //    var evaluator = new CSharpEvaluatorBackend(new NullNotAllowedStrategy(), new Dictionary<string, IValueCoercionStrategy>());
        //    var noopVarProvider = A.Fake<IVariableProvider>();
        //    var context = new FormulaEvaluatingContext
        //    {
        //        VariableProvider = noopVarProvider
        //    };
        //    var formula = "null";

        //    await Assert.ThrowsAnyAsync<Exception>(async () =>
        //    {
        //        var actual = await evaluator.EvalAsync(formula, context);
        //    });
        //}

        [Fact]
        public async Task EvalNonExistingVariableTest()
        {
            var evaluator = new CSharpExecutor(typeof(Math),new NullNotAllowedStrategy());
            var fakeVarProvider = A.Fake<IVariableProvider>();
            A.CallTo(() => fakeVarProvider.GetVarAsync("a"))
                .Returns(Task.FromResult<double?>(null));
            var context = new FormulaEvaluatingContext
            {
                VariableProvider = fakeVarProvider
            };
            var formula = "await Var(\"a\") + await Var(\"b\") + 3";

            await Assert.ThrowsAsync<CoerceVariableFailException>(() =>
                 evaluator.EvalAsync(formula, context)
            );
        }

        //[Fact]
        //public async Task EvalVariableWithRootDistrictHintTest()
        //{
        //    var formula = "await Var(\"参数\",\"{\\\"District\\\":\\\"Root\\\"}\")";
        //    var expected = 10.0;
        //    var currentDistrict = "1001";
        //    var rootDistrict = "1000";
        //    var fakeDistrictIndicatorResolver = A.Fake<IDistrictIndicatorResolver>();
        //    A.CallTo(() => fakeDistrictIndicatorResolver.Resolve(currentDistrict, "Root")).Returns(rootDistrict);
        //    var evaluator = new CSharpExecutor(new NullNotAllowedStrategy());
        //    var fakeVarProvider = A.Fake<IVariableProvider>();

        //    A.CallTo(() => fakeVarProvider.GetVarAsync("参数", A<VariableCriteria>.That.Matches(c => c.DistrictCode == currentDistrict)))
        //        .Returns(0);
        //    A.CallTo(() => fakeVarProvider.GetVarAsync("参数", A<VariableCriteria>.That.Matches(c => c.DistrictCode == rootDistrict)))
        //         .Returns(expected);
        //    var context = new FormulaEvaluatingContext
        //    {
        //        VariableProvider = fakeVarProvider,
        //        DistrictCode = currentDistrict,
        //        DistrictIndicatorResolver = fakeDistrictIndicatorResolver,
        //    };

        //    var actual = await evaluator.EvalAsync(formula, context);

        //    Assert.Equal(expected, actual);
        //}

        [Fact]
        public async Task IntThrowWhenEvalDivideByConstantZeroTest()
        {
            var evaluator = new CSharpExecutor(typeof(Math),new NullNotAllowedStrategy());
            var fakeVarProvider = A.Fake<IVariableProvider>();
            var context = new FormulaEvaluatingContext
            {
                VariableProvider = fakeVarProvider
            };
            var formula = "1/0";

            await Assert.ThrowsAsync<DivideByZeroException>(() =>
                 evaluator.EvalAsync(formula, context)
            );
        }

        [Fact]
        public async Task DoubleThrowWhenEvalDivideByZeroTest()
        {
            var evaluator = new CSharpExecutor(typeof(Math),new NullNotAllowedStrategy());
            var fakeVarProvider = A.Fake<IVariableProvider>();
            var context = new FormulaEvaluatingContext
            {
                VariableProvider = fakeVarProvider
            };
            var formula = "1.0/0";

            await Assert.ThrowsAsync<DivideByZeroException>(() =>
                 evaluator.EvalAsync(formula, context)
            );
        }

        [Fact]
        public async Task IntThrowWhenEvalDivideByZeroTest()
        {
            var evaluator = new CSharpExecutor(typeof(Math),new NullNotAllowedStrategy());
            var fakeVarProvider = A.Fake<IVariableProvider>();
            A.CallTo(() => fakeVarProvider.GetVarAsync("a"))
                .Returns(0);
            var context = new FormulaEvaluatingContext
            {
                VariableProvider = fakeVarProvider
            };
            var formula = "1/await Var(\"a\")";

            await Assert.ThrowsAsync<DivideByZeroException>(() =>
                 evaluator.EvalAsync(formula, context)
            );
        }
    }
}