using System;

namespace CalculatorApp
{
    public class Calculator
    {
        // Adds two numbers and returns the result
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Subtracts the second number from the first and returns the result
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        // Multiplies two numbers and returns the result
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        // Divides the first number by the second and returns the result
        public double Divide(double a, double b)
        {
            return (double)a / b;
        }
    }
}
