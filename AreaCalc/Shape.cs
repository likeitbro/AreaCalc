namespace AreaCalc
{
    // Abstract class for any shape (inherit from this class when adding new shape)
    public abstract class Shape
    {
        private double area; 
        protected double Area
        {
            get => area;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Area is not positive");
                }
                else
                    area = value;
            }
        }

        // Calculates area of shape
        public abstract double CountArea();
    }
}
