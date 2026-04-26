using System.Text.Json;
using CalculatorConsoleApp.Models;

namespace CalculatorConsoleApp.Repositories;

public class JsonCalculationHistoryRepository : ICalculationHistoryRepository
{
    private readonly string _filePath;
    private readonly JsonSerializerOptions _jsonOptions = new() { WriteIndented = true };

    public JsonCalculationHistoryRepository(string filePath)
    {
        _filePath = filePath;
        EnsureFileExists();
    }

    public List<CalculationRecord> GetLastFiveCalculations()
    {
        var history = ReadAllCalculations();
        return history
            .OrderByDescending(item => item.CreatedAt)
            .Take(5)
            .ToList();
    }

    public void SaveCalculation(CalculationRecord calculationRecord)
    {
        var history = ReadAllCalculations();

        history.Add(calculationRecord);

        history = history
            .OrderByDescending(item => item.CreatedAt)
            .Take(5)
            .ToList();

        WriteAllCalculations(history);
    }

    public void ClearHistory()
    {
        WriteAllCalculations([]);
    }

    private void EnsureFileExists()
    {
        var directory = Path.GetDirectoryName(_filePath);

        if (!string.IsNullOrWhiteSpace(directory))
        {
            Directory.CreateDirectory(directory);
        }

        if (!File.Exists(_filePath))
        {
            File.WriteAllText(_filePath, "[]");
        }
    }

    private List<CalculationRecord> ReadAllCalculations()
    {
        var json = File.ReadAllText(_filePath);

        if (string.IsNullOrWhiteSpace(json))
        {
            return [];
        }

        return JsonSerializer.Deserialize<List<CalculationRecord>>(json, _jsonOptions) ?? [];
    }

    private void WriteAllCalculations(List<CalculationRecord> calculationRecords)
    {
        var json = JsonSerializer.Serialize(calculationRecords, _jsonOptions);
        File.WriteAllText(_filePath, json);
    }
}
