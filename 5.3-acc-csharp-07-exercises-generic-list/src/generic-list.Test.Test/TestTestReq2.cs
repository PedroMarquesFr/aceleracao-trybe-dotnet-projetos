using Xunit;
using FluentAssertions;
using generic_list.Test;
using System;

namespace generic_list.Test.Test;

[Collection("Sequential")]
public class UnitTest1
{
    [Trait("Category", "2 - Implementar a funcionalidade de Procurar por Elemento e seus testes")]
    [Theory(DisplayName = "TestSearch deve ser executado com sucesso com entradas corretas")]
    [InlineData(new int[]{3, 2, 1}, 3, 0)]
    [InlineData(new int[]{3, 2, 1}, 2, 1)]
    [InlineData(new int[]{3, 2, 1}, 1, 2)]
    [InlineData(new int[]{3, 2, 1, 9, 1}, 9, 3)]
    [InlineData(new int[]{3, 2, 1, 9, 11}, 11, 4)]
    public void TestSucessTestSearch(int[] list, int entry, int expected)
    {
        TestReq2 instance = new();
        Action act = () => instance.TestSearch(list, entry, expected);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
    
    [Trait("Category", "2 - Implementar a funcionalidade de Procurar por Elemento e seus testes")]
    [Theory(DisplayName = "TestSearch deve falhar quando executado com entradas erradas")]
    [InlineData(new int[]{3, 2, 1}, 1, 12)]
    [InlineData(new int[]{3, 2, 1}, 2, 13)]
    [InlineData(new int[]{3, 2, 1}, 3, 31)]
    [InlineData(new int[]{3, 2, 1, 9, 1}, 9, 111)]
    [InlineData(new int[]{3, 2, 1, 9, 1}, 1, 101)]
    public void TestFailTestSearch(int[] list, int entry, int expected)
    {
        TestReq2 instance = new();
        Action act = () => instance.TestSearch(list, entry, expected);
        act.Should().Throw<Xunit.Sdk.XunitException>();
    }


    [Trait("Category", "2 - Implementar a funcionalidade de Procurar por Elemento e seus testes")]
    [Theory(DisplayName = "TestSearchException deve ser executado com sucesso com entradas corretas")]
    [InlineData(new int[]{3, 2, 1}, 11)]
    [InlineData(new int[]{3, 2, 1}, -2)]
    [InlineData(new int[]{3, 2, 1}, -1)]
    [InlineData(new int[]{3, 2, 1, 9, 1}, 99)]
    [InlineData(new int[]{3, 2, 1, 9, 11}, 1111)]
    public void TestSucessTestSearchException(int[] list, int entry)
    {
        TestReq2 instance = new();
        Action act = () => instance.TestSearchException(list, entry);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
    
    [Trait("Category", "2 - Implementar a funcionalidade de Procurar por Elemento e seus testes")]
    [Theory(DisplayName = "TestSearchException deve falhar quando executado com entradas erradas")]
    [InlineData(new int[]{3, 2, 1}, 3)]
    [InlineData(new int[]{3, 2, 1}, 2)]
    [InlineData(new int[]{3, 2, 1}, 1)]
    [InlineData(new int[]{3, 2, 1, 9, 1}, 1)]
    [InlineData(new int[]{3, 2, 1, 9, 11}, 11)]
    public void TestFailTestSearchException(int[] list, int entry)
    {
        TestReq2 instance = new();
        Action act = () => instance.TestSearchException(list, entry);
        act.Should().Throw<Xunit.Sdk.XunitException>();
    }
}