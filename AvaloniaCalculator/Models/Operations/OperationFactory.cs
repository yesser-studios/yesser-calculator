using System.Collections.Generic;

namespace AvaloniaCalculator.Models.Operations;

public class OperationFactory
{
    private readonly Dictionary<string, IOperation> _operationMap = [];

    public void RegisterOperation(IOperation operation)
    {
        _operationMap.Add(operation.Symbol, operation);
    }
    
    public IOperation? GetOperationFromString(string? symbol)
    {
        if (symbol is null)
            return null;

        var exists = _operationMap.TryGetValue(symbol, out var operation);
        return exists ? operation : null;
    }
}