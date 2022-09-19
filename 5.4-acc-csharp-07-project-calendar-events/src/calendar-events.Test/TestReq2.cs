using Xunit;
using FluentAssertions;
using calendar_events;
using System;

namespace calendar_events.Test;

public class TestReq2
{
    [Theory(DisplayName = "Deve procurar um evento por titulo")]
    [InlineData("Call trybe", "2022-10-10", "desc", 0)]
    public void TestListSearchByTitle(string title, string date, string description,int expected)
    {
        EventList eventList = new();
        eventList.Add(new Event(title, date, description));
        int result = eventList.SearchByTitle(title);
        result.Should().Be(expected);
    }

    [Theory(DisplayName = "Deve procurar um evento por data")]
    [InlineData("Call trybe", "2022-10-10", "desc", 0)]
    public void TestListSearchByDate(string title, string date, string description, int expected)
    {
        EventList eventList = new();
        eventList.Add(new Event(title, date, description));
        int result = eventList.SearchByDate(date);
        result.Should().Be(expected);
    }

    
}