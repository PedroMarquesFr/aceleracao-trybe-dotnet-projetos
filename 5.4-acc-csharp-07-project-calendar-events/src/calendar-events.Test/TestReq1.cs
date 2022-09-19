using Xunit;
using FluentAssertions;
using calendar_events;
using System;

namespace calendar_events.Test;

public class TestReq1
{
    [Theory(DisplayName = "Deve cadastrar um evento com o construtor completo")]
    [InlineData("Call trybe", "2022-10-10", "Apresentacao empresa parceira")]
    public void TestEventFullConstructor(string title, string date, string description)
    {
        Event instance = new(title, date, description);
        instance.Description.Should().Be(description);
        instance.EventDate.Should().Be(Convert.ToDateTime(date));
        instance.Title.Should().Be(title);
    }

    [Theory(DisplayName = "Deve cadastrar um evento com o construtor sem descrição")]
    [InlineData("Call trybe", "2022-10-10")]
    public void TestEventHalfConstructor(string title, string date)
    {
        Event instance = new(title, date);
        instance.EventDate.Should().Be(Convert.ToDateTime(date));
        instance.Title.Should().Be(title);
    }

    [Theory(DisplayName = "Deve atrasar a data de um evento corretamente")]
    [InlineData("Call trybe", "2022-10-10", 4, "2022-10-14")]
    public void TestEventDelayDate(string title, string date, int days, string expected)
    {
        Event instance = new(title, date);
        instance.DelayDate(days);
        var result = instance.EventDate;
        result.Should().Be(Convert.ToDateTime(expected));
    }

    [Theory(DisplayName = "Deve imprimir um evento corretamente")]
    [InlineData("Call trybe", "2022-10-10", "descricaoaooa", "detailed", "Evento = Call trybe\n Date = 10/10/2022\n Description = descricaoaooa")]
    public void TestPrintEvent(string title, string date, string description, string format, string expected)
    {
        Event instance = new(title, date, description);
        var result = instance.PrintEvent(format);
        result.Should().Be(expected);

    }


}