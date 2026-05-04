using YesserCalculator.BaseOperations.Trigonometry;
using YesserCalculator.Extension;

namespace YesserCalculator.BaseOperations;

public class Extension : IExtension
{
    public string Id
        => "a6747a83-a51c-4a4d-9dd6-70086a8a4b3a";

    public string DisplayName
        => "Default Operations Extension";

    public IEnumerable<IOperation> GetOperationList()
    {
        return [new Addition(), new Subtraction(), new Multiplication(), new Division(),
            new Power(), new Root(), new Factorial(), new Logarithm(), new NaturalLogarithm(),
            new SineDeg(), new CosineDeg(), new TangentDeg(), new CotangentDeg(), new TimesE(),
            new SineRad(), new CosineRad(), new TangentRad(), new CotangentRad(), new TimesPi()];
    }
}