using YesserCalculator.Extension;

namespace YesserCalculator.BaseOperations;

public class NaturalLogarithm : IOperation
{
    public double Execute(double number1, double number2)
    {
        return Math.Log(number2, double.E);
    }

    public string Symbol => "ln";
    public string DisplaySymbol => Symbol;
}