using AreaCalc;
using FluentAssertions;
using Xunit;

namespace TestProject;

public class CircleTests
{
    [Theory]
    [InlineData(3, true)]
    [InlineData(1, true)]
    [InlineData(0, true)]
    [InlineData(-1, false)]
    public void Circle_ShouldNotThrow_OnValidData(double radius, bool isCorrect)
    {
        // Arrange
        Circle shape;

        // Act
        var action = () => shape = new Circle
        {
            Radius = radius
        };

        // Assert
        if (isCorrect)
            action.Should().NotThrow<ArgumentException>();
        else
            action.Should().Throw<ArgumentException>();
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(3, 3*3*Math.PI)]
    public void Circle_ShouldCalculateArea(double input, double expected)
    {
        // Arrange
        Circle shape = new Circle { Radius = input };

        // Act

        // Assert
        shape.CalculateArea().Should().Be(expected);
    }
}
