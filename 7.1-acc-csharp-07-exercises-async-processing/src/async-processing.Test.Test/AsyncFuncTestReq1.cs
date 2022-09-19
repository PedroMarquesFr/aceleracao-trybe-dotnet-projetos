using Xunit;
using FluentAssertions;
using System;
using async_processing.Test;
using System.Threading.Tasks;
using System.Diagnostics;

namespace async_processing.Test.Test;

[Collection("Sequential")]
public class AsyncFuncTestReq1
{
    [Trait("Category", "1 - Transformar uma função que retona exeção em Assíncrono")]
    [Fact(DisplayName = "TestThrowSomeAsyncException deve ser executado com sucesso com entradas corretas")]
    public void TestSucessTestThrowSomeAsyncException()
    {
        AsyncFuncTest instance = new();
        Action act = () => instance.TestThrowSomeAsyncException();
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

}