using YesserCalculator.Extension;
using static System.Double;

namespace YesserCalculator.BaseOperations.Trigonometry;

public class CotangentRad : IOperation
{
    public double Execute(double number1, double number2)
    {
        // ReSharper disable once ConvertIfStatementToReturnStatement
        if (number2 / (Pi / 2) % 1 == 0 ) return NaN;
        
        return Math.Round(1 / Math.Tan(number2), 15);
    }

    public string Symbol => "cot_rad";
    public string DisplaySymbol => "cot r";
}