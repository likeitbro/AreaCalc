using AreaCalc;

namespace TestProject;

[TestClass]
public class CircleTests
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Circle_ShouldThrow_OnNegativeRadius()
    {
        // Arrange
        Shape shape = new Circle(-10);

        // Act

        // Assert
    }

    [TestMethod]
    public void NullCircle_ShouldReturnNullArea()
    {
        // Arrange
        Shape shape = new Circle();

        // Act


        // Assert
        Assert.AreEqual(shape.CountArea(), 0);
    }

    [TestMethod]
    public void Circle_ShouldCaclulateRightArea()
    {
        // Arrange
        Shape shape = new Circle(10);
        double area = 10*10*Math.PI;

        // Act


        // Assert
        Assert.AreEqual(shape.CountArea(), area);
    }
}
[TestClass]
public class TriangleTests
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Triangle_ShouldThrow_OnNegativeFirstSide()
    {
        // Arrange
        Shape shape = new Triangle(-10,10,10);

        // Act

        // Assert
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Triangle_ShouldThrow_OnNegativeSecondSide()
    {
        // Arrange
        Shape shape = new Triangle(10, -10, 10);

        // Act

        // Assert
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Triangle_ShouldThrow_OnNegativeThirdSide()
    {
        // Arrange
        Shape shape = new Triangle(10, 10, -10);

        // Act

        // Assert
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Triangle_ShouldThrow_OnNegativeSides()
    {
        // Arrange
        Shape shape = new Triangle(-10, -10, -10);

        // Act

        // Assert
    }

    [TestMethod]
    public void NullTriangle_ShouldReturnNullArea()
    {
        // Arrange
        Shape shape = new Triangle();

        // Act


        // Assert
        Assert.AreEqual(shape.CountArea(), 0);
    }

    [TestMethod]
    public void Triangle_ShouldCaclulateRightArea()
    {
        // Arrange
        Shape shape = new Triangle(10, 10, 10);
        double area = Math.Sqrt(15 * (15 - 10) * (15 - 10) * (15 - 10));

        // Act


        // Assert
        Assert.AreEqual(shape.CountArea(), area);
    }

    [TestMethod]
    public void RectTriangle_ShouldBeRect_IfFirstSideIsLargest()
    {
        // Arrange
        Triangle shape = new Triangle(10, 6, 8);

        // Act


        // Assert
        Assert.IsTrue(shape.isRectangular);
    }

    [TestMethod]
    public void RectTriangle_ShouldBeRect_IfSecondSideIsLargest()
    {
        // Arrange
        Triangle shape = new Triangle(6, 10, 8);

        // Act


        // Assert
        Assert.IsTrue(shape.isRectangular);
    }

    [TestMethod]
    public void RectTriangle_ShouldBeRect_IfThirdSideIsLargest()
    {
        // Arrange
        Triangle shape = new Triangle(6, 8, 10);

        // Act


        // Assert
        Assert.IsTrue(shape.isRectangular);
    }

    [TestMethod]
    public void NotRectTriangle_ShouldNotBeRect()
    {
        // Arrange
        Triangle shape = new Triangle(10, 8, 8);

        // Act


        // Assert
        Assert.IsFalse(shape.isRectangular);
    }
}