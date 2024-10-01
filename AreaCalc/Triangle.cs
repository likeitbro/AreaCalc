using System;

namespace AreaCalc;

public sealed class Triangle: IAreaCalculatable
{
    public Length FirstSide { get; init; }
    public Length SecondSide { get; init; }
    public Length ThirdSide { get; init; }

    public Triangle(Length firstSide, Length secondSide, Length thirdSide)
    {
        FirstSide = firstSide;
        SecondSide = secondSide;
        ThirdSide = thirdSide;
        CheckExists(firstSide.Value, secondSide.Value, thirdSide.Value);
    }

    public double CalculateArea()
    {
        double semiPerimeter = (FirstSide.Value + SecondSide.Value + ThirdSide.Value) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - FirstSide.Value) * (semiPerimeter - SecondSide.Value) * (semiPerimeter - ThirdSide.Value));
    }

    public bool isRectangular => 
        FirstSide.Value * FirstSide.Value + SecondSide.Value * SecondSide.Value == ThirdSide.Value * ThirdSide.Value ||
        FirstSide.Value * FirstSide.Value + ThirdSide.Value * ThirdSide.Value == SecondSide.Value * SecondSide.Value ||
        SecondSide.Value * SecondSide.Value + ThirdSide.Value * ThirdSide.Value == FirstSide.Value * FirstSide.Value;

    private void CheckExists(double firstSide, double secondSide, double thirdSide)
    {
        if (((firstSide + secondSide) < thirdSide) ||
            ((firstSide + thirdSide) < secondSide) ||
            ((secondSide + thirdSide) < firstSide))
            throw new ArgumentException("Unable to make a triange with given sides");
    }
}
