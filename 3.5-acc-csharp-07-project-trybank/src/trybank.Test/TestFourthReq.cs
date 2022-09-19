using Xunit;
using FluentAssertions;
using trybank;
using System;

namespace trybank.Test;

public class TestFourthReq
{
    [Theory(DisplayName = "Deve transefir um valor com uma conta logada")]
    [InlineData(1000, 400)]
    public void TestTransferSucess(int balance, int value)
    {
        // given
        Trybank trybank = new();

        // when
        trybank.RegisterAccount(1234, 123, 1010);
        trybank.RegisterAccount(5678, 567, 2020);
        trybank.Login(1234, 123, 1010);
        trybank.Bank[0, 3] = balance;
        trybank.Transfer(5678, 567, value);

        // then
        trybank.Bank[1, 3].Should().Be(value);
        trybank.CheckBalance().Should().Be(balance - value);
    }

    [Theory(DisplayName = "Deve lançar uma exceção de usuário não logado")]
    [InlineData(0)]
    public void TestTransferWithoutLogin(int value)
    {
        // given
        Trybank trybank = new();

        // when
        trybank.RegisterAccount(1234, 123, 1010);
        trybank.RegisterAccount(5678, 567, 2020);
        Action act = () => trybank.Transfer(5678, 567, value);

        // then
        act.Should().Throw<AccessViolationException>().WithMessage("Usuário já está logado");
    }

    [Theory(DisplayName = "Deve lançar uma exceção de Saldo insuficiente")]
    [InlineData(1000, 1001)]
    public void TestTransferWithoutBalance(int balance, int value)
    {
        // given
        Trybank trybank = new();

        // when
        trybank.RegisterAccount(1234, 123, 1010);
        trybank.RegisterAccount(5678, 567, 2020);
        trybank.Login(1234, 123, 1010);
        trybank.Bank[0, 3] = balance;
        Action act = () => trybank.Transfer(5678, 567, value);

        // then
        act.Should().Throw<InvalidOperationException>().WithMessage("Saldo insuficiente");
    }
}
