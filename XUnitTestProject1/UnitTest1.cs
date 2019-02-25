using System;
using XUnitDemo2.Calculator;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void PassingTest()
        {
            //Arrange
            Calculator. calculator = new Calculator();

            // Act
            int integerResult = calculator.Add(4, 2);

            //Assert
            Assert.NotNull(integerResult); // Testing integers
            Assert.Equal(6, integerResult);
            Assert.Equal(4, calculator.Add(2, 2));
        }
    }
}
