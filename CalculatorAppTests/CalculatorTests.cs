using NUnit.Framework;
using CalculatorApp;

namespace CalculatorAppTests
{
    [TestFixture] // Indicates that this class contains NUnit tests
    public class CalculatorTests
    {
        public Calculator calculator;

        [SetUp]
        public void Setup()
        {
            // Initialize the Calculator object before each test
            calculator = new Calculator();
        }

        [Test]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            int a = 3;
            int b = 5;

            // Act
            int result = calculator.Add(a, b);

            // Assert
            Assert.AreEqual(8, result);
        }

        [Test]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            // Arrange
            int a = 10;
            int b = 4;

            // Act
            int result = calculator.Subtract(a, b);

            // Assert
            Assert.AreEqual(6, result);
        }

        [Test]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            // Arrange
            int a = 2;
            int b = 3;

            // Act
            int result = calculator.Multiply(a, b);

            // Assert
            Assert.AreEqual(6, result);
        }

        [Test]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            // Arrange
            double a = 10;
            double b = 2;

            // Act
            double result = calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(5.0, result);
        }
    }
}
