using MathFrontier.Exceptions;
using MathFrontier.Impl.VariableCoercisonStrategies;
using Xunit;

namespace MathFrontier.Tests.Impl.VariableCoercisonStrategies
{
    public class NullNotAllowedStrategyTests
    {
        [Fact]
        public void ThrowWhenNull()
        {
            var strategy = new NullNotAllowedStrategy();

            Assert.Throws<CoerceVariableFailException>(() =>
            {
                strategy.CoerceValue("foo", null);
            });
        }

        [Fact]
        public void ReturnOriginalWhenNotNull()
        {
            var strategy = new NullNotAllowedStrategy();
            var expected = 123.45;

            var actual = strategy.CoerceValue("foo", expected);

            Assert.Equal(expected, actual);
        }
    }
}