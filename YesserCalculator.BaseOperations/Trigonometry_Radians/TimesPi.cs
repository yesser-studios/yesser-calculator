using YesserCalculator.Extension;

namespace YesserCalculator.BaseOperations.Trigonometry;

public class TimesPi : IOperation
{
    public double Execute(double number1, double number2)
    {
        return number1 * double.Pi;
    }

    public string Symbol => "pi";
    public string DisplaySymbol => "n×π";
}