using Xunit;
using FluentAssertions;
using DataHandler.Test;
using System;

namespace DateHandler.Test.Test;

[Collection("Sequential")]
public class DateHandlerTestTest
{
    [Trait("Category", "1 - Criou testes de sucesso para o TestRemoveFirstEvent.")]
    [Theory(DisplayName = "TestRemoveFirstEvent deve remover o primeiro elemento do array")]
    [InlineData("2022-10-10", "2010-10-10")]
    [InlineData("2011-10-09", "2010-10-10")]
    [InlineData("2009-10-08", "2010-10-10")]
    [InlineData("2016-10-12", "2010-10-10")]
    [InlineData("3500-10-10", "2010-10-10")]
    public void TestTestRemoveFirstEventSucess(string d1, string d2)
    {
        DateHandlerTest instance = new();
        Action act = () => instance.TestRemoveFirstEvent(d1, d2);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }    
}
