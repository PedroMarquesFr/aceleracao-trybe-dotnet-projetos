using Xunit;
using FluentAssertions;

namespace DateNow.Test.Test;

public class TestTestCurrentYearController
{
    [Trait("Category", "1 - Criou testes para o TestCurrentYearSuccess")]
    [Theory(DisplayName = "TestCurrentYearSuccess deve ser executado com sucesso")] 
    [InlineData(true)]
    public void TestSuccessTestCurrentYearSuccess(bool resultExpected)
    {   
        Action act = () => new TestCurrentYearController().TestCurrentYearSuccess(DateTime.Now.Year, resultExpected);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    } 

    [Trait("Category", "1 - Criou testes para o TestCurrentYearSuccess")]
    [Theory(DisplayName = "TestCurrentYearSuccess deve falhar com input de falha")] 
    [InlineData(2018, false)]
    [InlineData(2019, false)]
    [InlineData(2020, false)]
    [InlineData(2021, false)]
    public void TestFailTestCurrentYearSuccess(int year, bool resultUnexpected)
    {   
        Action act = () => new TestCurrentYearController().TestCurrentYearSuccess(year, resultUnexpected);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    } 

}
public class TestTestCurrentYearController2
{
    [Trait("Category", "2 - Testes de implementação de Swagger UI")]
    [Fact]
    public async void TestSwaggerUI() 
    {
        var client = new WebApplication().CreateClient();
        var response = await client.GetAsync("/swagger");
        response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
    }
}