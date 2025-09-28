using YesserCalculator.Extension;

namespace YesserCalculator.BaseOperations.Trigonometry;

public class SineDeg : IOperation
{
    public double Execute(double number1, double number2)
    {
        return Math.Round(Math.Sin(double.Pi * number2 / 180), 15);
    }

    public string Symbol => "sin";
    public string DisplaySymbol => "sin°";
}