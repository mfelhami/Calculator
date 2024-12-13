using System;
using CalculatorApp;

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        Console.WriteLine("Welcome to the Calculator Program!");

        Console.WriteLine("Addition: 3 + 5 = " + calculator.Add(3, 5));
        Console.WriteLine("Subtraction: 10 - 4 = " + calculator.Subtract(10, 4));
        Console.WriteLine("Multiplication: 2 * 3 = " + calculator.Multiply(2, 3));
        Console.WriteLine("Division: 10 / 2 = " + calculator.Divide(10, 2));
        Console.WriteLine("Program finished.");
    }
}
