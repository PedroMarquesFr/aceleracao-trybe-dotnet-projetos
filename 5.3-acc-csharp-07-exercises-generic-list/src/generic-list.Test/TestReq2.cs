using Xunit;
using FluentAssertions;
using generic_list;
using System;

namespace generic_list.Test;

public class TestReq2
{
    [Theory(DisplayName = "Deve retornar o indice correto ao item passado por parâmetro.")]
    [InlineData(new int[]{3, 2, 1}, 3, 0)]
    [InlineData(new int[]{3, 2, 1}, 2, 1)]
    [InlineData(new int[]{3, 2, 1}, 1, 2)]
    [InlineData(new int[]{3, 2, 1, 9, 1}, 9, 3)]
    [InlineData(new int[]{3, 2, 1, 9, 11}, 11, 4)]
    public void TestSearch(int[] list, int entry, int expected)
    {
        GenericList<int> genericList = new();
        foreach (var item in list)
        {
            genericList.Add(item);
        }

        genericList.Search(entry).Should().Be(expected);
    }


    [Theory(DisplayName = "Deve retornar uma exeção quando passado um item que não está na lista")]
    [InlineData(new int[]{3, 2, 1}, 11)]
    [InlineData(new int[]{3, 2, 1}, -2)]
    [InlineData(new int[]{3, 2, 1}, -1)]
    [InlineData(new int[]{3, 2, 1, 9, 1}, 99)]
    [InlineData(new int[]{3, 2, 1, 9, 11}, 1111)]
    public void TestSearchException(int[] list, int entry)
    {
        GenericList<int> genericList = new();
        foreach (var item in list)
        {
            genericList.Add(item);
        }

        Action act = () => genericList.Search(entry);
        act.Should().Throw<InvalidOperationException>().WithMessage("Elemento não está na lista");
    }

}