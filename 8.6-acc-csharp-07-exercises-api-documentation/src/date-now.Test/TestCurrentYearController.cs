using DateNow.Controllers;
using Xunit;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;

namespace DateNow.Test;

public class TestCurrentYearController
{
    [Theory]
    [InlineData(2022, true)]
    public void TestCurrentYearSuccess(int year, bool resultExpected)
    {
        CurrentYearController instance = new();
        var result = instance.Get() as OkObjectResult;

        ((int)result.Value == year).Should().Be(resultExpected);
    }
}
