using RentCars.Types;

namespace RentCars.Models;

public class Rent
{
    public Vehicle Vehicle { get; set; }
    public Person Person { get; set; }
    public int DaysRented { get; set; }
    public double Price { get; set; }
    public RentStatus Status { get; set; }

    public Rent(Vehicle vehicle, Person person, int daysRented)
    {
        double discount = 0.9;
        if (person is LegalPerson)
        {
            Price = vehicle.PricePerDay * daysRented * discount;
        }
        else
        {
            Price = vehicle.PricePerDay * daysRented;
        }
        Status = RentStatus.Confirmed;
        Person = person;
        DaysRented = daysRented;
        Vehicle = vehicle;
        Vehicle.IsRented = true;
        Person.Debit = Price;

    }

    public void Cancel()
    {
        throw new NotImplementedException();
    }

    public void Finish()
    {
        throw new NotImplementedException();
    }
}
