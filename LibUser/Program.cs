using AreaCalc;

namespace LibUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Circle(10);
            Console.WriteLine(shape1.CountArea());

            Shape shape2 = new Triangle(10, 5, 6);
            Console.WriteLine(shape2.CountArea());
            Console.WriteLine(((Triangle)shape2).isRectangular);

            Triangle shape3 = new Triangle(10, 6, 8);
            Console.WriteLine(shape3.isRectangular);
        }
    }
}