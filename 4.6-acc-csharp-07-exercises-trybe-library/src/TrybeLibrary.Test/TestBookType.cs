using Xunit;
using FluentAssertions;
using System;
using TrybeLibrary;

namespace TrybeLibrary.Test;

public class TestBookType
{
    [Trait("Category", "2 - Crie a struct Book")]
    [Fact(DisplayName = "Deve ter criado corretamente a struct Book")]    
    public void TestBookExists()
    {
        Book instance = new ();
        instance.GetType().IsInstanceOfType(typeof(Book));
    }

// ???
    [Trait("Category", "2 - Crie a struct Book")]
    [Fact(DisplayName = "Deve ter criado corretamente a struct Book")]    
    public void TestBookTypeExists()
    {
        Book instance = new ();
        instance.GetType().IsInstanceOfType(typeof(Book));
    }
}
