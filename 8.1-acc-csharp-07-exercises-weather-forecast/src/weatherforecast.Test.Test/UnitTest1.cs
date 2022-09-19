using Xunit;
using FluentAssertions;
using weatherforecast;
using System;

namespace weatherforecast.Test.Test;

public class UnitTest1
{
    [Trait("Category", "1 - Criou o projeto")]
    [Fact(DisplayName = "Deve criar o projeto weatherforecast")]
    public void TestCreation()
    {
        WeatherForecast instance = new WeatherForecast();
        instance.Date = new DateTime();
        instance.TemperatureC = 0;
        instance.Summary = "teste";            
    }
}
