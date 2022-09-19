using Xunit;
using System.IO;
using System;
using election_day;
using FluentAssertions;

namespace election_day.Test;

[Collection("Sequential")]
public class TestThirdReq
{
    [Theory(DisplayName = "Deve imprimir o resultado")]
    [InlineData(new string[] { "6", "1", "1", "5", "A", "3", "2" }, 2, 1, 1, 2)]
    public void TestPrintResult(
        string[] entrys,
        int expectedReceivedOption1,
        int expectedReceivedOption2,
        int expectedReceivedOption3,
        int expectedOptionNull)
    {
        BallotBox instance = new();

        foreach (var entry in entrys)
        {
            if (!Int32.TryParse(entry, out var holder)) continue;
            switch (entry)
            {
                case "1":
                    instance.receivedOption1 += 1;
                    break;
                case "2":
                    instance.receivedOption2 += 1;
                    break;
                case "3":
                    instance.receivedOption3 += 1;
                    break;
                default:
                    instance.optionNull += 1;
                    break;
            }
        }
        using (var NewOutput = new StringWriter())
        {
            Console.SetOut(NewOutput);

            instance.PrintResult();

            string result = NewOutput.ToString().Trim();

            var response = new string[] {
                $"A opção 1 recebeu: {expectedReceivedOption1} voto(s)",
                $"A opção 2 recebeu: {expectedReceivedOption2} voto(s)",
                $"A opção 3 recebeu: {expectedReceivedOption3} voto(s)",
                $"Total de votos anulados: {expectedOptionNull} voto(s)",
            };
            var teste = string.Join("\n", response);

            teste.Should().Be(teste);
        }
    }
}