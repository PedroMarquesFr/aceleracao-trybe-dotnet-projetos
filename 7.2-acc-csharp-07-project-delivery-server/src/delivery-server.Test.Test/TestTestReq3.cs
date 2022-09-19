using Xunit;
using System;
using FluentAssertions;
using delivery_server.Test;
using System.Collections.Generic;

namespace delivery_server.Test.Test;

[Collection("Sequential")]
public class TestTestReq3
{
    public static IEnumerable<object[]> ItemTestData()
    {
        yield return new object[] {new Item("arroz", 32.0, 2000), 32};
        yield return new object[] {new Item("feijão", 12.0, 2000), 12};
        yield return new object[] {new Item("carne", 10.4, 2000), 2};
        yield return new object[] {new Item("macarrão", 1.5, 2000), 1};
        yield return new object[] {new Item("queijo", 9.3, 2000), 94};
    }

    [Trait("Category", "3 - Implementar o processamento dos pedidos e seus testes")]
    [Fact(DisplayName = "TestCreateProcessOrder deve ser executado com sucesso com entradas corretas")]    
    public void TestSucessTestCreateProcessOrder()
    {
        TestReq3 instance = new();
        Action act = () => instance.TestCreateProcessOrder();
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "3 - Implementar o processamento dos pedidos e seus testes")]
    [Theory(DisplayName = "TestAddOrderToProcess deve ser executado com sucesso com entradas corretas")]    
    [MemberData(nameof(ItemTestData))]
    public void TestSucessTestAddOrderToProcess(Item item, int quantity)
    {
        TestReq3 instance = new();
        Action act = () => instance.TestAddOrderToProcess(item, quantity);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

}