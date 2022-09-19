using System.Diagnostics;

namespace CharacterCounter;
public class CharacterCounter
{
    /// <summary>
    /// This function aims to perform the character count of a given text
    /// </summary>
    /// <param name="text"> A value of type string, the text to be calculated</param>
    /// <returns>The number of characters of the text passed</returns>
    /// <exception cref="NullReferenceException">If text is null throw exception </exception>
    static public int Action(string text)
    {
        try
        {
            if (text == null)
            {
                throw new NullReferenceException("Valor de texto inválido");
            }
            return text.Length;
        }
        catch (NullReferenceException ex)
        {

            Console.Write(ex.Message);
            throw;
        }

    }

}
