using Xunit;
using System;
using FluentAssertions;
using delivery_server.Test;

namespace delivery_server.Test.Test;

[Collection("Sequential")]
public class TestTestReq1
{
    [Trait("Category", "1 - Implementar o Item do pedido e seus testes")]
    [Theory(DisplayName = "TestCreateItem deve ser executado com sucesso com entradas corretas")]
    [InlineData("arroz", 32.0, 2000)]
    [InlineData("feijão", 34.0, 1000)]
    [InlineData("carne", 10.9, 100)]
    [InlineData("macarrão", 1.8, 10)]
    [InlineData("batara", 3.4, 1)]
    public void TestSucessTestCreateItem(string nameEntry, double priceEntry, int timeEntry)
    {
        TestReq1 instance = new();
        Action act = () => instance.TestCreateItem(nameEntry, priceEntry, timeEntry);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

}