using Xunit.Sdk;

namespace HouseholdAppliances.Test.Test;

public class ApplianceTestsTest
{

    ApplianceTests instance = new ApplianceTests();

    [Trait("Category", "Crie uma classe `Microwave`")]
    [Theory]
    [InlineData("Samsung", "MW-01", 5, 100, false)]
    [InlineData("Electrolux", "MW-02", 10, 200, false)]
    public void TestTestMicrowaveSuccess(string brand, string model, int boilingTime, int maximumTemperature, bool initialIsOn)
    {
        var act = new Action(() => instance.TestMicrowave(brand, model, boilingTime, maximumTemperature, initialIsOn));

        act.Should().NotThrow<NotImplementedException>();
        act.Should().NotThrow<XunitException>();
    }

    [Trait("Category", "Crie uma classe `Microwave`")]
    [Theory]
    [InlineData("Samsung", "MW-01", 5, 100, true)]
    [InlineData("Electrolux", "MW-02", 10, 200, true)]
    public void TestTestMicrowaveFailure(string brand, string model, int boilingTime, int maximumTemperature, bool initialIsOn)
    {
        var act = new Action(() => instance.TestMicrowave(brand, model, boilingTime, maximumTemperature, initialIsOn));

        act.Should().Throw<XunitException>();
    }

}
public class ApplianceTestsTest2
{
    ApplianceTests instance = new ApplianceTests();

    [Trait("Category", "Crie uma classe `ElectricStove`")]
    [Theory]
    [InlineData("Samsung", "ST-01", 5, 100, false)]
    [InlineData("Electrolux", "ST-02", 10, 200, false)]
    public void TestTestElectricStoveSuccess(string brand, string model, int boilingTime, int maximumTemperature, bool initialIsOn)
    {
        var act = new Action(() => instance.TestElectricStove(brand, model, boilingTime, maximumTemperature, initialIsOn));

        act.Should().NotThrow<NotImplementedException>();
        act.Should().NotThrow<XunitException>();
    
    }
    [Trait("Category", "Crie uma classe `ElectricStove`")]
    [Theory]
    [InlineData("Samsung", "ST-01", 5, 100, true)]
    [InlineData("Electrolux", "ST-02", 10, 200, true)]
    public void TestTestElectricStoveFailure(string brand, string model, int boilingTime, int maximumTemperature, bool initialIsOn)
    {
        var act = new Action(() => instance.TestElectricStove(brand, model, boilingTime, maximumTemperature, initialIsOn));

        act.Should().Throw<XunitException>();
    }
}
public class ApplianceTestsTest3
{
    public static TheoryData<object, object> ValidPolymorphismData => new TheoryData<object, object>
    {
        {
            new Microwave("Samsung", "MW-01", 5, 100),
            new ElectricStove("Electrolux", "ST-02", 10, 200)
        },
    };

    public static TheoryData<object, object> InvalidPolymorphismData => new TheoryData<object, object>
    {
        {
            new FakeMicrowave("Samsung", "MW-01", 5, 100),
            new FakeStove("Electrolux", "ST-02", 10, 200)
        },
    };

    ApplianceTests instance = new ApplianceTests();
    
    [Trait("Category", "Crie testes para as classes concretas criadas nos requisitos anteriores")]
    [Theory]
    [MemberData(nameof(ValidPolymorphismData))]
    public void TestTestPolymorphismSuccess(object microwave, object stove)
    {
        var act = new Action(() => instance.TestPolymorphism(microwave, stove));

        act.Should().NotThrow<NotImplementedException>();
        act.Should().NotThrow<XunitException>();
    }
    [Trait("Category", "Crie testes para as classes concretas criadas nos requisitos anteriores")]
    [Theory]
    [MemberData(nameof(InvalidPolymorphismData))]
    public void TestTestPolymorphismFailure(object microwave, object stove)
    {
        var act = new Action(() => instance.TestPolymorphism(microwave, stove));

        act.Should().Throw<XunitException>();
    }
}

public class FakeMicrowave
{
    public FakeMicrowave(string brand, string model, int boilingTime, int maximumTemperature, bool initialIsOn = false)
    { }
}

public class FakeStove
{
    public FakeStove(string brand, string model, int boilingTime, int maximumTemperature, bool initialIsOn = false)
    { }
}