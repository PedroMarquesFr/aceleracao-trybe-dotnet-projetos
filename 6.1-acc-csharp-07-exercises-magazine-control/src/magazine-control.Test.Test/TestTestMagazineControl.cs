using Xunit;
using FluentAssertions;
using System;
using System.Collections.Generic;

namespace magazine_control.Test.Test;

public class TestTestMagazineControlSaveMagazine
{
    [Trait("Category", "1 - Cadastrar uma revista")]
    [Theory(DisplayName = "TestCadastrarRevista deve ser executado com sucesso")]
    [MemberData(nameof(TestSaveMagazineData))]
    public void TestTestSaveMagazine(List<string> magazines, string name, List<string> expectedMagazines, int expectedReturn, bool isCorrect)
    {
        TestMagazineControl instance = new();
        Action act = () => instance.TestSaveMagazine(magazines, name, expectedMagazines, expectedReturn);
        if (isCorrect)
        {
            act.Should().NotThrow<Xunit.Sdk.XunitException>();
        }
        else
        {
            act.Should().Throw<Xunit.Sdk.XunitException>();
        }
        
        act.Should().NotThrow<NotImplementedException>();
    }

    public static TheoryData<List<string>, string, List<string>, int, bool> TestSaveMagazineData = new()
    {
        {
            new List<string>(){ "Mundo TI", "Natureza Espetacular" },
            "Escola Nova",
            new List<string>(){ "Mundo TI", "Natureza Espetacular", "Escola Nova" },
            2,
            true
        },
        {
            new List<string>(){ "Mundo TI", "Natureza Espetacular" }, 
            "Casa Bela",
            new List<string>(){ "Mundo TI", "Natureza Espetacular", "Casa Bela" },
            2,
            true
        },
        {
            new List<string>(){ "Natureza Espetacular" },
            "Aviação Civil",
            new List<string>(){ "Natureza Espetacular", "Aviação Civil" },
            1,
            true
        },
        {
            new List<string>(){ "Mundo TI", "Natureza Espetacular" },
            "Escola Nova",
            new List<string>(){ "Mundo TI", "Natureza Espetacular", "Escola Nova" },
            1,
            false
        },
        {
            new List<string>(){ "Mundo TI", "Natureza Espetacular" }, 
            "Casa Bela",
            new List<string>(){ "Mundo TI", "Natureza Espetacular", "Casa Bela2" },
            2,
            false
        }
    };
}

public class TestTestMagazineControlFindMagazinePosition
{

    [Trait("Category", "2 - Buscar a ordem de uma revista cadastrada na lista")]
    [Theory(DisplayName = "TestSaveMagazine deve testar corretamente os valores das revistas")] 
    [MemberData(nameof(TestFindMagazinePositionData))]
    public void TestTestFindMagazinePosition(List<string> magazines, string name, int expectedValue, bool isCorrect)
    {
        TestMagazineControl instance = new();
        Action act = () => instance.TestFindMagazinePosition(magazines, name, expectedValue);
        if (isCorrect)
        {
            act.Should().NotThrow<Xunit.Sdk.XunitException>();
        }
        else
        {
            act.Should().Throw<Xunit.Sdk.XunitException>();
        }
        
        act.Should().NotThrow<NotImplementedException>();
    }

    public static TheoryData<List<string>, string, int, bool> TestFindMagazinePositionData = new()
    {
        { new List<string>(){ "Mundo TI", "Escola Nova", "Casa Bonita", "Natureza Espetacular" }, "Casa Bela", -1, true },
        { new List<string>(){ "Mundo TI", "Escola Nova", "Casa Bonita", "Natureza Espetacular" }, "Mundo TI", 0, true },
        { new List<string>(){ "Mundo TI", "Escola Nova", "Casa Bonita", "Natureza Espetacular" }, "Escola Nova", 1, true },
        { new List<string>(){ "Mundo TI", "Escola Nova", "Casa Bonita", "Natureza Espetacular" }, "Casa Bonita", 2, true },
        { new List<string>(){ "Mundo TI", "Escola Nova", "Casa Bonita", "Natureza Espetacular" }, "Natureza Espetacular", 3, true },

        { new List<string>(){ "Mundo TI", "Escola Nova", "Casa Bonita", "Natureza Espetacular" }, "Casa Bonita", 0, false },
        { new List<string>(){ "Mundo TI", "Escola Nova", "Casa Bonita", "Natureza Espetacular" }, "Mundo TI", 1, false },
        { new List<string>(){ "Mundo TI", "Escola Nova", "Casa Bonita", "Natureza Espetacular" }, "Escola Nova", 0, false },
        { new List<string>(){ "Mundo TI", "Escola Nova", "Casa Bonita", "Natureza Espetacular" }, "Casa Bonita", -1, false },
        { new List<string>(){ "Mundo TI", "Escola Nova", "Casa Bonita", "Natureza Espetacular" }, "Natureza Espetacular", 2, false },
    };
}