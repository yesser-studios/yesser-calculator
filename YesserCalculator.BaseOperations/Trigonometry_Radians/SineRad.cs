using YesserCalculator.Extension;

namespace YesserCalculator.BaseOperations.Trigonometry;

public class SineRad : IOperation
{
    public double Execute(double number1, double number2)
    {
        return Math.Round(Math.Sin(number2), 15);
    }

    public string Symbol => "sin_rad";
    public string DisplaySymbol => "sin r";
}