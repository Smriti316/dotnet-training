using CalculatorConsoleApp.Models;

namespace CalculatorConsoleApp.Services;

public interface ICalculatorService
{
    double Add(double firstNumber, double secondNumber);
    double Subtract(double firstNumber, double secondNumber);
    double Multiply(double firstNumber, double secondNumber);
    double Divide(double firstNumber, double secondNumber);
    double Modulus(double firstNumber, double secondNumber);
    double Power(double firstNumber, double secondNumber);
    void SaveCalculation(string expression, double result);
    List<CalculationRecord> GetCalculationHistory();
    void ClearCalculationHistory();
}
