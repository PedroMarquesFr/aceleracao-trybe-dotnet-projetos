namespace TikTakToe;

public class TikTakToeGame
{
    public char[,] board = new char[3, 3] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
    public char currentPlayer = 'x';
    public char winner = ' ';

    private readonly int BOARD_LENGTH = 3;

    public void printBoard()
    {
        string[] response = new string[3];
        for (int lines = 0; lines < BOARD_LENGTH; lines++)
        {
            for (int column = 0; column < BOARD_LENGTH; column++)
            {
                if (response[lines] == null)
                {
                    response[lines] = $"{board[lines, column]}";
                    continue;
                }
                response[lines] = $"{response[lines]} {board[lines, column]}";
            }
        }
        Console.WriteLine(string.Join("\n", response));
    }

    public void makeMove(int line, int column, char player)
    {
        if (board[line, column] == ' ')
        {
            board[line, column] = player;
        }
    }

    public bool isGameOver()
    {
        char[] checker = new char[3] { ' ', ' ', ' ' };
        for (int lines = 0; lines < BOARD_LENGTH; lines++)
        {
            for (int column = 0; column < BOARD_LENGTH; column++)
            {
                checker[column] = board[lines, column];
            }
            if (checker.Distinct().Count() == 1 && checker[0] != ' ')
            {
                winner = checker[0];
                return true;
            }
            checker = new char[3] { ' ', ' ', ' ' };
        }
        for (int column = 0; column < BOARD_LENGTH; column++)
        {
            for (int lines = 0; lines < BOARD_LENGTH; lines++)
            {
                checker[lines] = board[lines, column];
            }
            if (checker.Distinct().Count() == 1 && checker[0] != ' ')
            {
                winner = checker[0];
                return true;
            }
            checker = new char[3] { ' ', ' ', ' ' };
        }
        for (int diagonal = 0; diagonal < BOARD_LENGTH; diagonal++)
        {
            checker[diagonal] = board[diagonal, diagonal];
            if (checker.Distinct().Count() == 1 && checker[0] != ' ')
            {
                winner = checker[0];
                return true;
            }
        }
        checker = new char[3] { ' ', ' ', ' ' };
        for (int diagonal = 0; diagonal < BOARD_LENGTH; diagonal++)
        {
            checker[diagonal] = board[diagonal, BOARD_LENGTH - (diagonal + 1)];
            if (checker.Distinct().Count() == 1 && checker[0] != ' ')
            {
                winner = checker[0];
                return true;
            }
        }
        winner = ' ';
        return false;
    }

    public void printResults()
    {
        if (winner == ' ')
        {
            Console.Write("Empate! Deu velha!");
        }
        else
        {
            Console.Write($"O jogador {winner} venceu!");
        }
    }

    public char getCurrentPlayer()
    {
        return currentPlayer;
    }

    public int[] getPlayerEntry()
    {
        Console.WriteLine("Jogador " + currentPlayer + " informe a linha:");
        string input = Console.ReadLine() ?? "";
        int line = int.Parse(input);

        Console.WriteLine("Jogador " + currentPlayer + " informe a coluna:");
        input = Console.ReadLine() ?? "";
        int column = int.Parse(input);

        return new int[] { line, column };
    }

    public void changePlayer()
    {
        if (currentPlayer == 'x')
        {
            currentPlayer = 'o';
        }
        else
        {
            currentPlayer = 'x';
        }
    }
}
