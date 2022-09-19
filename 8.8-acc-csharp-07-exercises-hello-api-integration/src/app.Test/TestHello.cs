using Xunit;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Threading.Tasks;
using System.Net;

namespace app.Test;

public class TestHello : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public TestHello(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Theory(DisplayName = "Hello deve responder com status com 200 ~ 299 para rotas")]        
    [InlineData("/hello")]
    [InlineData("/hello/br")]
    [InlineData("/hello/en")]
    [InlineData("/hello/de")]
    [InlineData("/hello/es")]
    [InlineData("/hello/aaa")]
    public async Task GetEndpointsReturnSuccess(string url)
    {        
        var client = _factory.CreateClient();
        var response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();
        response.Content.Headers.ContentType.ToString().Should().Be("text/plain; charset=utf-8");
    }

    [Theory(DisplayName = "Hello deve responder com a resposta correta")]    
    [InlineData("/hello/br", "[br] : Olá")]
    [InlineData("/hello/en", "[en] : Hello")]
    [InlineData("/hello/de", "[de] : Hallo")]
    [InlineData("/hello/es", "[es] : Hola")]
    [InlineData("/hello/aaa", "Não conheço essa!")]
    public async Task GetEndpointsReturnContent(string url, string expectedContent)
    {        
        var client = _factory.CreateClient();
        var clientResponse = await client.GetAsync(url);
        var resultContent = clientResponse.Content.ReadAsStringAsync().GetAwaiter().GetResult();
        resultContent.Should().Be(expectedContent);
    }
}