using Xunit;
using FluentAssertions;
using System;
using Animals;

namespace farm_classes.Test.Test;

public class ChickenTestTest
{
    public static TheoryData<int, Chicken> ChickenData =>
        new TheoryData<int, Chicken>
        {
            { 4, new Chicken(4) },
            { 5, new Chicken(5) },
            { 6, new Chicken(6) }
        };

    private ChickenTest _instance = new ChickenTest();

    [Trait("Category", "6 - Criou testes para o TestChickenInstantiation")]
    [Theory(DisplayName = "Testes de instanciação devem ser executado com sucesso com inputs válidos")]
    [MemberData(nameof(ChickenData))]
    public void TestSuccessTestChickenInstantiationWithMother(int eggsPerWeek, Chicken mother)
    {
        Action actWithoutMother = () => _instance.TestChickenInstantiationWithoutMother(eggsPerWeek, eggsPerWeek);
        Action actWithMother = () => _instance.TestChickenInstantiationWithMother(eggsPerWeek, eggsPerWeek, mother);

        actWithoutMother.Should().NotThrow<Xunit.Sdk.XunitException>();
        actWithoutMother.Should().NotThrow<NotImplementedException>();

        actWithMother.Should().NotThrow<Xunit.Sdk.XunitException>();
        actWithMother.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "6 - Criou testes para o TestChickenInstantiation")]
    [Theory(DisplayName = "Testes de instanciação devem lançar exceção com inputs inválidos")]
    [MemberData(nameof(ChickenData))]
    public void TestFailTestChickenInstantiationWithMother(int eggsPerWeek, Chicken mother)
    {
        Action actWithoutMother = () => _instance.TestChickenInstantiationWithoutMother(eggsPerWeek, 0);
        Action actWithMother = () => _instance.TestChickenInstantiationWithMother(eggsPerWeek, 0, mother);

        actWithoutMother.Should().Throw<Xunit.Sdk.XunitException>();
        actWithMother.Should().Throw<Xunit.Sdk.XunitException>();
    }
}

public class ChickenTestTest2
{

    public static TheoryData<int, Chicken> ChickenData =>
        new TheoryData<int, Chicken>
        {
            { 4, new Chicken(4) },
            { 5, new Chicken(5) },
            { 6, new Chicken(6) }
        };

    private ChickenTest _instance = new ChickenTest();
    
    public static TheoryData<int, Chicken> InvalidChickenData =>
        new TheoryData<int, Chicken>
        {
            { -1, new Chicken(4) },
            { -2, new Chicken(5) },
            { -3, new Chicken(6) }
        };

    [Trait("Category", "7 - Criou testes para o TestChickenInstantiationWithNegativeEggsPerWeek")]
    [Theory(DisplayName = "TestChickenInstantiationWithNegativeEggsPerWeek deve ser executado com sucesso com quantidade de ovos inválida")]
    [MemberData(nameof(InvalidChickenData))]
    public void TestFailTestChickenInstantiationWithNegativeEggsPerWeek(int eggsPerWeek, Chicken mother)
    {
        Action act = () => _instance.TestChickenInstantiationWithNegativeEggsPerWeek(eggsPerWeek, mother);

        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "7 - Criou testes para o TestChickenInstantiationWithNegativeEggsPerWeek")]
    [Theory(DisplayName = "TestChickenInstantiationWithNegativeEggsPerWeek deve lançar exceção com quantidade de ovos válida")]
    [MemberData(nameof(ChickenData))]
    public void TestSuccessTestChickenInstantiationWithNegativeEggsPerWeek(int eggsPerWeek, Chicken mother)
    {
        Action act = () => _instance.TestChickenInstantiationWithNegativeEggsPerWeek(eggsPerWeek, mother);

        act.Should().Throw<Xunit.Sdk.XunitException>();
    }
}
