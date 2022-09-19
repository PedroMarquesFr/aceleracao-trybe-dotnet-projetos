using Xunit;
using FluentAssertions;
using employee_registration;
using System;

namespace employee_registration.Test;

public class UnitTest1
{
    [Trait("Category", "1 - Escolher os modificadores de acesso da classe Employee")]
    [Fact(DisplayName = "Deve escolher os modificadores de acesso corretamente!")]
    public void TestPublicAtrributes()
    {
        Action actAll = () => {
            var employer = new Employee("Joao", 3000);
            employer.Pay();
            employer.Print();
        };
                
        actAll.Should().NotThrow();
    }

}