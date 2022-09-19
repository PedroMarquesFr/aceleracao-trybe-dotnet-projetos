using Xunit;
using FluentAssertions;
using System;
using OddsOrEvens.Test;

namespace OddsOrEvens.Test.Test;

public class TestTestOddsOrEvens
{
    [Trait("Category", "1 - Criou testes para o TestOddsOrEvensSuccess")]
    [Theory(DisplayName = "TestOddsOrEvensSuccess deve ser executado com sucesso")] 
    [InlineData(2, 7, "Ímpar")]
    [InlineData(5, 5, "Par")]
    [InlineData(4, 10, "Par")]
    [InlineData(1, 2, "Ímpar")]
    public void TestSuccessTestOddsOrEvensSuccess(int numberOne, int numberTwo, string resultExpected)
    {
        var testClass = new TestOddsOrEvens();
        Action act = () => testClass.TestOddsOrEvensSuccess(numberOne, numberTwo, resultExpected);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

public class TestTestOddsOrEvens4
{
    [Trait("Category", "4 - Criou testes de falha para o TestOddsOrEvensException")]
    [Theory(DisplayName = "TestOddsOrEvensException deve falhar com input de sucesso")]
    [InlineData(10, 9)]
    [InlineData(5, 2)]
    [InlineData(8, 9)]
    [InlineData(0, 0)]
    public void TestFailTestOddsOrEvensException(int numberOne, int numberTwo)
    {
        var testClass = new TestOddsOrEvens();
        Action act = () => testClass.TestOddsOrEvensException(numberOne, numberTwo);
        act.Should().Throw<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}


public class TestTestOddsOrEvens2
{
    [Trait("Category", "2 - Criou testes de falha para o TestOddsOrEvensSuccess")]
    [Theory(DisplayName = "TestOddsOrEvensSuccess deve falhar com input de falha")]
    [InlineData(2, 7, "Par")]
    [InlineData(5, 5, "Ímpar")]
    [InlineData(4, 10, "Ímpar")]
    [InlineData(1, 2, "Par")]
    public void TestFailTestOddsOrEvensSuccess(int numberOne, int numberTwo, string resultUnexpected)
    {
        var testClass = new TestOddsOrEvens();
        Action act = () => testClass.TestOddsOrEvensSuccess(numberOne, numberTwo, resultUnexpected);
        act.Should().Throw<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

public class TestTestOddsOrEvens3
{
    [Trait("Category", "3 - Criou testes para o TestOddsOrEvensException")]
    [Theory(DisplayName = "TestOddsOrEvensException deve ser executado com sucesso com input de falha")]
    [InlineData(10, 11)]
    [InlineData(23, 56)]
    [InlineData(1, 16)]
    [InlineData(100, 4)]
    public void TestSuccessTestCalculateShippingException(int numberOne, int numberTwo)
    {
        var testClass = new TestOddsOrEvens();
        Action act = () => testClass.TestOddsOrEvensException(numberOne, numberTwo);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}
