namespace OddsOrEvens;

public class OddsOrEvens
{
    /// <summary>
    /// This function is to add two numbers
    /// </summary>
    /// <param name="numberOne"> A number to be calculated</param>
    /// <param name="numberTwo"> A number to be calculated</param>
    /// <returns>The sum of the two numbers</returns>
    /// <exception cref="ArgumentOutOfRangeException">If one of the numbers is greater than 10</exception>
    static public int SumNumbers(int numberOne, int numberTwo)
    {
        if (numberOne > 10 || numberTwo > 10)
        {
            throw new ArgumentOutOfRangeException();
        }
        return numberOne + numberTwo;
    }

    /// <summary>
    /// This function is to check if a number is odd or even
    /// </summary>
    /// <param name="resultValue"> The number to be validated</param>
    /// <returns>A string saying whether it's odd or even</returns>
    static public string VerifyOddsOrEvens(int resultValue)
    {
        return resultValue % 2 == 1 ? "Ímpar" : "Par";
    }
}
