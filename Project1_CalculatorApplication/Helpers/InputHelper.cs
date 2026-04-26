using CalculatorConsoleApp.Models;

namespace CalculatorConsoleApp.Helpers;

public static class InputHelper
{
    public static CalculatorOption? ReadMenuChoice(string message)
    {
        Console.Write(message);
        var input = Console.ReadLine()?.Trim();

        if (int.TryParse(input, out var number) &&
            Enum.IsDefined(typeof(CalculatorOption), number))
        {
            return (CalculatorOption)number;
        }

        return null;
    }

    public static double ReadDouble(string message)
    {
        while (true)
        {
            Console.Write(message);
            var input = Console.ReadLine();

            if (double.TryParse(input, out var number))
            {
                return number;
            }

            Console.WriteLine("Please enter a valid number.");
        }
    }

    public static void Pause()
    {
        Console.WriteLine();
        Console.Write("Press Enter to continue...");
        Console.ReadLine();
    }
}
