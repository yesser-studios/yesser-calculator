using YesserCalculator.Extension;
using static System.Double;

namespace YesserCalculator.BaseOperations.Trigonometry;

public class TangentRad : IOperation
{
    public double Execute(double number1, double number2)
    {
        // ReSharper disable once ConvertIfStatementToReturnStatement
        if ((number2 / (Pi / 2) + 1) % 2 == 0) return NaN;
        
        return Math.Round(Math.Tan(number2), 15);
    }

    public string Symbol => "tan_rad";
    public string DisplaySymbol => "tan r";
}