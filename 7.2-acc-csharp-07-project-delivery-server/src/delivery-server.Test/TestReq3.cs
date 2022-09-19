using Xunit;
using FluentAssertions;
using delivery_server;
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;

namespace delivery_server.Test;

public class TestReq3
{

    public static IEnumerable<object[]> ItemTestData()
    {
        yield return new object[] { new Item("arroz", 32.0, 2000), 32 };
        yield return new object[] { new Item("feijão", 12.0, 2000), 12 };
        yield return new object[] { new Item("carne", 10.4, 2000), 2 };
        yield return new object[] { new Item("macarrão", 1.5, 2000), 1 };
        yield return new object[] { new Item("queijo", 9.3, 2000), 94 };
    }


    [Fact(DisplayName = "Deve construir uma ProcessOrders corretamente")]
    public void TestCreateProcessOrder()
    {
        var OrderHandler = new ProcessOrders();
        OrderHandler.TimeToCheck.Should().Be(1);
        OrderHandler.OrdersList.Should().BeOfType<ArrayList>();
    }

    [Theory(DisplayName = "Deve adicionar uma Order ao arrayList de Orders")]
    [MemberData(nameof(ItemTestData))]
    public void TestAddOrderToProcess(Item item, int quantity)
    {
        var OrderHandler = new ProcessOrders();
        OrderHandler.AddOrder(item, quantity);
        OrderHandler.OrdersList.Count.Should().Be(1);
    }

}