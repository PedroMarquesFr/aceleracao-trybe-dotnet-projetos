namespace Geometry.Test.Test;

public class CubeTestTest
{
    CubeTest _instance = new CubeTest();

    [InlineData(2)]
    [InlineData(3)]
    [Theory]
    [Trait("Category", "4 - Crie uma classe Cube")]
    public void TestTestCubeSuccess(double side)
    {
        Action act = () => _instance.TestCube(side);

        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<ArgumentException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [InlineData(0)]
    [InlineData(-1)]
    [Theory]
    [Trait("Category", "4 - Crie uma classe Cube")]
    public void TestTestCubeFailure(double side)
    {
        Action act = () => _instance.TestCube(side);

        act.Should().Throw<ArgumentException>();
    }
}