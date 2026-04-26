using CalculatorConsoleApp.Models;

namespace CalculatorConsoleApp.Repositories;

public interface ICalculationHistoryRepository
{
    List<CalculationRecord> GetLastFiveCalculations();
    void SaveCalculation(CalculationRecord calculationRecord);
    void ClearHistory();
}
