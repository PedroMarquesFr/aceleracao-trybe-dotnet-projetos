using RentCars.Test;

namespace RentCars.Test.Test;

public class TestTestEnums
{
    [Trait("Category", "3 - Criou testes para BreakeType")]
    [Theory(DisplayName = "BreakeType deve ter as constantes e valores corretos")]
    [InlineData(1, "Chamber", true)]
    [InlineData(2, "Disc", true)]
    [InlineData(3, "Drum", true)]
    [InlineData(5, "Drum", false)]
    [InlineData(0, "Chamber", false)]
    [InlineData(0, "Disc", false)]
    [InlineData(0, "Drum", false)]
    public void TestBreakeTypeShouldHaveCorrectValues(int valueEntry, string expected, bool isCorrect)
    {
        TestEnums instance = new();
        Action act = () => instance.BreakeTypeShouldHaveCorrectValues(valueEntry, expected);
        if (isCorrect)
        {
            act.Should().NotThrow<Xunit.Sdk.XunitException>();
        }
        else
        {
            act.Should().Throw<Xunit.Sdk.XunitException>();
        }
        
        act.Should().NotThrow<NotImplementedException>();
    }
}
public class TestTestEnums2
{
    [Trait("Category", "4 - Criou testes para TractionType")]
    [Theory(DisplayName = "TractionType deve ter as constantes e valores corretos")]
    [InlineData(0, "FrontWheelDrive", true)]
    [InlineData(1, "RearWheelDrive", true)]
    [InlineData(2, "AllWheelDrive", true)]
    [InlineData(1, "FrontWheelDrive", false)]
    [InlineData(0, "RearWheelDrive", false)]
    [InlineData(0, "AllWheelDrive", false)]
    [InlineData(0, "Test", false)]
    [InlineData(1, "Test", false)]
    [InlineData(2, "Test", false)]
    [InlineData(3, "FrontWheelDrive", false)]
    [InlineData(3, "RearWheelDrive", false)]
    [InlineData(3, "AllWheelDrive", false)]
    public void TestTractionTypeShouldHaveCorrectValues(int valueEntry, string expected, bool isCorrect)
    {
        TestEnums instance = new();
        Action act = () => instance.TractionTypeShouldHaveCorrectValues(valueEntry, expected);
        if (isCorrect)
        {
            act.Should().NotThrow<Xunit.Sdk.XunitException>();
        }
        else
        {
            act.Should().Throw<Xunit.Sdk.XunitException>();
        }
        
        act.Should().NotThrow<NotImplementedException>();
    }
}
public class TestTestEnums3
{
    [Trait("Category", "5 - Criou testes para FuelType")]
    [Theory(DisplayName = "FuelType deve ter as constantes e valores corretos")]
    [InlineData(10, "Alcohol", true)]
    [InlineData(20, "Gasoline", true)]
    [InlineData(30, "Flex", true)]
    [InlineData(40, "Diesel", true)]
    [InlineData(50, "Electric", true)]
    [InlineData(60, "Hybrid", true)]

    [InlineData(0, "Alcohol", false)]
    [InlineData(0, "Gasoline", false)]
    [InlineData(0, "Flex", false)]
    [InlineData(0, "Diesel", false)]
    [InlineData(0, "Electric", false)]
    [InlineData(0, "Hybrid", false)]

    [InlineData(1, "Alcohol", false)]
    [InlineData(1, "Gasoline", false)]
    [InlineData(1, "Flex", false)]
    [InlineData(1, "Diesel", false)]
    [InlineData(1, "Electric", false)]
    [InlineData(1, "Hybrid", false)]

    [InlineData(2, "Alcohol", false)]
    [InlineData(2, "Gasoline", false)]
    [InlineData(2, "Flex", false)]
    [InlineData(2, "Diesel", false)]
    [InlineData(2, "Electric", false)]
    [InlineData(2, "Hybrid", false)]
    public void TestFuelTypeShouldHaveCorrectValues(int valueEntry, string expected, bool isCorrect)
    {
        TestEnums instance = new();
        Action act = () => instance.FuelTypeShouldHaveCorrectValues(valueEntry, expected);
        if (isCorrect)
        {
            act.Should().NotThrow<Xunit.Sdk.XunitException>();
        }
        else
        {
            act.Should().Throw<Xunit.Sdk.XunitException>();
        }
        
        act.Should().NotThrow<NotImplementedException>();
    }
}
public class TestTestEnums4
{
    [Trait("Category", "6 - Criou testes para RentStatus")]
    [Theory(DisplayName = "RentStatus deve ter as constantes e valores corretos")]
    [InlineData(0, "Confirmed", true)]
    [InlineData(1, "Finished", true)]

    [InlineData(1, "Confirmed", false)]
    [InlineData(0, "Finished", false)]

    [InlineData(2, "Confirmed", false)]
    [InlineData(2, "Finished", false)]

    [InlineData(0, "Test", false)]
    [InlineData(1, "Test", false)]
    public void TestRentStatusShouldHaveCorrectValues(int valueEntry, string expected, bool isCorrect)
    {
        TestEnums instance = new();
        Action act = () => instance.RentStatusShouldHaveCorrectValues(valueEntry, expected);
        if (isCorrect)
        {
            act.Should().NotThrow<Xunit.Sdk.XunitException>();
        }
        else
        {
            act.Should().Throw<Xunit.Sdk.XunitException>();
        }
        
        act.Should().NotThrow<NotImplementedException>();

        Action actSameValues = () => instance.RentStatusFinishedShouldBeTheSameValueAsCancelled();
        actSameValues.Should().NotThrow<Xunit.Sdk.XunitException>();
        actSameValues.Should().NotThrow<NotImplementedException>();
    }
}