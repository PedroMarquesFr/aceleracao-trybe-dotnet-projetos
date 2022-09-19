namespace Geometry.Test.Test;

public class RectangleTestTest
{
    RectangleTest _instance = new RectangleTest();

    [InlineData(2, 2)]
    [InlineData(10, 5)]
    [Theory]
    [Trait("Category", "1 - Crie uma classe Rectangle")]
    public void TestTestRectangleSuccess(double sideA, double sideB)
    {
        Action act = () => _instance.TestRectangle(sideA, sideB);

        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<ArgumentException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [InlineData(0, 2)]
    [InlineData(10, 0)]
    [Theory]
    [Trait("Category", "1 - Crie uma classe Rectangle")]
    public void TestTestRectangleFailure(double sideA, double sideB)
    {
        Action act = () => _instance.TestRectangle(sideA, sideB);

        act.Should().Throw<ArgumentException>();
    }

    [InlineData(0, 2)]
    [InlineData(10, 0)]
    [Theory]
    [Trait("Category", "1 - Crie uma classe Rectangle")]
    public void TestTestRectangleNonPositiveSideExceptionSuccess(double sideA, double sideB)
    {
        Action act = () => _instance.TestRectangleNonPositiveSideException(sideA, sideB);

        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [InlineData(2, 2)]
    [InlineData(10, 5)]
    [Theory]
    [Trait("Category", "1 - Crie uma classe Rectangle")]
    public void TestTestRectangleNonPositiveSideExceptionFailure(double sideA, double sideB)
    {
        Action act = () => _instance.TestRectangleNonPositiveSideException(sideA, sideB);

        act.Should().Throw<Xunit.Sdk.XunitException>();
    }
}