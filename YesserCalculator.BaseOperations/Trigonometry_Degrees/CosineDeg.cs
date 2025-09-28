using YesserCalculator.Extension;

namespace YesserCalculator.BaseOperations.Trigonometry;

public class CosineDeg : IOperation
{
    public double Execute(double number1, double number2)
    {
        return Math.Round(Math.Cos(double.Pi * number2 / 180), 15);
    }

    public string Symbol => "cos";
    public string DisplaySymbol => "cos°";
}