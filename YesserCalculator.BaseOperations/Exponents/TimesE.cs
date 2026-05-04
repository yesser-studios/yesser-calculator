using YesserCalculator.Extension;

namespace YesserCalculator.BaseOperations;

public class TimesE: IOperation
{
    public double Execute(double number1, double number2)
    {
        return number1 * double.E;
    }

    public string Symbol => "e";
    public string DisplaySymbol => "n×e";
}
