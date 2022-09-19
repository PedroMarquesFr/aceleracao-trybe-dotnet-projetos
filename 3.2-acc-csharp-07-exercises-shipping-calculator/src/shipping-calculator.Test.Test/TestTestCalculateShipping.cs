using System;
using Xunit;
using FluentAssertions;
using ShippingCalculator.Test;

namespace ShippingCalculator.Test.Test
{

    public class TestTestCalculateShipping
    {
        [Trait("Category", "1 - Criou testes para o TestCalculateShippingSuccess")]
        [Theory(DisplayName = "TestCalculateShipping deve ser executado com sucesso")] 
        [InlineData(43, 25)]
        [InlineData(100, 20)]
        [InlineData(101, 15)]
        [InlineData(201, 0)]     
        public void TestSuccessTestCalculateShippingSuccess(double orderPrice, int resultExpected)
        {   
            var testClass = new TestShippingCalculator();
            Action act = () => testClass.TestCalculateShippingSuccess(orderPrice, resultExpected);
            act.Should().NotThrow<Xunit.Sdk.XunitException>();
            act.Should().NotThrow<NotImplementedException>();
        } 

        [Trait("Category", "1 - Criou testes para o TestCalculateShippingSuccess")]
        [Theory(DisplayName = "TestCalculateShipping deve falhar com input de falha")] 
        [InlineData(43, 20)]
        [InlineData(100, 25)]
        [InlineData(101, 0)]
        [InlineData(201, 15)]     
        public void TestFailTestCalculateShippingSuccess(double orderPrice, int resultUnexpected)
        {          
            var testClass = new TestShippingCalculator();
            Action act = () => testClass.TestCalculateShippingSuccess(orderPrice, resultUnexpected);
            act.Should().Throw<Xunit.Sdk.XunitException>();
            act.Should().NotThrow<NotImplementedException>();
        }
    }

    public class TestTestCalculateShipping2
    {
        [Trait("Category", "2 - Criou testes para o TestCalculateShippingException")]
        [Theory(DisplayName = "TestCalculateShippingException deve ser executado com sucesso com input de falha")] 
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(-13)]
        [InlineData(-5)]
        public void TestSuccessTestCalculateShippingException(double orderPrice)
        {   
            var testClass = new TestShippingCalculator();
            Action act = () => testClass.TestCalculateShippingException(orderPrice);
            act.Should().NotThrow<Xunit.Sdk.XunitException>();
            act.Should().NotThrow<NotImplementedException>();
        }

        [Trait("Category", "2 - Criou testes para o TestCalculateShippingException")]
        [Theory(DisplayName = "TestCalculateShippingException deve falhar com input de sucesso")] 
        [InlineData(2)]
        [InlineData(10)]
        [InlineData(200)]
        [InlineData(59)]
        public void TestFailTestCalculateShippingException(double orderPrice)
        {   
            var testClass = new TestShippingCalculator();
            Action act = () => testClass.TestCalculateShippingException(orderPrice);
            act.Should().Throw<Xunit.Sdk.XunitException>();
            act.Should().NotThrow<NotImplementedException>();
        }
    }

}
