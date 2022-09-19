using Xunit;
using System.IO;
using System;
using election_day;
using FluentAssertions;

namespace election_day.Test;

[Collection("Sequential")]
public class TestSecondReq
{
    [Theory(DisplayName = "Deve ler os votos")]
    [InlineData(2, 2)]
    public void TestStart(int countVoters, int printExpected)
    {
        using (var console = new StringReader(countVoters.ToString()))
        {
            Console.SetIn(console);
            BallotBox instance = new();
            instance.Start(countVoters);
            countVoters.Should().Be(printExpected);
        }
    }
}