using YesserCalculator.Extension;

namespace YesserCalculator.BaseOperations;

public class Power: IOperation
{
    public double Execute(double number1, double number2)
    {
        return Math.Pow(number1, number2);
    }

    public string Symbol => "^";
    public string DisplaySymbol => Symbol;
}