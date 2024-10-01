using AreaCalc;
using FluentAssertions;
using Xunit;

namespace TestProject;

public class TriangleTests
{
    [Theory]
    [InlineData(3, 4, 5, true)]
    [InlineData(1, 5, 1, false)]
    [InlineData(5, 1, 1, false)]
    [InlineData(1, 1, 5, false)]
    public void Triangle_ShouldNotThrow_OnValidData(double side1, double side2, double side3, bool isCorrect)
    {
        // Arrange
        Triangle shape;

        // Act
        var action = () => shape = new Triangle(side1, side2, side3);

        // Assert
        if (isCorrect)
            action.Should().NotThrow<ArgumentException>();
        else
            action.Should().Throw<ArgumentException>();
    }

    [Theory]
    [InlineData(3, 4, 5, 6)]
    public void Triangle_ShouldCalculateArea(double side1, double side2, double side3, double expected)
    {
        // Arrange
        Triangle shape = new Triangle(side1, side2, side3);

        //Act

        //Assert
        shape.CalculateArea().Should().Be(expected);
    }

    [Theory]
    [InlineData(3, 4, 5, true)]
    [InlineData(4, 5, 3, true)]
    [InlineData(5, 3, 4, true)]
    [InlineData(2, 2, 2, false)]
    public void RectTriangle_ShouldBeRect(double side1, double side2, double side3, bool expected)
    {
        // Arrange
        Triangle shape = new Triangle(side1, side2, side3);

        // Act

        // Assert
        shape.isRectangular.Should().Be(expected);
    }
}
