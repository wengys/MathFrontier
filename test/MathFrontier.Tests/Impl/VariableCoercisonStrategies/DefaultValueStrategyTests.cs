using MathFrontier.Impl.VariableCoercisonStrategies;
using Xunit;

namespace MathFrontier.Tests.Impl.VariableCoercisonStrategies
{
    public class DefaultValueStrategyTests
    {
        [Fact]
        public void DefaultWhenNull()
        {
            var strategy = new DefaultValueStrategy();
            var expected = 0;

            var actual = strategy.CoerceValue("foo", null);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnOriginalWhenNotNull()
        {
            var strategy = new DefaultValueStrategy();
            var expected = 123.45;

            var actual = strategy.CoerceValue("foo", expected);

            Assert.Equal(expected, actual);
        }
    }
}