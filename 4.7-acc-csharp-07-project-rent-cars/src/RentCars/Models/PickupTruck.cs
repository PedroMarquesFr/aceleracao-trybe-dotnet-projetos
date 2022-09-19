using RentCars.Types;

namespace RentCars.Models
{
    public class PickupTruck : Vehicle
    {
        public int Seats { get; set; }
        public int Doors { get; set; }
        public double LoadCapacity;
        public TractionType Traction;
        public BrakeType FrontBrake { get; set; }
        public BrakeType RearBrake { get; set; }
    }
}
