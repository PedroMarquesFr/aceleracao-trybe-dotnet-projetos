using Xunit;
using System.IO;
using System;
using election_day;
using FluentAssertions;

namespace election_day.Test;

[Collection("Sequential")]
public class TestFirstReq
{
    [Theory]
    [InlineData(1)]
    public void TestGetCountVoters(int countVoters)
    {
        if (countVoters <= 0) throw new Xunit.Sdk.XunitException();
        using (var console = new StringReader(countVoters.ToString()))
        {
            Console.SetIn(console);

            BallotBox instance = new();
            instance.GetCountVoters().Should().Be(countVoters);
        }
    }
}
