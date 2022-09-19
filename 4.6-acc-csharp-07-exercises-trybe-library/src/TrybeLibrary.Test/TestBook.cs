using Xunit;
using FluentAssertions;
using System;
using TrybeLibrary;

namespace TrybeLibrary.Test;

public class TestBook
{
    [Trait("Category", "1 - Crie o enum BookTypes")]
    [Fact(DisplayName = "Deve ter criado corretamente o enum BookTypes")]    
    public void TestBookTypesExists()
    {
        BookTypes instance = new ();
        instance.GetType().IsInstanceOfType(typeof(Enum));
    }

    [Trait("Category", "1 - Crie o enum BookTypes")]
    [Theory(DisplayName = "BookType deve conter 6 tipos de livros")]
    [InlineData(0, "Fiction")]
    [InlineData(1, "NonFiction")]
    [InlineData(2, "Children")]
    [InlineData(3, "Science")]
    [InlineData(4, "Technology")]
    [InlineData(5, "Romance")]
    public void TestBookTypesCount(int type, string name)
    {
        BookTypes bookType = (BookTypes)type;
        bookType.ToString().Should().BeEquivalentTo(name);
    }
}
