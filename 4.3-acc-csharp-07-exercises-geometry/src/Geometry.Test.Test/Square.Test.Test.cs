namespace Geometry.Test.Test;

public class SquareTestTest
{
    SquareTest _instance = new SquareTest();

    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    [Theory]
    [Trait("Category", "2 - Crie uma classe Square")]
    public void TestTestSquareSuccess(double side)
    {
        Action act = () => _instance.TestSquare(side);

        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<ArgumentException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [InlineData(0)]
    [InlineData(-1)]
    [Theory]
    [Trait("Category", "2 - Crie uma classe Square")]
    public void TestTestSquareFailure(double side)
    {
        Action act = () => _instance.TestSquare(side);

        act.Should().Throw<ArgumentException>();
    }
}