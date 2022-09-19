using Xunit;
using System;
using FluentAssertions;
using app.Test;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Threading.Tasks;

namespace app.Test.Test;

[Collection("Sequential")]
public class TestFirstReq
{
    [Trait("Category", "1 - Criou testes de sucesso para o GetEndpointsReturnSuccess.")]
    [Theory(DisplayName = "GetEndpointsReturnSuccess deve ser executado com sucesso com rotas corretas")]
    [InlineData("/hello")]
    [InlineData("/hello/br")]
    [InlineData("/hello/en")]
    [InlineData("/hello/de")]
    [InlineData("/hello/es")]
    public async Task TestSucessGetEndpointsReturnSuccess(string url)
    {
        TestHello instance = new(new WebApplicationFactory<Program>());
        Func<Task> act = () => instance.GetEndpointsReturnSuccess(url);
        await act.Should().NotThrowAsync<Xunit.Sdk.XunitException>();
        await act.Should().NotThrowAsync<NotImplementedException>();
    }
}

public class TestFirstReq2
{
    [Trait("Category", "2 - Criou testes de falha para o GetEndpointsReturnSuccess.")]
    [Theory(DisplayName = "GetEndpointsReturnSuccess deve falhar quando executado com rotas que não existem")]
    [InlineData("/aa")]
    [InlineData("/opa")]
    [InlineData("/uepa")]
    [InlineData("/alo")]
    [InlineData("/uui")]
    public async Task TestFailGetEndpointsReturnSuccess(string url)
    {
        TestHello instance = new(new WebApplicationFactory<Program>());
        Func<Task> act = () => instance.GetEndpointsReturnSuccess(url);
        await act.Should().ThrowAsync<System.Net.Http.HttpRequestException>();
        await act.Should().NotThrowAsync<NotImplementedException>();
    }
}

public class TestFirstReq3
{
    [Trait("Category", "3 - Criou testes de sucesso para o GetEndpointsReturnContent.")]
    [Theory(DisplayName = "GetEndpointsReturnContent deve ser executado com sucesso com rotas corretas")]
    [InlineData("/hello/br", "[br] : Olá")]
    [InlineData("/hello/en", "[en] : Hello")]
    [InlineData("/hello/de", "[de] : Hallo")]
    [InlineData("/hello/es", "[es] : Hola")]
    [InlineData("/hello/aaa", "Não conheço essa!")]
    public async Task TestSucessGetEndpointsReturnContent(string url, string expectedContent)
    {
        TestHello instance = new(new WebApplicationFactory<Program>());
        Func<Task> act = () => instance.GetEndpointsReturnContent(url, expectedContent);
        await act.Should().NotThrowAsync<Xunit.Sdk.XunitException>();
        await act.Should().NotThrowAsync<NotImplementedException>();
    }
}

public class TestFirstReq4
{
    [Trait("Category", "4 - Criou testes de falha para o GetEndpointsReturnContent.")]
    [Theory(DisplayName = "GetEndpointsReturnContent deve falhar quando executado com rotas que não existem")]
    [InlineData("/hello/br", "[br] : Hello")]
    [InlineData("/hello/en", "[en] : Hallo")]
    [InlineData("/hello/de", "[de] : Hola")]
    [InlineData("/hello/es", "[es] : Olá")]
    [InlineData("/hello/aaa", "Hola")]
    public async Task TestFailGetEndpointsReturnContent(string url, string expectedContent)
    {
        TestHello instance = new(new WebApplicationFactory<Program>());
        Func<Task> act = () => instance.GetEndpointsReturnContent(url, expectedContent);
        await act.Should().ThrowAsync<Xunit.Sdk.XunitException>();
        await act.Should().NotThrowAsync<NotImplementedException>();
    }
}