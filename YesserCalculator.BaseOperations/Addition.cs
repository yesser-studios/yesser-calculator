using YesserCalculatorExtension;

namespace YesserCalculator.BaseOperations;

public class Addition : IOperation
{
    public double Execute(double number1, double number2)
        => number1 + number2;

    public string Symbol => "+";
    public string DisplaySymbol => Symbol;
}