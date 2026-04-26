using CalculatorConsoleApp.Helpers;
using CalculatorConsoleApp.Models;

namespace CalculatorConsoleApp.Services;

public class CalculatorApp : ICalculatorApp
{
    private readonly ICalculatorService _calculatorService;

    public CalculatorApp(ICalculatorService calculatorService)
    {
        _calculatorService = calculatorService;
    }

    public void Run()
    {
        Console.Title = "Simple Calculator";

        var shouldContinue = true;

        while (shouldContinue)
        {
            Console.Clear();
            ShowMenu();

            var choice = InputHelper.ReadMenuChoice("Choose an option: ");

            switch (choice)
            {
                case CalculatorOption.Add:
                case CalculatorOption.Subtract:
                case CalculatorOption.Multiply:
                case CalculatorOption.Divide:
                case CalculatorOption.Modulus:
                case CalculatorOption.Power:
                    RunCalculation(choice.Value);
                    break;
                case CalculatorOption.ShowHistory:
                    ShowHistory();
                    break;
                case CalculatorOption.ClearHistory:
                    ClearHistory();
                    break;
                case CalculatorOption.Exit:
                    shouldContinue = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    InputHelper.Pause();
                    break;
            }
        }
    }

    private void ShowMenu()
    {
        Console.WriteLine("=== Simple Calculator ===");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");
        Console.WriteLine("5. Modulus");
        Console.WriteLine("6. Power");
        Console.WriteLine("7. Show last 5 calculations");
        Console.WriteLine("8. Clear history");
        Console.WriteLine("0. Exit");
        Console.WriteLine();
    }

    private void RunCalculation(CalculatorOption choice)
    {
        var title = GetCalculationTitle(choice);
        var symbol = GetCalculationSymbol(choice);

        Console.Clear();
        Console.WriteLine($"=== {title} ===");

        var firstNumber = InputHelper.ReadDouble("Enter first number: ");
        var secondNumber = InputHelper.ReadDouble("Enter second number: ");

        try
        {
            var result = CalculateResult(choice, firstNumber, secondNumber);
            var expression = $"{firstNumber} {symbol} {secondNumber}";

            _calculatorService.SaveCalculation(expression, result);

            Console.WriteLine();
            Console.WriteLine($"{expression} = {result}");
        }
        catch (DivideByZeroException exception)
        {
            Console.WriteLine();
            Console.WriteLine(exception.Message);
        }

        InputHelper.Pause();
    }

    private static string GetCalculationTitle(CalculatorOption choice)
    {
        return choice switch
        {
            CalculatorOption.Add => "Addition",
            CalculatorOption.Subtract => "Subtraction",
            CalculatorOption.Multiply => "Multiplication",
            CalculatorOption.Divide => "Division",
            CalculatorOption.Modulus => "Modulus",
            CalculatorOption.Power => "Power",
            _ => "Calculation"
        };
    }

    private static string GetCalculationSymbol(CalculatorOption choice)
    {
        return choice switch
        {
            CalculatorOption.Add => "+",
            CalculatorOption.Subtract => "-",
            CalculatorOption.Multiply => "*",
            CalculatorOption.Divide => "/",
            CalculatorOption.Modulus => "%",
            CalculatorOption.Power => "^",
            _ => "?"
        };
    }

    private double CalculateResult(CalculatorOption choice, double firstNumber, double secondNumber)
    {
        switch (choice)
        {
            case CalculatorOption.Add:
                return _calculatorService.Add(firstNumber, secondNumber);
            case CalculatorOption.Subtract:
                return _calculatorService.Subtract(firstNumber, secondNumber);
            case CalculatorOption.Multiply:
                return _calculatorService.Multiply(firstNumber, secondNumber);
            case CalculatorOption.Divide:
                return _calculatorService.Divide(firstNumber, secondNumber);
            case CalculatorOption.Modulus:
                return _calculatorService.Modulus(firstNumber, secondNumber);
            case CalculatorOption.Power:
                return _calculatorService.Power(firstNumber, secondNumber);
            default:
                throw new InvalidOperationException("Invalid calculation option selected.");
        }
    }

    private void ShowHistory()
    {
        Console.Clear();
        Console.WriteLine("=== Last 5 Calculations ===");

        var history = _calculatorService.GetCalculationHistory();

        if (history.Count == 0)
        {
            Console.WriteLine("No calculations found.");
            InputHelper.Pause();
            return;
        }

        foreach (var item in history)
        {
            Console.WriteLine($"{item.Expression} = {item.Result} | {item.CreatedAt:g}");
        }

        InputHelper.Pause();
    }

    private void ClearHistory()
    {
        Console.Clear();
        Console.WriteLine("=== Clear History ===");

        _calculatorService.ClearCalculationHistory();

        Console.WriteLine("Calculation history cleared.");
        InputHelper.Pause();
    }
}
