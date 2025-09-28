using YesserCalculator.Extension;

namespace YesserCalculator.BaseOperations.Trigonometry;

public class CotangentDeg : IOperation
{
    public double Execute(double number1, double number2)
    {
        // ReSharper disable once ConvertIfStatementToReturnStatement
        if (number2 % 90 == 0) return double.NaN;
        
        return Math.Round(1 / Math.Tan(double.Pi * number2 / 180), 15);
    }

    public string Symbol => "cot_deg";
    public string DisplaySymbol => "cot°";
}