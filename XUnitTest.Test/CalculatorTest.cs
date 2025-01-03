using System;
using XUnitTest.APP;

namespace XUnitTest.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void AddTest()
        {
            // Arrange
            int a = 5;
            int b = 20;
            Calculator calculator = new(); 

            // Act
            int total = calculator.Add(a, b);

            // Assert
            Assert.Equal<int>(25, total);

        }
    }
}