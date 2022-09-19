namespace Geometry.Test;

public class CubeTest
{
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    [Theory]
    public void TestCube(double side)
    {
        Cube cube = new(side);
        cube.FaceA.Should().Be(side * side);
        cube.FaceB.Should().Be(side * side);
        cube.FaceC.Should().Be(side * side);
    }
}