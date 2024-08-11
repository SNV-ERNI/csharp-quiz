using System;

namespace CalculatorApp
{
    public static class ErrorHandling
    {
        public static double ReadDoubleInput(string input)
        {
            if (double.TryParse(input, out double result))
            {
                return result;
            }
            else
            {
                throw new FormatException("Invalid input. Please enter numeric values.");
            }
        }

        public static void HandleException(Exception ex)
        {
            switch (ex)
            {
                case FormatException _:
                    Console.WriteLine($"Input error: {ex.Message}");
                    break;
                case DivideByZeroException _:
                    Console.WriteLine($"Math error: {ex.Message}");
                    break;
                case InvalidOperationException _:
                    Console.WriteLine($"Operation error: {ex.Message}");
                    break;
                default:
                    Console.WriteLine($"Unexpected error: {ex.Message}");
                    break;
            }
        }
    }
}
