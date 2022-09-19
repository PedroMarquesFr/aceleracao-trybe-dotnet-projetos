using Xunit;
using FluentAssertions;
using System;

namespace BiggestNumber.Test;

public class TestBiggestNumber
{
    [Theory]
    [InlineData(0, 0, 0, 0)]
    [InlineData(7, 8, 9, 9)]
    [InlineData(7, 9, 8, 9)]
    [InlineData(8, 9, 7, 9)]
    [InlineData(8, 7, 9, 9)]
    [InlineData(9, 7, 8, 9)]
    [InlineData(9, 8, 7, 9)]
    public void TestIdentifyBiggestNumberSucess(int first, int second, int third, int expectedNumber)
    {
        var result = BiggestNumber.IdentifyBiggestNumber(first, second, third);
        result.Should().Be(expectedNumber);
    }
}