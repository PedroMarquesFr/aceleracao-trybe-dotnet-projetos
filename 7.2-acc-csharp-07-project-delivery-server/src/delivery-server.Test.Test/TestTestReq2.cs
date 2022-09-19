using Xunit;
using System;
using FluentAssertions;
using delivery_server.Test;
using System;
using System.Collections.Generic;

namespace delivery_server.Test.Test;

[Collection("Sequential")]
public class TestTestReq2
{
    public static IEnumerable<object[]> ItemTestData()
    {
        yield return new object[] {new Item("arroz", 32.0, 2000), 32};
        yield return new object[] {new Item("feijão", 12.0, 2000), 12};
        yield return new object[] {new Item("carne", 10.4, 2000), 2};
        yield return new object[] {new Item("macarrão", 1.5, 2000), 1};
        yield return new object[] {new Item("queijo", 9.3, 2000), 94};
    }
    public static IEnumerable<object[]> OrderTestData()
    {
        yield return new object[] { new Order(new Item("arroz", 32.0, 2000), 1)};
        yield return new object[] { new Order(new Item("feijão", 32.0, 1000), 2)};
        yield return new object[] { new Order(new Item("carne", 32.0, 500), 3)};
        yield return new object[] { new Order(new Item("macarrão", 32.0, 5000), 1)};
        yield return new object[] { new Order(new Item("batata", 32.0, 3000), 3)};
    }


    [Trait("Category", "2 - Implementar a classe Order e seus testes")]
    [Theory(DisplayName = "TestCreateOrder deve ser executado com sucesso com entradas corretas")]
    [MemberData(nameof(ItemTestData))]
    public void TestSucessTestCreateOrder(Item itemEntry, int quantityEntry)
    {
        TestReq2 instance = new();
        Action act = () => instance.TestCreateOrder(itemEntry, quantityEntry);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "2 - Implementar a classe Order e seus testes")]
    [Theory(DisplayName = "TestProcessOrder deve ser executado com sucesso com entradas corretas")]
    [MemberData(nameof(OrderTestData))]
    public void TestSucessTestProcessOrder(Order orderEntry)
    {
        TestReq2 instance = new();
        Action act = () => instance.TestProcessOrder(orderEntry);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

}