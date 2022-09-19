namespace delivery_server;
public class Item
{
    public string? Name { get; set; }
    public double Price { get; set; }
    public int TimeToPrepare { get; set; }

    public Item(string name, double price, int timeToPrepare)
    {
        Validate(name, price, timeToPrepare);

        Name = name;
        Price = price;
        TimeToPrepare = timeToPrepare;
    }

    private static void Validate(string name, double price, int timeToPrepare)
    {
        if (name == "" || price < 0 || timeToPrepare < 0) throw new ArgumentException("invalid arguments");
    }
}
