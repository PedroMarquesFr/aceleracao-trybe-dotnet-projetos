namespace Geometry.Test;

public class ParallelepipedTest
{
    [InlineData(2, 3, 4)]
    [InlineData(3, 4, 5)]
    [Theory]
    public void TestParallelepiped(double height, double width, double depth)
    {
        Parallelepiped parallelepiped = new(height, width, depth);
        parallelepiped.Volume.Should().Be(height * width * depth);
        parallelepiped.Volume.Should().Be(height * width * depth);
        parallelepiped.SurfaceArea.Should().Be(2 * parallelepiped.FaceA.Area + 2 * parallelepiped.FaceB.Area + 2 * parallelepiped.FaceC.Area);
    }
}