namespace CalculatorApp;

public class Calculator
{
    public double Add(double num1, double num2)
    {
        return num1 + num2;
    }

    public double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    public double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    public double Divide(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return num1 / num2;
    }
    public double PerformOperation(double num1, double num2, string operation)
    {
        if (operation == "add")
        {
            return Add(num1, num2);
        }
        else if (operation == "subtract")
        {
            return Subtract(num1, num2);
        }
        else if (operation == "multiply")
        {
            return Multiply(num1, num2);
        }
        else if (operation == "divide")
        {
            return Divide(num1, num2);
        }
        else
        {
            throw new InvalidOperationException("The specified operation is not supported.");
        }
        // TODO: Implement the PerformOperation method
        throw new NotImplementedException();
    }
}