namespace Geometry.Test.Test;

public class ParallelepipedTestTest
{
    ParallelepipedTest _instance = new ParallelepipedTest();

    [InlineData(2, 3, 4)]
    [InlineData(3, 4, 5)]
    [Theory]
    [Trait("Category", "3 - Crie uma classe Parallelepiped")]
    public void TestTestParallelepipedSuccess(double height, double width, double depth)
    {
        Action act = () => _instance.TestParallelepiped(height, width, depth);

        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<ArgumentException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [InlineData(2, 0, 4)]
    [InlineData(3, 4, 0)]
    [InlineData(-1, 3, 4)]
    [Theory]
    [Trait("Category", "3 - Crie uma classe Parallelepiped")]
    public void TestTestParallelepipedFailure(double height, double width, double depth)
    {
        Action act = () => _instance.TestParallelepiped(height, width, depth);

        act.Should().Throw<ArgumentException>();
    }
}