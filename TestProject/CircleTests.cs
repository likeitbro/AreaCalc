using AreaCalc;
using FluentAssertions;
using Xunit;

namespace TestProject;

[TestClass]
public class CircleTests
{
    [Theory]
    [InlineData(3, true)]
    [InlineData(0, true)]
    [InlineData(-1, false)]
    public void Circle_ShouldNotThrow_OnValidData(double radius, bool isCorrect)
    {
        // Arrange
        Circle shape;

        // Act
        var action = () => shape = new Circle(radius);

        // Assert
        if (isCorrect)
            action.Should().NotThrow<ArgumentException>();
        else
            action.Should().Throw<ArgumentException>();
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(3, 9*Math.PI)]
    public void Circle_ShouldCalculateArea(double radius, double expected)
    {
        // Arrange
        Circle shape = new Circle(radius);

        // Act

        // Assert
        shape.CalculateArea().Should().Be(expected);
    }
}
