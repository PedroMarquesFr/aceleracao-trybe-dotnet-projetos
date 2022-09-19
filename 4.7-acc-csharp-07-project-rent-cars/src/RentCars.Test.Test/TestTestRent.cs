using Xunit;
using FluentAssertions;
using RentCars.Models;
using RentCars.Types;
using RentCars.Test;


namespace RentCars.Test.Test;

public class TestTestRent
{
    public static TheoryData<Vehicle, Person, int, double, bool> RentTestData = new()
    {
        {
            new Car(){
                Brand = "Ford",
                Model = "Mustang",
                Year = 2019,
                MainColor = new Color() { Name = "Preto", Hex = "#000000" },
                Seats = 5,
                Doors = 5,
                Traction = TractionType.RearWheelDrive,
                FrontBrake = BrakeType.Chamber,
                RearBrake = BrakeType.Chamber,
                PricePerDay = 70.0
            }, 
            new PhysicalPerson(){
                Name = "joãozinho",
                Email = "joao@gmail.com",
                Address = "Rua antonio olinda, 204",
                Contact = "88 999554454",
                CPF = "011.787.456-65"
            },
            10,
            700.0,
            true
        },
        {
            new Car(){
                Brand = "Ford",
                Model = "Mustang",
                Year = 2019,
                MainColor = new Color() { Name = "Preto", Hex = "#000000" },
                Seats = 5,
                Doors = 5,
                Traction = TractionType.RearWheelDrive,
                FrontBrake = BrakeType.Chamber,
                RearBrake = BrakeType.Chamber,
                PricePerDay = 70.0
            }, 
            new LegalPerson(){
                Name = "joãozinho s.a.",
                SocialReason = "Empresa do Jão",
                Email = "joao@joao.com",
                Address = "Rua antonio olinda, 204",
                Contact = "88 999554454",
                CNPJ = "XX. XXX. XXX/0001-XX"
            },
            10,
            700.0,
            false
        }
    };

    [Trait("Category", "7 - Criou testes para um novo aluguel")]
    [Theory(DisplayName = "O construtor de Rent deve criar um novo aluguel seguindo as regras corretamente")]
    [MemberData(nameof(RentTestData))]
    public void TestCreateRent(Vehicle vehicle, Person person, int daysRented, double expectedPrice, bool isCorrect)
    {
        TestRent instance = new();
        Action act = () => instance.TestCreateRent(vehicle, person, daysRented, expectedPrice);
        if (isCorrect)
        {
            act.Should().NotThrow<Xunit.Sdk.XunitException>();
        }
        else
        {
            act.Should().Throw<Xunit.Sdk.XunitException>();
        }
        
        act.Should().NotThrow<NotImplementedException>();
    }
}