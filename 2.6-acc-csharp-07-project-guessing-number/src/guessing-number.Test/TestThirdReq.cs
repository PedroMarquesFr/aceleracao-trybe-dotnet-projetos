using Xunit;
using System.IO;
using System;
using Moq;
using guessing_number;
using FluentAssertions;

namespace guessing_number.Test;

[Collection("Sequential")]
public class TestThirdReq
{
    [Theory(DisplayName = "Deve receber a executar o fluxo completo do programa")]
    [InlineData(new object[] { new string[] { "10" }, 10 })]
    public void TestFullFlow(string[] entrys, int mockValue)
    {
        using var NewOutput = new StringWriter();
        GuessNumber instance = new() { randomValue = mockValue, userValue = Convert.ToInt32(entrys[^1]) };
        Console.SetOut(NewOutput);
        instance.AnalyzePlay();
        string result = NewOutput.ToString().Trim();
        string expectedMessage = "ACERTOU!";
        try
        {
            result.Should().Be(expectedMessage);
        }
        catch (System.Exception)
        {
            throw new OutOfMemoryException();
        }
    }
}