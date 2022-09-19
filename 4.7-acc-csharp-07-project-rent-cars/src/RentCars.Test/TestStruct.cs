using Xunit;
using FluentAssertions;
using RentCars.Types;

namespace RentCars.Test;

public class TestStruct
{
    [Theory]
    [MemberData(nameof(ColorShouldHaveNameAttributeData))]
    public void ColorShouldHaveNameAttribute(Color colorEntry, string expected)
    {
        colorEntry.Name.Should().Be(expected);
    }

    public static TheoryData<Color, string> ColorShouldHaveNameAttributeData = new()
    {
        { new Color() { Name = "SomeName" }, "SomeName" },
        { new Color() { Name = "SomeName2" }, "SomeName2" },
        { new Color() { Name = "SomeName3" }, "SomeName3" },
    };

    [Theory]
    [MemberData(nameof(ColorShouldHaveHexAttributeData))]
    public void ColorShouldHaveHexAttribute(Color colorEntry, string expected)
    {
        colorEntry.Hex.Should().Be(expected);
    }

    public static TheoryData<Color, string> ColorShouldHaveHexAttributeData = new()
    {
        { new Color() { Hex = "SomeName" }, "SomeName" },
        { new Color() { Hex = "SomeName2" }, "SomeName2" },
        { new Color() { Hex = "SomeName3" }, "SomeName3" },
    };
}