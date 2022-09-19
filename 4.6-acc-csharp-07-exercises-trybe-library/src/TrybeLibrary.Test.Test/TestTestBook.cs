using Xunit;
using FluentAssertions;
using System;

namespace TrybeLibrary.Test.Test;

public class TestTestBook
{
    [Trait("Category", "2 - Crie a struct Book")]
    [Fact(DisplayName = "TestBookExists deve ser executado com sucesso com entradas corretas")]    
    public void TestSucessTestBookExists()
    {
        TestBookType instance = new();
        Action act = () => instance.TestBookExists();
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "2 - Crie a struct Book")]
    [Fact(DisplayName = "TestBookTypeExists deve ser executado com sucesso com entradas corretas")]    
    public void TestSucessTestBookTypeExists()
    {
        TestBookType instance = new();
        Action act = () => instance.TestBookTypeExists();
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}