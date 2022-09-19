using Xunit;
using FluentAssertions;
using Animals;
using System;

namespace farm_classes.Test;

public class PigTest
{
    public static TheoryData<int, int> PigData =>
        new TheoryData<int, int>
        {
            { 0, 0 },
            { 3, 3 },
            { 5, 5 },
            { 7, 7 },
        };

    public static TheoryData<int> PigDataInvalidAge =>
        new TheoryData<int> { -1, -5, -10 };

    [Trait("Category", "2 - Crie uma classe Pig")]
    [Theory(DisplayName = "2.1 - Crie uma classe Pig válida")]
    [MemberData(nameof(PigData))]
    public void TestPigInstantiation(int age, int expectedAge)
    {
        Pig cow = new(age);
        cow.Age.Should().Be(expectedAge);
    }

    [Trait("Category", "2 - Crie uma classe Pig")]
    [Theory(DisplayName = "2.2 - Não deve permitir que a idade seja negativa")]
    [MemberData(nameof(PigDataInvalidAge))]
    public void TestPigInstantiationInvalidAge(int age)
    {
        Action act = () => new Pig(age);
        act.Should().Throw<ArgumentException>().WithMessage("Age cant be negative");
    }
}
