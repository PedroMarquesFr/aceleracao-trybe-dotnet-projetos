using Xunit;
using FluentAssertions;
using Animals;
using System;

namespace farm_classes.Test;

public class ChickenTest
{
    public static TheoryData<int, int, Chicken> ValidChickenData =>
        new TheoryData<int, int, Chicken>
        {
            { 4, 4, new Chicken(4) },
            { 5, 5, new Chicken(5) },
            { 6, 6, new Chicken(6) }
        };

    public static TheoryData<int, Chicken> InvalidChickenData =>
        new TheoryData<int, Chicken>
        {
            { -1, new Chicken(4) },
            { -2, new Chicken(5) },
            { -3, new Chicken(6) }
        };

    [Trait("Category", "3 - Crie uma classe Chicken")]
    [Theory(DisplayName = "3.1 - Crie uma classe Chicken sem uma mãe")]
    [InlineData(4, 4)]
    [InlineData(5, 5)]
    [InlineData(6, 6)]
    public void TestChickenInstantiationWithoutMother(int eggsPerWeek, int expectedEggsPerWeek)
    {
        Chicken cow = new(eggsPerWeek);
        cow.EggsPerWeek.Should().Be(expectedEggsPerWeek);
        cow.Mother.Should().Be(null);
    }

    [Trait("Category", "3 - Crie uma classe Chicken")]
    [Theory(DisplayName = "3.2 - Crie uma classe Chicken com uma mãe")]
    [MemberData(nameof(ValidChickenData))]
    public void TestChickenInstantiationWithMother(int eggsPerWeek, int expectedEggsPerWeek, Chicken mother)
    {
        Chicken cow = new(eggsPerWeek, mother);
        cow.EggsPerWeek.Should().Be(expectedEggsPerWeek);
        cow.Mother.Should().Be(mother);
    }

    [Trait("Category", "3 - Crie uma classe Chicken")]
    [Theory(DisplayName = "3.3 - Não deve permitir que uma galinha ponha menos de 0 ovos por semana")]
    [MemberData(nameof(InvalidChickenData))]
    public void TestChickenInstantiationWithNegativeEggsPerWeek(int eggsPerWeek, Chicken mother)
    {
        Action act = () => new Chicken(eggsPerWeek, mother);
        act.Should().Throw<ArgumentException>().WithMessage("EggsPerWeek cant be negative");
    }
}