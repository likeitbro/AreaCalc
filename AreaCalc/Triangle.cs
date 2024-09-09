using System;

namespace AreaCalc;

public sealed class Triangle: IAreaCalculatable
{
    public required double FirstSide { get; init; }
    public required double SecondSide { get; init; }
    public required double ThirdSide { get; init; }

    // Check whether triangle is rectangular
    public bool isRectangular;

    //public Triangle(double FirstSide, double SecondSide, double ThirdSide)
    //{
    //    CheckExists();
    //    isRectangular 
    //}

    public double CalculateArea()
    {
        double semiPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - FirstSide) * (semiPerimeter - SecondSide) * (semiPerimeter - ThirdSide));
    }

    private bool CheckRectangular()
    {
        return FirstSide * FirstSide + SecondSide * SecondSide == ThirdSide * ThirdSide ||
               FirstSide * FirstSide + ThirdSide * ThirdSide == SecondSide * SecondSide ||
               SecondSide * SecondSide + ThirdSide * ThirdSide == FirstSide * FirstSide;
    }

    private void CheckExists()
    {
        if (((FirstSide + SecondSide) < ThirdSide) ||
            ((FirstSide + ThirdSide) < SecondSide) ||
            ((SecondSide + ThirdSide) < FirstSide))
            throw new ArgumentException("Unable to make a triange with given sides");
    }
}
