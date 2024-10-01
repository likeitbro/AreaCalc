using System;

namespace AreaCalc;

public sealed class Circle: IAreaCalculatable
{
    public Length Radius { get; init; }

    public Circle(double radius) 
    { 
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius.Value * Radius.Value;
    }
}
