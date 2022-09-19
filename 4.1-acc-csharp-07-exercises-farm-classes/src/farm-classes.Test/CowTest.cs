using Xunit;
using FluentAssertions;
using Animals;
using System;

namespace farm_classes.Test;

public class CowTest
{
    public static TheoryData<int, int, string, string> CowData =>
        new TheoryData<int, int, string, string>
        {
            { 100, 100, "Brown", "Brown" },
            { 200, 200, "White", "White" },
            { 300, 300, "Black", "Black" },
        };

    public static TheoryData<int, string> CowDataInvalidWeight =>
        new TheoryData<int, string>
        {
            { 0, "Brown" },
            { -10, "Brown" },
            { -100, "Brown" },
        };

    public static TheoryData<int, string> CowDataNullOrEmptyName =>
        new TheoryData<int, string>
        {
            { 100, "" },
            { 100, null! },
        };

    [Trait("Category", "1 - Crie uma classe Cow")]
    [Theory(DisplayName = "1.1 - Crie uma classe Cow válida")]
    [MemberData(nameof(CowData))]
    public void TestCowInstantiation(int weight, int expectedWeight, string breed, string expectedBreed)
    {
        Cow cow = new(weight, breed);
        cow.Weight.Should().Be(expectedWeight);
        cow.Breed.Should().Be(expectedBreed);
    }

    [Trait("Category", "1 - Crie uma classe Cow")]
    [Theory(DisplayName = "1.2 - Não deve permitir que o peso seja negativo")]
    [MemberData(nameof(CowDataInvalidWeight))]
    public void TestCowInstantiationInvalidWeight(int weight, string breed)
    {
        Action act = () => new Cow(weight, breed);
        act.Should().Throw<ArgumentException>().WithMessage("Invalid Breed or Weight");
    }

    [Trait("Category", "1 - Crie uma classe Cow")]
    [Theory(DisplayName = "1.3 - Não deve permitir que a raça seja nula ou vazia")]
    [MemberData(nameof(CowDataNullOrEmptyName))]
    public void TestCowInstantiationNullOrEmptyBreed(int weight, string breed)
    {
        Action act = () => new Cow(weight, breed);
        act.Should().Throw<ArgumentException>().WithMessage("Invalid Breed or Weight");
    }
}