using NUnit.Framework; // NUnit framework for writing and executing unit tests
using CalculatorApp; // Namespace of the application to be tested

namespace CalculatorAppTests // Namespace for the test project
{
    [TestFixture] // Indicates that this class contains NUnit tests
    public class CalculatorTests
    {
        // Instance of the Calculator class to be tested
        public Calculator calculator;

        [SetUp] // This method runs before each test, ensuring a fresh setup
        public void Setup()
        {
            // Initialize the Calculator object before each test
            calculator = new Calculator();
        }

        [Test] // Marks this method as a test case
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange: Set up the input values for the test
            int a = 3;
            int b = 5;

            // Act: Call the Add method to calculate the sum
            int result = calculator.Add(a, b);

            // Assert: Verify that the result matches the expected output
            Assert.AreEqual(8, result); // Expecting 3 + 5 = 8
        }

        [Test] // Marks this method as a test case
        public void Subtract_ShouldReturnCorrectDifference()
        {
            // Arrange: Set up the input values for the test
            int a = 10;
            int b = 4;

            // Act: Call the Subtract method to calculate the difference
            int result = calculator.Subtract(a, b);

            // Assert: Verify that the result matches the expected output
            Assert.AreEqual(6, result); // Expecting 10 - 4 = 6
        }

        [Test] // Marks this method as a test case
        public void Multiply_ShouldReturnCorrectProduct()
        {
            // Arrange: Set up the input values for the test
            int a = 2;
            int b = 3;

            // Act: Call the Multiply method to calculate the product
            int result = calculator.Multiply(a, b);

            // Assert: Verify that the result matches the expected output
            Assert.AreEqual(6, result); // Expecting 2 * 3 = 6
        }

        [Test] // Marks this method as a test case
        public void Divide_ShouldReturnCorrectQuotient()
        {
            // Arrange: Set up the input values for the test
            double a = 10;
            double b = 2;

            // Act: Call the Divide method to calculate the quotient
            double result = calculator.Divide(a, b);

            // Assert: Verify that the result matches the expected output
            Assert.AreEqual(5.0, result); // Expecting 10 / 2 = 5.0
        }
    }
}
