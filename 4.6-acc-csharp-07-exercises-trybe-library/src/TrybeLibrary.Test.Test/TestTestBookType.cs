using Xunit;
using System;
using FluentAssertions;
using TrybeLibrary.Test;

namespace TrybeLibrary.Test.Test;

public class TestTestBookType
{
    [Trait("Category", "1 - Crie o enum BookTypes")]
    [Fact(DisplayName = "TestBookTypesExists deve ser executado com sucesso com entradas corretas")]    
    public void TestSucessTestBookTypesExists()
    {
        TestBook instance = new();
        Action act = () => instance.TestBookTypesExists();
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "1 - Crie o enum BookTypes")]
    [Theory(DisplayName = "TestBookTypesExists deve ser executado com sucesso com entradas corretas")]
    [InlineData(0, "Fiction")]
    [InlineData(1, "NonFiction")]
    [InlineData(2, "Children")]
    [InlineData(3, "Science")]
    [InlineData(4, "Technology")]
    [InlineData(5, "Romance")]
    public void TestSucessTestBookTypesCount(int type, string name)
    {
        TestBook instance = new();
        Action act = () => instance.TestBookTypesCount(type, name);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}