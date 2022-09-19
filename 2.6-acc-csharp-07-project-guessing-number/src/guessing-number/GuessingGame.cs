using System;

namespace guessing_number;

public class GuessNumber
{
    private IRandomGenerator random;
    public GuessNumber() : this(new DefaultRandom()) { }
    public GuessNumber(IRandomGenerator obj)
    {
        this.random = obj;
    }

    //user variables
    public string? response;
    public int userValue;
    public int randomValue;


    public void Greet()
    {
        Console.Write("---Bem-vindo ao Guessing Game---");
        Console.Write("Para começar, tente adivinhar o número que eu pensei, entre -100 e 100!");

    }

    public void ChooseNumber()
    {
        bool isValid = false;
        while (!isValid || !(userValue < 100 && userValue > -100))
        {
            response = Console.ReadLine();
            isValid = Int32.TryParse(response, out userValue);
            if(!isValid){
                Console.Write("Por favor, digite um número inteiro:");
            }
        }
    }

    public void RandomNumber()
    {
        randomValue = random.GetInt(-100, 100);
    }

    public void AnalyzePlay()
    {
        if (randomValue > userValue)
        {
            Console.WriteLine("Tente um número MAIOR");
        }
        if (randomValue < userValue)
        {
            Console.WriteLine("Tente um número MENOR");
        }
        if (randomValue == userValue)
        {
            Console.WriteLine("ACERTOU!");
        }
    }
}