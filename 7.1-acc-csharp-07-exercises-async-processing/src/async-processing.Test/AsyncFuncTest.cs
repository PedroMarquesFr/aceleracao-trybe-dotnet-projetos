using Xunit;
using FluentAssertions;
using System;
using async_processing;
using System.Threading.Tasks;
using System.Diagnostics;

namespace async_processing.Test;

[Collection("Sequential")]
public class AsyncFuncTest
{
    [Fact(DisplayName = "DoubleTheValueInGenericEntry deve ser assincrono e retornar a resposta correta após o tempo decorrido")]
    public async Task TestThrowSomeAsyncException()
    {
        AsyncFunc instance = new();
        var act = async () => { await instance.ThrowSomeAsyncException(); };
        await act.Should().ThrowAsync<Exception>();
    }


    [Theory(DisplayName = "DoubleTheValueInGenericEntry deve ser assincrono e retornar a resposta correta após o tempo decorrido")]
    [InlineData(20, 500, 40)]
    public async Task TestDoubleTheValueInGenericEntry(int entry, int delay, int expectedValue)
    {
        AsyncFunc instance = new();
        var result = await instance.DoubleTheValueInGenericEntry(entry, delay);
        result.Should().Be(expectedValue);
        
    }

}