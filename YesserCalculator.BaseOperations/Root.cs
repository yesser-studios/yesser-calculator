using YesserCalculator.Extension;

namespace YesserCalculator.BaseOperations;

public class Root : IOperation
{
    public double Execute(double number1, double number2)
    {
        return Math.Pow(number2, 1.0 / number1);
    }

    public string Symbol => "rt";
    public string DisplaySymbol => "√";
}