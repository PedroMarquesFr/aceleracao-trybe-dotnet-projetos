namespace HouseholdAppliances;

public class ElectricStove : Appliance, ICooker
{
    public int BoilingTime { get; set; }
    public int MaximumTemperature { get; set; }
    public ElectricStove(string brand, string model, int boilingTime, int maximumTemperature, bool isOn=false) : base(brand, model, isOn)
    {
        BoilingTime = boilingTime;
        MaximumTemperature = maximumTemperature;
    }

    public void Cook(string food)
    {
        if (!IsOn) { Console.WriteLine("ElectricStove must be on"); throw new ArgumentException("ElectricStove must be on"); }
        Console.WriteLine($"Cooking!{food}");
    }
    public void Bake(string food)
    {
        if (!IsOn) { Console.WriteLine("ElectricStove must be on"); throw new ArgumentException("ElectricStove must be on"); }
        Console.WriteLine($"Baking!{food}");
    }
}