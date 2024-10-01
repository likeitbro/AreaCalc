using AreaCalc;

var shape1 = new Circle(10);
Console.WriteLine(shape1.CalculateArea());

var shape2 = new Triangle(6, 7, 8);
Console.WriteLine(shape2.CalculateArea());
Console.WriteLine(((Triangle)shape2).isRectangular);

Triangle shape3 = new Triangle(6, 8, 10);
Console.WriteLine(shape3.isRectangular);