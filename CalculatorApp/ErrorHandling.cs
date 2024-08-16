using System;
using Microsoft.Extensions.Logging;

namespace CalculatorApp
{
    public static class ErrorHandling
    {
        public static double ReadDoubleInput(string? input)
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
            var programLogger = LoggerProvider.CreateLogger<Program>();
            switch (ex)
            {
                case FormatException _:
                    Console.WriteLine($"Input error: {ex.Message}");
                    programLogger.LogError($"Format Error: {ex}");
                    break;
                case DivideByZeroException _:
                    Console.WriteLine($"Math error: {ex.Message}");
                    programLogger.LogError($"Division Error: {ex}");
                    break;
                case InvalidOperationException _:
                    Console.WriteLine($"Operation error: {ex.Message}");
                    programLogger.LogError($"Operation Error: {ex}");
                    break;
                default:
                    Console.WriteLine($"Unexpected error: {ex.Message}");
                    programLogger.LogError($"Unexpected Error: {ex}");
                    break;
            }
        }
    }
}
