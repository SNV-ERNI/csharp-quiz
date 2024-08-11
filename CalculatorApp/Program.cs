using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the first number:");
                double num1 = ErrorHandling.ReadDoubleInput(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                double num2 = ErrorHandling.ReadDoubleInput(Console.ReadLine());

                Console.WriteLine("Enter the operation (add, subtract, multiply, divide):");
                string operation = Console.ReadLine()?.ToLower() ?? string.Empty;

                var calculator = new Calculator();
                double result = calculator.PerformOperation(num1, num2, operation);

                Console.WriteLine($"The result is: {result}");
            }
            catch (Exception ex)
            {
                ErrorHandling.HandleException(ex);
            }
            finally
            {
                Console.WriteLine("Calculation attempt finished.");
            }
        }
    }
}
