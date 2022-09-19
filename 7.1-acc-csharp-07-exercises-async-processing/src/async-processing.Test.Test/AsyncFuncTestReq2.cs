using Xunit;
using FluentAssertions;
using System;
using async_processing.Test;
using System.Threading.Tasks;
using System.Diagnostics;

namespace async_processing.Test.Test;

[Collection("Sequential")]
public class AsyncFuncTestReq2
{
    [Trait("Category", "2 - Transformar uma função que dobra o valor da entrada em Assíncrono")]
    [Theory(DisplayName = "TestDoubleTheValueInGenericEntry deve ser executado com sucesso com entradas corretas")]
    [InlineData(1, 1000, 2)]
    [InlineData(2, 2000, 4)]
    [InlineData(3, 3000, 6)]
    [InlineData(4, 4000, 8)]
    [InlineData(5, 5000, 10)]
    public async Task TestSucessTestDoubleTheValueInGenericEntry(int entry, int delay, int expectedValue)
    {
        AsyncFuncTest instance = new();
        var act = () => instance.TestDoubleTheValueInGenericEntry(entry, delay, expectedValue);
        await act.Should().NotThrowAsync<Xunit.Sdk.XunitException>();
        await act.Should().NotThrowAsync<NotImplementedException>();
    }

    [Trait("Category", "2 - Transformar uma função que dobra o valor da entrada em Assíncrono")]
    [Theory(DisplayName = "TestDoubleTheValueInGenericEntry deve falhar com entradas incorretas")]
    [InlineData(1, 0, 3)]
    [InlineData(2, 0, 5)]
    [InlineData(3, 0, 5)]
    [InlineData(4, 0, 6)]
    [InlineData(5, 0, 17)]
    public async Task TestFailTestDoubleTheValueInGenericEntry(int entry, int delay, int expectedValue)
    {
        AsyncFuncTest instance = new();
        var act = () => instance.TestDoubleTheValueInGenericEntry(entry, delay, expectedValue);
        await act.Should().ThrowAsync<Xunit.Sdk.XunitException>();
        await act.Should().NotThrowAsync<NotImplementedException>();
    }

}
