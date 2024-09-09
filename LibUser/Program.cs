using AreaCalc;

var shape1 = new Circle
{
    Radius = 10,
};
Console.WriteLine(shape1.CalculateArea());

var shape2 = new Triangle {
    FirstSide = 6,
    SecondSide = 7,
    ThirdSide = 8,
    };
Console.WriteLine(shape2.CalculateArea());
Console.WriteLine(((Triangle)shape2).isRectangular);

Triangle shape3 = new Triangle
{
    FirstSide = 6,
    SecondSide = 8,
    ThirdSide = 10,
};
Console.WriteLine(shape3.isRectangular);