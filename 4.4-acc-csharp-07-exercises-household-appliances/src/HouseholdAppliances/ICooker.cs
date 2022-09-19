namespace HouseholdAppliances;

public interface ICooker
{
    int BoilingTime { get; set; }
    int MaximumTemperature { get; set; }
    void Cook(string food);
}

