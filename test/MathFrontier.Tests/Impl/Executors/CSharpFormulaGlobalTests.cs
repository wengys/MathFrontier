using System.Threading.Tasks;
using FakeItEasy;
using MathFrontier.Exceptions;
using MathFrontier.Impl.Executors;
using MathFrontier.Impl.VariableCoercisonStrategies;
using Xunit;

namespace MathFrontier.Tests.Impl.Executors
{
    public class CSharpFormulaGlobalTests
    {
        [Fact]
        public async Task CoercisonStrategyTest()
        {
            var varName = "foo";
            var varProvider = A.Fake<IVariableProvider>();
            A.CallTo(() => varProvider.GetVarAsync(varName)).Returns(Task.FromResult<double?>(null));
            CSharpFormulaGlobal global = new CSharpFormulaGlobal(
               new NullNotAllowedStrategy(),

               new FormulaEvaluatingContext
               {
                   VariableProvider = varProvider
               });

            await Assert.ThrowsAsync<CoerceVariableFailException>(async () =>
            {
                var actual = await global.Var(varName);
            });
        }
    }
}