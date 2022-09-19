using RentCars.Test;
using RentCars.Types;

namespace RentCars.Test.Test;

public class TestTestStruct
{
    [Trait("Category", "1 - Criou testes para Color deveria ter atributo nome")]
    [Theory(DisplayName = "Color deve ter a propriedade Nome do tipo String")]
    [MemberData(nameof(ColorShouldHaveNameAttributeData))]
    public void TestColorShouldHaveNameAttribute(Color colorEntry, string expected, bool isCorrect)
    {
        TestStruct instance = new();
        Action act = () => instance.ColorShouldHaveNameAttribute(colorEntry, expected);
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

    public static TheoryData<Color, string, bool> ColorShouldHaveNameAttributeData = new()
    {
        { new Color() { Name = "SomeName" }, "SomeName", true },
        { new Color() { Name = "SomeName2" }, "SomeName2", true },
        { new Color() { Name = "SomeName3" }, "SomeName3", true },
        { new Color() { Name = "SomeName2" }, "SomeName3", false },
        { new Color() { Name = "SomeName3" }, "SomeName2", false },
    };

}
public class TestTestStruct2
{
    [Trait("Category", "2 - Criou testes para Color deveria ter atributo hex")]
    [Theory(DisplayName = "Color deve ter a propriedade Hex do tipo String")]
    [MemberData(nameof(ColorShouldHaveHexAttributeData))]
    public void TestColorShouldHaveHexAttribute(Color colorEntry, string expected, bool isCorrect)
    {
        TestStruct instance = new();
        Action act = () => instance.ColorShouldHaveHexAttribute(colorEntry, expected);
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

    public static TheoryData<Color, string, bool> ColorShouldHaveHexAttributeData = new()
    {
        { new Color() { Hex = "SomeName" }, "SomeName", true },
        { new Color() { Hex = "SomeName2" }, "SomeName2", true },
        { new Color() { Hex = "SomeName3" }, "SomeName3", true },

        { new Color() { Hex = "SomeName4" }, "SomeName3", false },
        { new Color() { Hex = "SomeName3" }, "SomeName4", false },
    };
}