using YesserCalculator.Extension;

namespace YesserCalculator.BaseOperations;

public class Factorial : IOperation
{
    public double Execute(double number1, double number2)
    {
        // ReSharper disable once CompareOfFloatsByEqualityOperator
        if ((int)number1 != number1) return double.NaN;

        var result = 1;
        for (var i = 1; i <= number1; i++)
            result *= i;

        return result;
    }

    public string Symbol => "!";
    public string DisplaySymbol => "x!";
}