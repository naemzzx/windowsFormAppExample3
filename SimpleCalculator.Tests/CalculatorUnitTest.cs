using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorUnitTest
    {
        [Theory]
        [InlineData(3,2,5)]
        [InlineData(0,0,0)]
        [InlineData(double.MaxValue,10,double.MaxValue)]
        [InlineData(double.MaxValue, double.MaxValue, double.MaxValue)] // good case for study
        [InlineData(double.MinValue, 10, double.MinValue)]
        [InlineData(double.MinValue, double.MinValue, double.MinValue)] // good case for study
        [InlineData(-5, 5, 0)]
        [InlineData(double.MinValue, double.MaxValue, 0)]
        public void Add_ValuesShouldCalculate(double x, double y, double expected) 
        {
            // Arrange
            //double expected = 5;

            // Act
            double actual = CalculatorOperations.Add(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 2, 1)]
        [InlineData(0, 0, 0)]
        [InlineData(double.MaxValue, 10, double.MaxValue)]
        [InlineData(double.MaxValue, double.MinValue, double.MaxValue)] // good case for study
        [InlineData(double.MinValue, 10, double.MinValue)]
        [InlineData(double.MinValue, double.MaxValue, double.MinValue)] // good case for study
        [InlineData(-5, 5, -10)]
        public void subtract_ValuesShouldCalculate(double x, double y, double expected)
        {
            // Arrange

            // Act
            double actual = CalculatorOperations.Subtract(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData(3, 2, 6)]
        [InlineData(0, 0, 0)]
        [InlineData(double.MaxValue, 2, double.MaxValue)] // good case for study
        [InlineData(double.MinValue, 2, double.MinValue)] // good case for study
        [InlineData(double.MaxValue, double.MinValue, double.MinValue)] // good case for study
        [InlineData(double.MinValue, double.MinValue, double.MaxValue)] // good case for study
        [InlineData(-5, 5, -25)]
        public void Multiply_ValuesShouldCalculate(double x, double y, double expected)
        {
            // Arrange

            // Act
            double actual = CalculatorOperations.Multiply(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 2, 1.5)]
        [InlineData(0, 0, 0)] // good case for study
        [InlineData(double.MaxValue, 2, (double.MaxValue) / 2)] // good case for study
        [InlineData(double.MinValue, 2, (double.MinValue) / 2)] // good case for study
        [InlineData(-5, 5, -1)]
        [InlineData(-5, 0, 0)] // good case for study
        public void Divide_ValuesShouldCalculate(double x, double y, double expected)
        {
            // Arrange

            // Act
            double actual = CalculatorOperations.divide(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
