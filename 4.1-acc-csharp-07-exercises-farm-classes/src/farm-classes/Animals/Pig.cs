namespace Animals;

// Crie a sua classe Pig aqui
public class Pig
{
    public Guid id = Guid.NewGuid();
    public int Age;

    public Pig(int age)
    {
        if (age < 0 )
            throw new ArgumentException("Age cant be negative");
        Age = age;
    }
}