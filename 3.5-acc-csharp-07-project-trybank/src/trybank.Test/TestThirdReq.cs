using Xunit;
using FluentAssertions;
using trybank;
using System;

namespace trybank.Test;

public class TestThirdReq
{
    [Theory(DisplayName = "Deve devolver o saldo em uma conta logada")]
    [InlineData(0)]
    public void TestCheckBalanceSucess(int balance)
    {
        // given
        Trybank trybank = new();

        // when
        trybank.RegisterAccount(1234, 123, 1010);
        trybank.Login(1234, 123, 1010);
        trybank.Bank[0, 3] = balance;
        int result = trybank.CheckBalance();

        // then
        result.Should().Be(balance);
    }

    [Theory(DisplayName = "Deve lançar uma exceção de usuário não logado")]
    [InlineData(0)]
    public void TestCheckBalanceWithoutLogin(int balance)
    {
        // given
        Trybank trybank = new();

        // when
        trybank.RegisterAccount(1234, 123, 1010);
        Action act = () => trybank.CheckBalance();

        // then
        act.Should().Throw<AccessViolationException>().WithMessage("Usuário já está logado");
    }

    [Theory(DisplayName = "Deve depositar um saldo em uma conta logada")]
    [InlineData(5000000)]
    public void TestDepositSucess(int value)
    {
        // given
        Trybank trybank = new();

        // when
        trybank.RegisterAccount(1234, 123, 1010);
        trybank.Login(1234, 123, 1010);
        trybank.Deposit(value);

        // then
        trybank.CheckBalance().Should().Be(value);
    }

    [Theory(DisplayName = "Deve lançar uma exceção de usuário não logado")]
    [InlineData(0)]
    public void TestDepositWithoutLogin(int value)
    {
        // given
        Trybank trybank = new();

        // when
        trybank.RegisterAccount(1234, 123, 1010);
        Action act = () => trybank.Deposit(value);

        // then
        act.Should().Throw<AccessViolationException>().WithMessage("Usuário já está logado");
    }

    [Theory(DisplayName = "Deve sacar um valor em uma conta logada")]
    [InlineData(4, 2)]
    public void TestWithdrawSucess(int balance, int value)
    {
        // given
        Trybank trybank = new();

        // when
        trybank.RegisterAccount(1234, 123, 1010);
        trybank.Login(1234, 123, 1010);
        trybank.Bank[0, 3] = balance;
        trybank.Withdraw(value);

        // then
        trybank.CheckBalance().Should().Be(balance - value);
    }

    [Theory(DisplayName = "Deve lançar uma exceção de usuário não logado")]
    [InlineData(0)]
    public void TestWithdrawWithoutLogin(int value)
    {
        // given
        Trybank trybank = new();

        // when
        trybank.RegisterAccount(1234, 123, 1010);
        Action act = () => trybank.Withdraw(value);

        // then
        act.Should().Throw<AccessViolationException>().WithMessage("Usuário já está logado");
    }

    [Theory(DisplayName = "Deve lançar uma exceção de Saldo insuficiente")]
    [InlineData(0, 4)]
    public void TestWithdrawWithoutBalance(int balance, int value)
    {
        // given
        Trybank trybank = new();

        // when
        trybank.RegisterAccount(1234, 123, 1010);
        trybank.Login(1234, 123, 1010);
        trybank.Bank[0, 3] = balance;
        Action act = () => trybank.Withdraw(value);

        // then
        act.Should().Throw<InvalidOperationException>().WithMessage("Saldo insuficiente");
    }
}