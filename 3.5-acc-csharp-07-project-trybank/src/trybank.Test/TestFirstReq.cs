using Xunit;
using FluentAssertions;
using trybank;
using System;

namespace trybank.Test;

public class TestFirstReq
{
    [Theory(DisplayName = "Deve cadastrar contas com sucesso!")]
    [InlineData(1, 2, 3)]
    public void TestRegisterAccountSucess(int number, int agency, int pass)
    {
        // given
        Trybank trybank = new();

        // when
        trybank.RegisterAccount(number, agency, pass);

        // then
        trybank.Bank[0, 0].Should().Be(number);
        trybank.Bank[0, 1].Should().Be(agency);
        trybank.Bank[0, 2].Should().Be(pass);
    }

    [Theory(DisplayName = "Deve retornar ArgumentException ao cadastrar contas que já existem")]
    [InlineData(1, 2, 3)]
    public void TestRegisterAccountException(int number, int agency, int pass)
    {
        // given
        Trybank trybank = new();

        // when
        trybank.Bank[0, 0] = number;
        trybank.Bank[0, 1] = agency;
        trybank.Bank[0, 2] = pass;
        Action act = () => trybank.RegisterAccount(number, agency, pass);

        // then
        act.Should().Throw<ArgumentException>().WithMessage("A conta já está sendo usada!");
    }
}