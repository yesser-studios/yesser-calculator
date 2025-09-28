using YesserCalculator.Extension;

namespace YesserCalculator.BaseOperations.Trigonometry;

public class CosineRad : IOperation
{
    public double Execute(double number1, double number2)
    {
        return Math.Round(Math.Cos(number2), 15);
    }

    public string Symbol => "cos_rad";
    public string DisplaySymbol => "cos r";
}