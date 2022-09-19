using FluentAssertions;
using RentCars.Types;

namespace RentCars.Test;

public class TestEnums
{
    [Theory]
    [InlineData(1, "Chamber")]
    [InlineData(2, "Disc")]
    [InlineData(3, "Drum")]
    public void BreakeTypeShouldHaveCorrectValues(int valueEntry, string expected)
    {
        BrakeType brakeType = (BrakeType)valueEntry;
        brakeType.ToString().Should().Be(expected);
    }

    [Theory]
    [InlineData(0, "FrontWheelDrive")]
    [InlineData(1, "RearWheelDrive")]
    [InlineData(2, "AllWheelDrive")]
    public void TractionTypeShouldHaveCorrectValues(int valueEntry, string expected)
    {
        TractionType tractionType = (TractionType)valueEntry;
        tractionType.ToString().Should().Be(expected);
    }

    [Theory]
    [InlineData(10, "Alcohol")]
    [InlineData(20, "Gasoline")]
    [InlineData(30, "Flex")]
    [InlineData(40, "Diesel")]
    [InlineData(50, "Electric")]
    [InlineData(60, "Hybrid")]
    public void FuelTypeShouldHaveCorrectValues(int valueEntry, string expected)
    {
        FuelType fuelType = (FuelType)valueEntry;
        fuelType.ToString().Should().Be(expected);
    }

    [Theory]
    [InlineData(0, "Confirmed")]
    [InlineData(1, "Finished")]
    public void RentStatusShouldHaveCorrectValues(int valueEntry, string expected)
    {
        RentStatus rentStatus = (RentStatus)valueEntry;
        rentStatus.ToString().Should().Be(expected);
    }

    [Fact]
    public void RentStatusFinishedShouldBeTheSameValueAsCancelled()
    {
        RentStatus rentStatusFinished = RentStatus.Finished;
        RentStatus rentStatusCancelled = RentStatus.Cancelled;
        rentStatusFinished.ToString().Should().Be(rentStatusCancelled.ToString());
    }
}
