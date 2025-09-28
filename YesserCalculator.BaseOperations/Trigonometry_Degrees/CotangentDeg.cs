using YesserCalculator.Extension;

namespace YesserCalculator.BaseOperations.Trigonometry;

public class CotangentDeg : IOperation
{
    public double Execute(double number1, double number2)
    {
        // ReSharper disable once ConvertIfStatementToReturnStatement
        if (number2 is 90 or 180 or 270 or 360) return double.NaN;
        
        return Math.Round(1 / Math.Tan(double.Pi * number2 / 180), 15);
    }

    public string Symbol => "cot";
    public string DisplaySymbol => "cot°";
}