using Xunit;
using FluentAssertions;
using trybank;
using System;

namespace trybank.Test;

public class TestSecondReq
{
    [Theory(DisplayName = "Deve logar em uma conta!")]
    [InlineData(1, 2, 3)]
    public void TestLoginSucess(int number, int agency, int pass)
    {
        // given
        Trybank trybank = new();

        // when
        trybank.RegisterAccount(number, agency, pass);
        trybank.Login(number, agency, pass);

        // then
        trybank.Logged.Should().Be(true);
        trybank.loggedUser.Should().Be(0);
    }

    [Theory(DisplayName = "Deve retornar exceção ao tentar logar em conta já logada")]
    [InlineData(4, 5, 6)]
    public void TestLoginExceptionLogged(int number, int agency, int pass)
    {
        // given
        Trybank trybank = new();

        // when
        trybank.RegisterAccount(number, agency, pass);
        trybank.Login(number, agency, pass);
        Action act = () => trybank.Login(number, agency, pass);

        // then
        act.Should().Throw<AccessViolationException>().WithMessage("Usuário já está logado");
    }

    [Theory(DisplayName = "Deve retornar exceção ao errar a senha")]
    [InlineData(4, 5, 6)]
    public void TestLoginExceptionWrongPass(int number, int agency, int pass)
    {
        // given
        Trybank trybank = new();

        // when
        trybank.RegisterAccount(number, agency, pass);
        Action act = () => trybank.Login(number, agency, 7);

        // then
        act.Should().Throw<ArgumentException>().WithMessage("Senha incorreta");
    }

    [Theory(DisplayName = "Deve retornar exceção ao digitar conta que não existe")]
    [InlineData(4, 5, 6)]
    public void TestLoginExceptionNotFounded(int number, int agency, int pass)
    {
        // given
        Trybank trybank = new();

        // when
        trybank.RegisterAccount(9, 9, 9);
        Action act = () => trybank.Login(number, agency, pass);

        // then
        act.Should().Throw<ArgumentException>().WithMessage("Agência + Conta não encontrada");
    }

    [Theory(DisplayName = "Deve sair de uma conta!")]
    [InlineData(4, 5, 6)]
    public void TestLogoutSucess(int number, int agency, int pass)
    {
        // given
        Trybank trybank = new();

        // when
        trybank.RegisterAccount(number, agency, pass);
        trybank.Login(number, agency, pass);
        trybank.Logout();

        // then
        trybank.Logged.Should().Be(false);
        trybank.loggedUser.Should().Be(-99);
        
    }

    [Theory(DisplayName = "Deve retornar exceção ao sair quando não está logado")]
    [InlineData(0, 0, 0)]
    public void TestLogoutExceptionNotLogged(int number, int agency, int pass)
    {
        // given
        Trybank trybank = new();

        // when
        Action act = () => trybank.Logout();

        // then
        act.Should().Throw<AccessViolationException>().WithMessage("Usuário não está logado");
    }

}
