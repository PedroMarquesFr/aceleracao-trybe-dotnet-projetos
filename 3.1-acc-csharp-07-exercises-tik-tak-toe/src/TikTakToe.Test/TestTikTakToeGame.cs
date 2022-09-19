using Xunit;
using System.IO;
using System;
using TikTakToe;
using FluentAssertions;

namespace TikTakToe.Test;

[Collection("Sequential")]
public class TestTikTakToeGame
{
    [Theory(DisplayName = "Deve preencher o tabuleiro com o caractere correto na posição adequada")]
    [InlineData(
        1,
        1,
        'x',
        new char[] {
            ' ', ' ', ' ',
            ' ', 'x', ' ',
            ' ', ' ', ' '
        }
    )]
    [InlineData(
        0,
        1,
        'x',
        new char[] {
            ' ', 'y', ' ',
            ' ', ' ', ' ',
            ' ', ' ', ' '
        }
    )]
    public void TestMakeMove(int lineEntry, int columnEntry, char playerEntry, char[] expected)
    {
        TikTakToeGame tikTakToeGame = new();
        char[,] entry = fromArrayToMultiDimArray(expected, 3, 3);
        tikTakToeGame.board = entry;
        // if (entry[lineEntry, columnEntry] != playerEntry)
        // {
        //     throw new Xunit.Sdk.XunitException();
        // }
        tikTakToeGame.makeMove(lineEntry, columnEntry, playerEntry);
        tikTakToeGame.board.Should().BeEquivalentTo(entry);
    }

    [Theory(DisplayName = "Deve imprimir o tabuleiro")]
    [InlineData(
        new char[] {
            'x', 'x', 'x',
            'x', 'x', 'x',
            'x', 'x', 'x'
        },
        new string[] {
            "x x x",
            "x x x",
            "x x x"
        }
    )]
    public void TestPrintBoard(char[] entry, string[] expected)
    {
        TikTakToeGame tikTakToeGame = new();
        tikTakToeGame.board = fromArrayToMultiDimArray(entry, 3, 3);

        using (var NewOutput = new StringWriter())
        {
            Console.SetOut(NewOutput);

            tikTakToeGame.printBoard();
            string result = NewOutput.ToString().Trim();

            result.Should().Be(string.Join("\n", expected));
        }
    }

    [Theory(DisplayName = "Deve retornar corretamente se o jogo acabou ou não")]
    [InlineData(
        new char[] {
            'x', 'x', 'x',
            'x', 'x', 'x',
            'x', 'x', 'x'
        },
        'x',
        true
    )]
    [InlineData(
        new char[] {
            'y', 'x', 'x',
            'y', 'y', 'x',
            'y', 'x', 'y'
        },
        'y',
        true
    )]
    [InlineData(
        new char[] {
            'y', 'x', 'x',
            'x', 'y', 'x',
            'y', 'x', 'y'
        },
        'y',
        true
    )]
    [InlineData(
        new char[] {
            'y', 'x', 'x',
            'y', 'x', 'x',
            'x', 'y', 'y'
        },
        'x',
        true
    )]
    [InlineData(
        new char[] {
            'y', 'x', 'y',
            'y', 'x', 'x',
            'x', 'y', 'y'
        },
        ' ',
        false
    )]
    public void TestIsGameOver(char[] entry, char expectedWinner, bool expectedReturn)
    {
        TikTakToeGame tikTakToeGame = new();
        tikTakToeGame.board = fromArrayToMultiDimArray(entry, 3, 3);
        bool methodReturno = tikTakToeGame.isGameOver();
        tikTakToeGame.winner.Should().Be(expectedWinner);
        methodReturno.Should().Be(expectedReturn);
    }

    [Theory(DisplayName = "Deve imprimir o vencedor correto do jogo")]
    [InlineData(' ', "Empate! Deu velha!")]
    [InlineData('x', "O jogador x venceu!")]
    [InlineData('y', "O jogador y venceu!")]
    public void TestPrintResults(char entry, string expected)
    {
        TikTakToeGame tikTakToeGame = new();
        tikTakToeGame.winner = entry;
        using (var NewOutput = new StringWriter())
        {
            Console.SetOut(NewOutput);

            tikTakToeGame.printResults();
            string result = NewOutput.ToString();

            result.Should().Be(string.Join("\n", expected));
        }
    }

    public static char[,] fromArrayToMultiDimArray(char[] array, int lines, int columns)
    {
        char[,] result = new char[lines, columns];
        for (int i = 0; i < array.Length; i++)
        {
            result[i / columns, i % columns] = array[i];
        }
        return result;
    }
}
