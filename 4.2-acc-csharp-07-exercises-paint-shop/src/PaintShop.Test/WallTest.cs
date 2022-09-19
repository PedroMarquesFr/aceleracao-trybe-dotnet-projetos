namespace PaintShop.Test;

public class WallTest
{
    [Theory]
    [InlineData(1, 1, 1, 1)]
    public void TestWallWithPositiveValues(double width, double height, double expectedWidth, double expectedHeight)
    {
        // Arrange
        var wall = new Wall(width, height);

        // Assert
        wall.Width.Should().Be(expectedWidth);
        wall.Height.Should().Be(expectedHeight);
    }


    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 0)]
    [InlineData(-1, 1)]
    [InlineData(1, -1)]
    public void TestWallWithNegativeOrZeroValues(double width, double height)
    {
        // Arrange
        Action action = () => new Wall(width, height);

        // Assert
        action.Should().Throw<ArgumentException>();
    }

    [Theory]
    [InlineData(0, 10, 10)]
    public void TestWallExcludedAreaChangeability(double initialExcludedArea, double newExcludedArea, double expectedNewExcludedArea)
    {
        // Arrange
        var wall = new Wall(1, 1);
        var initialValue = wall.ExcludedArea;
        wall.ExcludedArea = newExcludedArea;

        // Act
        wall.ExcludedArea = newExcludedArea;

        // Assert
        initialValue.Should().Be(initialExcludedArea);
        wall.ExcludedArea.Should().Be(expectedNewExcludedArea);
    }

    [Theory]
    [InlineData(10, 10, 10, 90)]
    [InlineData(10, 10, 20, 80)]
    [InlineData(5, 5, 20, 5)]
    public void TestWallPaintableAreaCalculation(double width, double height, double excludedArea, double paintableArea)
    {
        // Arrange
        var wall = new Wall(width, height);
        wall.ExcludedArea = excludedArea;

        // Assert
        wall.PaintableArea.Should().Be(paintableArea);
    }
}