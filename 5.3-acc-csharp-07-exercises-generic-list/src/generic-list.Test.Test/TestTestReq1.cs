using Xunit;
using FluentAssertions;
using generic_list.Test;
using System;

namespace generic_list.Test.Test;

[Collection("Sequential")]
public class TestTestReq1
{
    [Trait("Category", "1 - Implementar a funcionalidade de Procurar por índice e seus testes")]
    [Theory(DisplayName = "TestIndex deve ser executado com sucesso com entradas corretas")]
    [InlineData(new int[]{3, 2, 1}, 0, 3)]
    [InlineData(new int[]{3, 2, 1}, 1, 2)]
    [InlineData(new int[]{3, 2, 1}, 2, 1)]
    [InlineData(new int[]{3, 2, 1, 9, 1}, 3, 9)]
    [InlineData(new int[]{3, 2, 1, 9, 1}, 4, 1)]
    public void TestSucessTestIndex(int[] list, int entry, int expected)
    {
        TestReq1 instance = new();
        Action act = () => instance.TestIndex(list, entry, expected);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "1 - Implementar a funcionalidade de Procurar por índice e seus testes")]
    [Theory(DisplayName = "TestIndex deve falhar quando executado com entradas erradas")]
    [InlineData(new int[]{3, 2, 1}, 0, 1)]
    [InlineData(new int[]{3, 2, 1}, 1, 1)]
    [InlineData(new int[]{3, 2, 1}, 2, 3)]
    [InlineData(new int[]{3, 2, 1, 9, 1}, 3, 11)]
    [InlineData(new int[]{3, 2, 1, 9, 1}, 4, 10)]
    public void TestFailTestIndex(int[] list, int entry, int expected)
    {
        TestReq1 instance = new();
        Action act = () => instance.TestIndex(list, entry, expected);
        act.Should().Throw<Xunit.Sdk.XunitException>();
    }

    [Trait("Category", "1 - Implementar a funcionalidade de Procurar por índice e seus testes")]
    [Theory(DisplayName = "TestIndexException deve ser executado com sucesso com entradas corretas")]
    [InlineData(new int[]{3, 2, 1}, 9)]
    [InlineData(new int[]{3, 2, 1}, 100)]
    [InlineData(new int[]{3, 2, 1}, 2000)]
    [InlineData(new int[]{3, 2, 1, 9, 1}, 5)]
    [InlineData(new int[]{3, 2, 1, 9, 1}, 11)]
    public void TestSucessTestIndexException(int[] list, int entry)
    {
        TestReq1 instance = new();
        Action act = () => instance.TestIndexException(list, entry);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
    
    [Trait("Category", "1 - Implementar a funcionalidade de Procurar por índice e seus testes")]
    [Theory(DisplayName = "TestIndexException deve falhar quando executado com entradas erradas")]
    [InlineData(new int[]{3, 2, 1}, 0)]
    [InlineData(new int[]{3, 2, 1}, 1)]
    [InlineData(new int[]{3, 2, 1}, 2)]
    [InlineData(new int[]{3, 2, 1, 9, 1}, 3)]
    [InlineData(new int[]{3, 2, 1, 9, 1}, 4)]
    public void TestFailTestIndexException(int[] list, int entry)
    {
        TestReq1 instance = new();
        Action act = () => instance.TestIndexException(list, entry);
        act.Should().Throw<Xunit.Sdk.XunitException>();
    }
}