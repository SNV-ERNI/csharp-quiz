using NUnit.Framework;

namespace CalculatorApp.UnitTests;

[TestFixture]
public class CalculatorTest
{
    private Calculator _calculator;

    [SetUp]
    public void SetUp()
    {
        _calculator = new Calculator();
    }

    [Test]
    public void Add_ValidInputs_ReturnsCorrectResult()
    {
        // Arrange
        double num1 = 5;
        double num2 = 3;
        string operation = "add";

        // Act
        double result = _calculator.PerformOperation(num1, num2, operation);

        // Assert
        Assert.AreEqual(8, result);
    }

    [Test]
    public void Subtract_ValidInputs_ReturnsCorrectResult()
    {
        // Arrange
        double num1 = 5;
        double num2 = 3;
        string operation = "subtract";

        // Act
        double result = _calculator.PerformOperation(num1, num2, operation);

        // Assert
        Assert.AreEqual(2, result);
    }

    [Test]
    public void Multiply_ValidInputs_ReturnsCorrectResult()
    {
        // Arrange
        double num1 = 5;
        double num2 = 3;
        string operation = "multiply";

        // Act
        double result = _calculator.PerformOperation(num1, num2, operation);

        // Assert
        Assert.AreEqual(15, result);
    }

    [Test]
    public void Divide_ValidInputs_ReturnsCorrectResult()
    {
        // Arrange
        double num1 = 6;
        double num2 = 3;
        string operation = "divide";

        // Act
        double result = _calculator.PerformOperation(num1, num2, operation);

        // Assert
        Assert.AreEqual(2, result);
    }

    [Test]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        double num1 = 6;
        double num2 = 0;
        string operation = "divide";

        // Act & Assert
        var ex = Assert.Throws<DivideByZeroException>(() => _calculator.PerformOperation(num1, num2, operation));
        Assert.That(ex.Message, Is.EqualTo("Cannot divide by zero."));
    }

    [Test]
    public void ReadDoubleInput_InvalidInput_ThrowsFormatException()
    {
        // Arrange
        string invalidInput = "abc";

        // Act & Assert
        var ex = Assert.Throws<FormatException>(() => ErrorHandling.ReadDoubleInput(invalidInput));
        Assert.That(ex.Message, Is.EqualTo("Invalid input. Please enter numeric values."));
    }

    [Test]
    public void PerformOperation_UnsupportedOperation_ThrowsInvalidOperationException()
    {
        // Arrange
        double num1 = 6;
        double num2 = 3;
        string operation = "unsupported";

        // Act & Assert
        var ex = Assert.Throws<InvalidOperationException>(() => _calculator.PerformOperation(num1, num2, operation));
        Assert.That(ex.Message, Is.EqualTo("The specified operation is not supported."));
    }
}