using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MathLibrary;

namespace vershinin_DLL_Unit_test1
{
  
    namespace MathLibrary
    {
        public class MathOperations
        {
            // Метод для вычисления факториала числа
            public static int Factorial(int n)
            {
                if (n < 0)
                    throw new ArgumentException("Факториал определен только для неотрицательных чисел.");

                int result = 1;
                for (int i = 2; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }

            // Метод для вычисления квадратного корня числа
            public static double SquareRoot(double number)
            {
                if (number < 0)
                    throw new ArgumentException("Квадратный корень из отрицательного числа не определен.");

                return Math.Sqrt(number);
            }

            // Метод для вычисления степени числа
            public static double Power(double baseNumber, double exponent)
            {
                return Math.Pow(baseNumber, exponent);
            }

            // Метод для вычисления синуса угла (в радианах)
            public static double Sin(double angle)
            {
                return Math.Sin(angle);
            }

            // Метод для вычисления косинуса угла (в радианах)
            public static double Cos(double angle)
            {
                return Math.Cos(angle);
            }
        }
    }
}