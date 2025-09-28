using YesserCalculator.Extension;

namespace YesserCalculator.BaseOperations;

public class Logarithm : IOperation
{
    public double Execute(double number1, double number2)
    {
        return Math.Log(number2, number1);
    }

    public string Symbol => "log";
    public string DisplaySymbol => Symbol;
}