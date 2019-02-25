using Moq;
using System;
using XUnitDemo2.Calculator;
using Xunit;

namespace XUnitTestProject2.Calculator
{
    public class CalculatorTests : IDisposable
    {
        private MockRepository mockRepository;



        public CalculatorTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        public void Dispose()
        {
            this.mockRepository.VerifyAll();
        }

        private XUnitDemo2.Calculator.Calculator CreateCalculator()
        {
            return new XUnitDemo2.Calculator.Calculator();
        }

        [Fact]
        public void Add_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateCalculator();
            int x = 5;
            int y = 2;

            // Act
            var result = unitUnderTest.Add(
                x,
                y);

            // Assert
            Assert.Equal(result, 7);
        }

        [Fact]
        public void Divide_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateCalculator();
            int x = 10;
            int y = 5;

            // Act
            var result = unitUnderTest.Divide(
                x,
                y);

            // Assert
            Assert.Equal(result, 2);
        }

        [Fact]
        public void Multiply_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateCalculator();
            int x = 5;
            int y = 2;

            // Act
            var result = unitUnderTest.Multiply(
                x,
                y);

            // Assert
            Assert.Equal(result, 10);
        }

        [Fact]
        public void Subtract_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateCalculator();
            int x = 9;
            int y = 2;

            // Act
            var result = unitUnderTest.Subtract(
                x,
                y);

            // Assert
            Assert.Equal(result, 7);
        }
    }
}
