namespace Animals;

// Crie a sua classe Chicken aqui
public class Chicken
{
    public Guid id = Guid.NewGuid();
    private int _eggsPerWeek;
    public int EggsPerWeek
    {
        get { return _eggsPerWeek; }
        set
        {
            if (value < 0) throw new ArgumentException("EggsPerWeek cant be negative");
            _eggsPerWeek = value;
        }
    }
    public Chicken Mother;

    public Chicken(int eggsPerWeek, Chicken mother)
    {
        EggsPerWeek = eggsPerWeek;
        Mother = mother;
    }

    public Chicken(int eggsPerWeek)
    {
        EggsPerWeek = eggsPerWeek;
    }
}