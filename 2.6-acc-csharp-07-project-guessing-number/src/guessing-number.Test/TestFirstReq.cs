using Xunit;
using System.IO;
using System;
using guessing_number;
using FluentAssertions;

namespace guessing_number.Test;

[Collection("Sequential")]
public class TestFirstReq
{
    [Theory(DisplayName = "Deve exibir mensagem inicial!")]
    [InlineData(new object[] { new string[] { "---Bem-vindo ao Guessing Game---", "Para começar, tente adivinhar o número que eu pensei, entre -100 e 100!" } })]
    public void TestPrintInitialMessage(string[] expected)
    {
        GuessNumber instance = new();

        using var NewOutput = new StringWriter();

        Console.SetOut(NewOutput);
        instance.Greet();
        string result = NewOutput.ToString().Trim();
        result.Should().Be(string.Join("", expected));
    }

    [Theory(DisplayName = "Deve receber a entrada do usuário e converter para int")]
    [InlineData("0", 0)]
    public void TestReceiveUserInputAndConvert(string entry, int expected)
    {
        using var console = new StringReader(Convert.ToString(entry));
        Console.SetIn(console);
        GuessNumber instance = new();
        instance.ChooseNumber();
        instance.userValue.Should().Be(expected);
    }

    [Theory(DisplayName = "Deve receber a entrada do usuário e garantir que é um numérico")]
    [InlineData(new object[] {new string[]{"10,", "10"}, 10})]
    public void TestReceiveUserInputAndVerifyType(string[] entrys, int expected)
    {
        using var console1 = new StringReader(Convert.ToString(entrys[0]));
        using var console2 = new StringReader(Convert.ToString(entrys[^1]));
        {
            Console.SetIn(console1);
            Console.SetIn(console2);
            GuessNumber instance = new();
            instance.ChooseNumber();
            instance.userValue.Should().Be(expected);
        }
    }

    [Theory(DisplayName = "Deve receber a entrada do usuário e garantir que está entre -100 e 100!")]
    [InlineData(new object[] {new string[]{"1000", "10"}, 10})]
    public void TestReceiveUserInputAndVerifyRange(string[] entrys, int expected)
    {
        using var console1 = new StringReader(Convert.ToString(entrys[0]));
        using var console2 = new StringReader(Convert.ToString(entrys[^1]));
        {
            Console.SetIn(console1);
            Console.SetIn(console2);
            GuessNumber instance = new();
            instance.ChooseNumber();
            instance.userValue.Should().Be(expected);
        }

    }    
}