using System;

namespace AreaCalc
{
    public class Triangle: Shape
    {
        private double firstSide;
        public double FirstSide
        {
            get => firstSide;
            // Setter exception is unreachable in this instance of program
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Side length is not positive");
                }
                else
                    firstSide = value;
            }
        }

        private double secondSide;
        public double SecondSide
        {
            get => secondSide;
            // Setter exception is unreachable in this instance of program
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Side length is not positive");
                }
                else
                    secondSide = value;
            }
        }

        private double thirdSide;
        public double ThirdSide
        {
            get => thirdSide;
            // Setter exception is unreachable in this instance of program
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Side length is not positive");
                }
                else
                    thirdSide = value;
            }
        }

        // Check whether triangle is rectangular
        public bool isRectangular;

        public Triangle()
        {
            FirstSide = 0;
            SecondSide = 0;
            ThirdSide = 0;
            isRectangular = true;
        }
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (((firstSide+secondSide) > thirdSide) && ((firstSide + thirdSide) > secondSide) && ((secondSide + thirdSide) > firstSide))
            {
                FirstSide = firstSide;
                SecondSide = secondSide;
                ThirdSide = thirdSide;
                isRectangular = (
                    firstSide * firstSide + secondSide * secondSide == thirdSide * thirdSide ||
                    firstSide * firstSide + thirdSide * thirdSide == secondSide * secondSide ||
                    secondSide * secondSide + thirdSide * thirdSide == firstSide * firstSide);
            }
            else
            {
                throw new ArgumentException("Unable to make a triange with given sides");
            }
        }

        public override double CountArea()
        {
            double semiPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;
            Area = Math.Sqrt(semiPerimeter * (semiPerimeter-firstSide) * (semiPerimeter-secondSide) * (semiPerimeter-thirdSide));
            return Area;
        }
    }
}
