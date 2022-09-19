using Xunit;
using System.IO;
using System;
using Moq;
using guessing_number;
using FluentAssertions;

namespace guessing_number.Test;

[Collection("Sequential")]
public class TestSecondReq
{
    [Theory(DisplayName = "Deve escolher randomicamente um número entre -100 e 100!")]
    [InlineData(-100, 100)]
    public void TestRandomlyChooseANumber(int MinimumRange, int MaximumRange)
    {
        GuessNumber instance = new();
        instance.RandomNumber();
        instance.randomValue.Should().BeGreaterThanOrEqualTo(MinimumRange);
        instance.randomValue.Should().BeLessThanOrEqualTo(MaximumRange);
    }

    [Theory(DisplayName = "Deve comparar a entrada do usuário em um caso MENOR")]
    [InlineData(50, 0)]
    public void TestProgramComparisonValuesLess(int mockValue, int entry)
    {
        GuessNumber instance = new();
        using var NewOutput = new StringWriter();
        Console.SetOut(NewOutput);

        instance.randomValue = mockValue;
        instance.userValue = entry;
        instance.AnalyzePlay();

        string result = NewOutput.ToString().Trim();
        result.Should().Be("Tente um número MAIOR");
    }
    [Theory(DisplayName = "Deve comparar a entrada do usuário em um caso MAIOR")]
    [InlineData(50, 60)]
    public void TestProgramComparisonValuesBigger(int mockValue, int entry)
    {
        GuessNumber instance = new();
        using var NewOutput = new StringWriter();
        Console.SetOut(NewOutput);

        instance.randomValue = mockValue;
        instance.userValue = entry;
        instance.AnalyzePlay();

        string result = NewOutput.ToString().Trim();
        result.Should().Be("Tente um número MENOR");
    }

    [Theory(DisplayName = "Deve comparar a entrada do usuário em um caso IGUAL")]
    [InlineData(50, 50)]
    public void TestProgramComparisonValuesEqual(int mockValue, int entry)
    {
        GuessNumber instance = new();
        using var NewOutput = new StringWriter();
        Console.SetOut(NewOutput);

        instance.randomValue = mockValue;
        instance.userValue = entry;
        instance.AnalyzePlay();

        string result = NewOutput.ToString().Trim();
        result.Should().Be("ACERTOU!");
    }
}