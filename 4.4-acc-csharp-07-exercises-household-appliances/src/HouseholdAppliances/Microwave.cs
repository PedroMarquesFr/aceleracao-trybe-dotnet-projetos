namespace HouseholdAppliances;

public class Microwave : Appliance, ICooker
{
    public int BoilingTime { get; set; }
    public int MaximumTemperature { get; set; }
    public Microwave(string brand, string model, int boilingTime, int maximumTemperature, bool isOn = false) : base(brand, model, isOn)
    {
        BoilingTime = boilingTime;
        MaximumTemperature = maximumTemperature;
    }

    public void Cook(string food)
    {
        if (!IsOn) { Console.WriteLine("Microwave must be on"); throw new ArgumentException("Microwave must be on"); }
        Console.WriteLine($"Cooking!{food}");
    }
    public void Heat(string food)
    {
        if (!IsOn) { Console.WriteLine("Microwave must be on"); throw new ArgumentException("Microwave must be on"); }
        Console.WriteLine($"Heating!{food}");
    }
}
