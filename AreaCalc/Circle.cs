using System;

namespace AreaCalc
{
    public class Circle: Shape
    {
        // Radius of a circle
        private double radius;
        private double Radius {
            get => radius;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Radius is not positive");
                }
                else
                    radius = value;
            } 
        }

        public Circle()
        {
            Radius = 0;
        }
        public Circle(double radius)
        {
            Radius = radius;
        }


        public override double CountArea()
        {
            Area = Math.PI * Radius * Radius;
            return Area;
        }
    }
}
