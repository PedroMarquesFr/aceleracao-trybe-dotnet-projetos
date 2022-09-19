using Xunit;
using FluentAssertions;
using conversion_tools;
using System;

namespace conversion_tools.Test;

public class TestFirstRequirement
{
    [Theory]
    [InlineData("1", 1)]
    public void TestConvertStrToInt(string entry, int expected)
    {
        //given
        ConversionTools instance = new();

        //when
        instance.strVariable = entry;
        instance.ConvertStrToInt();

        //then
        instance.intVariable.Should().Be(expected);
    }
}

public class TestSecondRequirement
{
    [Theory]
    [InlineData("1.0", 1.0)]
    public void TestConvertStrToDouble(string entry, double expected)
    {
        //given
        ConversionTools instance = new();

        //when
        instance.strVariable = entry;
        instance.ConvertStrToDouble();

        //then
        instance.doubleVariable.Should().Be(expected);
    }
}

public class TestThirdRequirement
{
    [Theory]
    [InlineData(1, "1")]
    public void TestConvertIntToStr(int entry, string expected)
    {
        //given
        ConversionTools instance = new();

        //when
        instance.intVariable = entry;
        instance.ConvertIntToStr();

        //then
        instance.strVariable.Should().Be(expected);
    }
}

public class TestFourthRequirement
{
    [Theory]
    [InlineData(4.1, "4.1")]
    public void TestConvertDoubleToStr(double entry, string expected)
    {
        //given
        ConversionTools instance = new();

        //when
        instance.doubleVariable = entry;
        instance.ConvertDoubleToStr();

        //then
        instance.strVariable.Should().Be(expected);
    }
}
