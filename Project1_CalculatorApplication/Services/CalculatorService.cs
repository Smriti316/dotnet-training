using CalculatorConsoleApp.Models;
using CalculatorConsoleApp.Repositories;

namespace CalculatorConsoleApp.Services;

public class CalculatorService : ICalculatorService
{
    private readonly ICalculationHistoryRepository _calculationHistoryRepository;

    public CalculatorService(ICalculationHistoryRepository calculationHistoryRepository)
    {
        _calculationHistoryRepository = calculationHistoryRepository;
    }

    public double Add(double firstNumber, double secondNumber) => firstNumber + secondNumber;

    public double Subtract(double firstNumber, double secondNumber) => firstNumber - secondNumber;

    public double Multiply(double firstNumber, double secondNumber) => firstNumber * secondNumber;

    public double Divide(double firstNumber, double secondNumber)
    {
        if (secondNumber == 0)
        {
            throw new DivideByZeroException("You cannot divide by zero.");
        }

        return firstNumber / secondNumber;
    }

    public double Modulus(double firstNumber, double secondNumber)
    {
        if (secondNumber == 0)
        {
            throw new DivideByZeroException("You cannot use modulus with zero.");
        }

        return firstNumber % secondNumber;
    }

    public double Power(double firstNumber, double secondNumber) => Math.Pow(firstNumber, secondNumber);

    public void SaveCalculation(string expression, double result)
    {
        var calculationRecord = new CalculationRecord
        {
            Expression = expression,
            Result = result,
            CreatedAt = DateTime.Now
        };

        _calculationHistoryRepository.SaveCalculation(calculationRecord);
    }

    public List<CalculationRecord> GetCalculationHistory()
    {
        return _calculationHistoryRepository.GetLastFiveCalculations();
    }

    public void ClearCalculationHistory()
    {
        _calculationHistoryRepository.ClearHistory();
    }
}
