using System;

namespace AreaCalc
{
    public sealed class Circle: IAreaCalculatable
    {
        public required double Radius { get; init; }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
