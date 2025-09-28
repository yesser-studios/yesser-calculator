using YesserCalculator.Extension;

namespace YesserCalculator.BaseOperations.Trigonometry;

public class TangentDeg : IOperation
{
    public double Execute(double number1, double number2)
    {
        // ReSharper disable once ConvertIfStatementToReturnStatement
        if ((number2 + 90) % 180 == 0) return double.NaN;
        
        return Math.Round(Math.Tan(double.Pi * number2 / 180), 15);
    }

    public string Symbol => "tan_deg";
    public string DisplaySymbol => "tan°";
}