using Moq;
using System;
using XUnitDemo2.Calculator;
using Xunit;

namespace XUnitTestProject1.Calculator
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

        private Calculator CreateCalculator()
        {
            return new Calculator();
        }

        [Fact]
        public void Add_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateCalculator();
            int x = TODO;
            int y = TODO;

            // Act
            var result = unitUnderTest.Add(
                x,
                y);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void Divide_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateCalculator();
            int x = TODO;
            int y = TODO;

            // Act
            var result = unitUnderTest.Divide(
                x,
                y);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void Multiply_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateCalculator();
            int x = TODO;
            int y = TODO;

            // Act
            var result = unitUnderTest.Multiply(
                x,
                y);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void Subtract_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateCalculator();
            int x = TODO;
            int y = TODO;

            // Act
            var result = unitUnderTest.Subtract(
                x,
                y);

            // Assert
            Assert.True(false);
        }
    }
}
