using Xunit;
using Calculator.Logic;
using System;

namespace Calculator.Tests
{
    public class CalculatorEngineTests
    {
        private readonly CalculatorEngine _engine;

        public CalculatorEngineTests()
        {
            _engine = new CalculatorEngine();
        }

        [Theory]
        [InlineData(2, 3, "+", 5)]
        [InlineData(5, 3, "-", 2)]
        [InlineData(2, 3, "X", 6)]
        [InlineData(6, 3, "/", 2)]
        public void Calculate_ShouldReturnCorrectResult(double left, double right, string op, double expected)
        {
            var result = _engine.Calculate(left, right, op);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Calculate_DivideByZero_ShouldThrowException()
        {
            Assert.Throws<DivideByZeroException>(() => _engine.Calculate(5, 0, "/", 0));
        }

        [Fact]
        public void Calculate_InvalidOperator_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => _engine.Calculate(5, 5, "^", 0));
        }
    }
}
