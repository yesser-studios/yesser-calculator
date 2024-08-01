namespace CalculatorApp.Operations;

public class Multiplication : IOperation
{
    public double Execute(double number1, double number2)
        => number1 * number2;
}