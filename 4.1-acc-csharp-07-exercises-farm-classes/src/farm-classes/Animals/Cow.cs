namespace Animals;

// Crie a sua classe Cow aqui
public class Cow
{
    public Guid id = Guid.NewGuid();
    public int Weight;
    public string Breed;

    public Cow(int weight, string breed)
    {
        if (weight <= 0 || breed == "" || breed == null)
            throw new ArgumentException("Invalid Breed or Weight");
        Weight = weight;
        Breed = breed;
    }
}
