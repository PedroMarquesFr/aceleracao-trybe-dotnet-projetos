using Xunit;
using FluentAssertions;
using ola_mundo.Test;
using System;

namespace ola_mundo.Test.Test;

public class OlaMundoTestTest2
{
    [Trait("Category", "Complete o teste para o Olá, Mundo!.")]
    [Theory(DisplayName = "TestOlaMundo deve falhar quando não printar Olá, Mundo!")]
    [InlineData("Hello World!")]
    [InlineData("Olá MUNDO")]
    [InlineData("ola mundo")]
    public void TestFailTestOlaMundo(string Entry)
    {
        OlaMundoTest instance = new();
        Action act = () => instance.TestOlaMundo(Entry);
        act.Should().Throw<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

public class OlaMundoTestTest1
{

    [Trait("Category", "Imprima \"Olá, Mundo!\" no Console.")]
    [Theory(DisplayName = "TestOlaMundo deve ser executado com sucesso quando printar Olá, Mundo!")]
    [InlineData("Olá, Mundo!")]
    public void TestSucessTestOlaMundo(string Entry)
    {
        OlaMundoTest instance = new();
        Action act = () => instance.TestOlaMundo(Entry);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}
