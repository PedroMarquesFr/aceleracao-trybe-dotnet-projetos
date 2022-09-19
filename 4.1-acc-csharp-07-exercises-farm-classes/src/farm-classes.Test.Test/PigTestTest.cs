using Xunit;
using FluentAssertions;
using System;

namespace farm_classes.Test.Test;

public class PigTestTest
{
    public static TheoryData<int> PigData =>
        new TheoryData<int> { 3, 5, 7 };

    private PigTest _instance = new PigTest();

    [Trait("Category", "4 - Criou testes para o TestPigInstantiation")]
    [Theory(DisplayName = "TestPigInstantiation deve ser executado com sucesso ao atribuir parâmetros")]
    [MemberData(nameof(PigData))]
    public void TestSuccessTestPigInstantiation(int age)
    {
        Action act = () => _instance.TestPigInstantiation(age, age);

        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "4 - Criou testes para o TestPigInstantiation")]
    [Theory(DisplayName = "TestPigInstantiation deve lançar erro ao não atribuir parâmetros")]
    [MemberData(nameof(PigData))]
    public void TestFailTestPigInstantiationNegativeAge(int age)
    {
        Action act = () => _instance.TestPigInstantiation(age, 0);
        act.Should().Throw<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

public class PigTestTest2
{   
    public static TheoryData<int> PigData =>
        new TheoryData<int> { 3, 5, 7 };

    public static TheoryData<int> PigDataInvalidAge =>
        new TheoryData<int> { -1, -5, -10 };
        
    private PigTest _instance = new PigTest();

    [Trait("Category", "5 - Criou testes para o TestPigInstantiationInvalidAge")]
    [Theory(DisplayName = "TestPigInstantiationInvalidAge não deve lançar erro caso a idade seja inválida")]
    [MemberData(nameof(PigDataInvalidAge))]
    public void TestSuccessTestPigInstantiationInvalidAge(int age)
    {
        Action act = () => _instance.TestPigInstantiationInvalidAge(age);

        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "5 - Criou testes para o TestPigInstantiationInvalidAge")]
    [Theory(DisplayName = "TestPigInstantiationInvalidAge deve lançar caso a idade seja válida")]
    [MemberData(nameof(PigData))]
    public void TestFailTestPigInstantiationInvalidAge(int age)
    {
        Action act = () => _instance.TestPigInstantiationInvalidAge(age);
        act.Should().Throw<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}
