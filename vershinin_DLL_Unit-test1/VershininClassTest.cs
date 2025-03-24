using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vershinin_DLL_Unit_test1;
using Xunit;
using MathLibrary;

namespace vershinin_DLL_Unit_test1
{
  

    namespace MathLibrary.Tests
    {
        public class MathOperationsTests
        {
            [Fact]
            public void Factorial_OfPositiveNumber_ReturnsCorrectValue()
            {
                // Arrange
                int n = 5;

                // Act
                int result = MathOperations.Factorial(n);

                // Assert
                Assert.Equal(120, result);
            }

            [Fact]
            public void Factorial_OfZero_ReturnsOne()
            {
                // Arrange
                int n = 0;

                // Act
                int result = MathOperations.Factorial(n);

                // Assert
                Assert.Equal(1, result);
            }

            [Fact]
            public void Factorial_OfNegativeNumber_ThrowsArgumentException()
            {
                // Arrange
                int n = -5;

                // Act & Assert
                Assert.Throws<ArgumentException>(() => MathOperations.Factorial(n));
            }

            [Fact]
            public void SquareRoot_OfPositiveNumber_ReturnsCorrectValue()
            {
                // Arrange
                double number = 16;

                // Act
                double result = MathOperations.SquareRoot(number);

                // Assert
                Assert.Equal(4, result);
            }

            [Fact]
            public void SquareRoot_OfNegativeNumber_ThrowsArgumentException()
            {
                // Arrange
                double number = -16;

                // Act & Assert
                Assert.Throws<ArgumentException>(() => MathOperations.SquareRoot(number));
            }

            [Fact]
            public void Power_OfPositiveNumbers_ReturnsCorrectValue()
            {
                // Arrange
                double baseNumber = 2;
                double exponent = 3;

                // Act
                double result = MathOperations.Power(baseNumber, exponent);

                // Assert
                Assert.Equal(8, result);
            }

            [Fact]
            public void Sin_OfAngle_ReturnsCorrectValue()
            {
                // Arrange
                double angle = Math.PI / 2; // 90 градусов в радианах

                // Act
                double result = MathOperations.Sin(angle);

                // Assert
                Assert.Equal(1, result, 5); // Проверка с точностью до 5 знаков после запятой
            }

            [Fact]
            public void Cos_OfAngle_ReturnsCorrectValue()
            {
                // Arrange
                double angle = 0; // 0 градусов в радианах

                // Act
                double result = MathOperations.Cos(angle);

                // Assert
                Assert.Equal(1, result, 5); // Проверка с точностью до 5 знаков после запятой
            }
        }
    }
}
