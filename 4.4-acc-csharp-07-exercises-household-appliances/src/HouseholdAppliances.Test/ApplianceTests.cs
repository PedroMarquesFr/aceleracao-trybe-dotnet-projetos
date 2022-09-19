namespace HouseholdAppliances.Test;

public class ApplianceTests
{
    public static TheoryData<object, object> PolymorphismData => new TheoryData<object, object>
    {
        {
            new Microwave("Samsung", "MW-01", 5, 100),
            new ElectricStove("Electrolux", "ST-02", 10, 200)
        },
    };

    [Theory]
    [InlineData("Samsung", "ST-01", 5, 100, false)]
    [InlineData("Electrolux", "ST-02", 10, 200, false)]
    public void TestMicrowave(string brand, string model, int boilingTime, int maximumTemperature, bool initialIsOn)
    {
        Microwave instance = new(brand, model, boilingTime, maximumTemperature, initialIsOn);
        Action cook = () => instance.Cook("something");
        cook.Should().Throw<Exception>();
        Action heat = () => instance.Heat("something");
        heat.Should().Throw<Exception>();
        instance.IsOn = true;
        Action newCook = () => instance.Cook("something");
        newCook.Should().NotThrow<Exception>();
        Action newHeat = () => instance.Heat("something");
        newHeat.Should().NotThrow<Exception>();
    }

    [Theory]
    [InlineData("Samsung", "MW-01", 5, 100, false)]
    [InlineData("Electrolux", "MW-02", 10, 200, false)]
    public void TestElectricStove(string brand, string model, int boilingTime, int maximumTemperature, bool initialIsOn)
    {
        ElectricStove instance = new(brand, model, boilingTime, maximumTemperature, initialIsOn);
        Action cook = () => instance.Cook("something");
        cook.Should().Throw<Exception>();
        Action bake = () => instance.Bake("something");
        bake.Should().Throw<Exception>();
        instance.IsOn = true;
        Action newCook = () => instance.Cook("something");
        newCook.Should().NotThrow<Exception>();
        Action newBake = () => instance.Bake("something");
        newBake.Should().NotThrow<Exception>();
    }

    [Theory]
    [MemberData(nameof(PolymorphismData))]
    public void TestPolymorphism(object microwave, object electricStove)
    {
        microwave.Should().BeAssignableTo<Appliance>();
        microwave.Should().BeAssignableTo<ICooker>();
        electricStove.Should().BeAssignableTo<Appliance>();
        electricStove.Should().BeAssignableTo<ICooker>();
    }
}