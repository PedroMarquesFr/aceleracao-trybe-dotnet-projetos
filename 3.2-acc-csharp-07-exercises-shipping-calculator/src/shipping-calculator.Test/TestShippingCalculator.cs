using Xunit;
using FluentAssertions;
using System;

namespace ShippingCalculator.Test
{
    public class TestShippingCalculator
    {
        [Theory]
        [InlineData(43, 25)]
        public void TestCalculateShippingSuccess(double orderPrice, int resultExpected)
        {
            ShippingCalculator shippingCalculator = new();
            int result = shippingCalculator.CalculateShipping(orderPrice);
            result.Should().Be(resultExpected);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void TestCalculateShippingException(double orderPrice)
        {
            ShippingCalculator shippingCalculator = new();

            Action act = () => shippingCalculator.CalculateShipping(orderPrice);

            act.Should().Throw<Exception>().WithMessage("The order price cannot be equal to or less than zero");
        }
    }
}
