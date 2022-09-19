using Xunit;
using FluentAssertions;
using delivery_server;
using System;

namespace delivery_server.Test;

public class TestReq1
{
    [Theory(DisplayName = "Deve construir um Item corretamente")]
    [InlineData("coxinha", 8.1, 20)]

    public void TestCreateItem(string nameEntry, double priceEntry, int timeEntry)
    {
        Item item = new(nameEntry, priceEntry,timeEntry);
        item.Name.Should().Be(nameEntry);
    }
}