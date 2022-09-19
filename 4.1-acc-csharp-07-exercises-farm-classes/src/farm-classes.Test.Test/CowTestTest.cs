using Xunit;
using FluentAssertions;
using System;

namespace farm_classes.Test.Test;

public class CowTestTest
{
    public static TheoryData<int, string> CowData =>
       new TheoryData<int, string>
       {
            { 100, "Brown" },
            { 200, "White" },
            { 300, "Black" },
       };

    private CowTest _instance = new CowTest();

    [Trait("Category", "1 - Criou testes para o TestCowInstantiation")]
    [Theory(DisplayName = "TestCowInstantiation deve ser executado com sucesso ao atribuir parâmetros")]
    [MemberData(nameof(CowData))]
    public void TestSuccessTestCowInstantiation(int weight, string breed)
    {
        Action act = () => _instance.TestCowInstantiation(weight, weight, breed, breed);

        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "1 - Criou testes para o TestCowInstantiation")]
    [Theory(DisplayName = "TestCowInstantiation deve ser lançar erro com sucesso ao não atribuir parâmetros")]
    [MemberData(nameof(CowData))]
    public void TestFailTestCowInstantiation(int weight, string breed)
    {
        Action noWeightAttribution = () => _instance.TestCowInstantiation(weight, 0, breed, breed);
        Action noBreedAttribution = () => _instance.TestCowInstantiation(weight, weight, breed, null!);

        noWeightAttribution.Should().Throw<Xunit.Sdk.XunitException>();
        noBreedAttribution.Should().Throw<Xunit.Sdk.XunitException>();
    }
}

public class CowTestTest2
{
    public static TheoryData<int, string> CowData =>
       new TheoryData<int, string>
       {
            { 100, "Brown" },
            { 200, "White" },
            { 300, "Black" },
       };

    public static TheoryData<int, string> InvalidCowWeightData =>
        new TheoryData<int, string>
        {
            { 0, "Brown" },
            { -10, "Brown" },
            { -100, "Brown" },
        };

    private CowTest _instance = new CowTest();

    [Trait("Category", "2 - Criou testes para o TestCowInstantiationInvalidWeight")]
    [Theory(DisplayName = "TestCowInstantiationInvalidWeight não deve lançar erro caso o peso seja inválido")]
    [MemberData(nameof(InvalidCowWeightData))]
    public void TestSuccessTestCowInstantiationInvalidWeight(int weight, string breed)
    {
        Action act = () => _instance.TestCowInstantiationInvalidWeight(weight, breed);

        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "2 - Criou testes para o TestCowInstantiationInvalidWeight")]
    [Theory(DisplayName = "TestCowInstantiationInvalidWeight deve lançar erro caso o peso seja válido")]
    [MemberData(nameof(CowData))]
    public void TestFailTestCowInstantiationInvalidWeight(int weight, string breed)
    {
        Action act = () => _instance.TestCowInstantiationInvalidWeight(weight, breed);
        act.Should().Throw<Xunit.Sdk.XunitException>();
    }
}

public class CowTestTest3
{   
    public static TheoryData<int, string> CowData =>
       new TheoryData<int, string>
       {
            { 100, "Brown" },
            { 200, "White" },
            { 300, "Black" },
       };

    public static TheoryData<int, string> InvalidCowBreedData =>
        new TheoryData<int, string>
        {
            { 100, "" },
            { 100, null! },
        };

    private CowTest _instance = new CowTest();

    [Trait("Category", "3 - Criou testes para o TestCowInstantiationNullOrEmptyBreed")]
    [Theory(DisplayName = "TestCowInstantiationNullOrEmptyBreed não deve lançar erro caso a raça seja inválida")]
    [MemberData(nameof(InvalidCowBreedData))]
    public void TestSuccessTestCowInstantiationNullOrEmptyBreed(int weight, string breed)
    {
        Action act = () => _instance.TestCowInstantiationNullOrEmptyBreed(weight, breed);

        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "3 - Criou testes para o TestCowInstantiationNullOrEmptyBreed")]
    [Theory(DisplayName = "TestCowInstantiationNullOrEmptyBreed deve lançar erro caso a raça seja válida")]
    [MemberData(nameof(CowData))]
    public void TestFailTestCowInstantiationNullOrEmptyBreed(int weight, string breed)
    {
        Action act = () => _instance.TestCowInstantiationNullOrEmptyBreed(weight, breed);
        act.Should().Throw<Xunit.Sdk.XunitException>();
    }
}
