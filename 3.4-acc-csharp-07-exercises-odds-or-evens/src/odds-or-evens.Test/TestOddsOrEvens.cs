using FluentAssertions;
using Xunit;

namespace OddsOrEvens.Test;

public class TestOddsOrEvens
{
    [Theory(DisplayName = "Teste de sucesso para verificar se a soma entre dois números é par ou ímpar")]
    [InlineData(2, 7, "Ímpar")]
    [InlineData(2, 6, "Par")]
    public void TestOddsOrEvensSuccess(int numberOne, int numberTwo, string resultExpected)
    {
        string result = OddsOrEvens.VerifyOddsOrEvens(OddsOrEvens.SumNumbers(numberOne, numberTwo));
        result.Should().Be(resultExpected);
    }

    [Theory(DisplayName = "Teste de exceção para verificar se a soma entre dois números é par ou ímpar")]
    [InlineData(10, 11)]
    public void TestOddsOrEvensException(int numberOne, int numberTwo)
    {
        Action act = () => OddsOrEvens.SumNumbers(numberOne, numberTwo);
        act.Should().Throw<ArgumentOutOfRangeException>();
    }
}
