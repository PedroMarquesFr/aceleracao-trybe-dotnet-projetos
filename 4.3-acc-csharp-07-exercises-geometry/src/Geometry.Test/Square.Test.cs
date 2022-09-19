namespace Geometry.Test;

public class SquareTest
{
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    [Theory]
    public void TestSquare(double side)
    {
        Square square = new(side);
        square.Area.Should().Be(side*side);
        square.Perimeter.Should().Be(2 * side + 2 * side);
    }
}