using Xunit;
using DevicesFactory.Trigger;
using DevicesFactory.Tools;
using FluentAssertions;

namespace DevicesFactory.Test
{
    public class SwitcherTest
    {
        [Theory]
        [InlineData(1, true)]
        [InlineData(2, false)]
        [InlineData(13, true)]
        [InlineData(20, false)]
        public void TestSwitcherCanRecieveDifferentDevices(int timesTriggered, bool expectedValue)
        {
            //timestriggered = número de vezes que o método 'Trigger' de 'Switcher' é acionado
            //expectedValue = o valor final da propriedade 'IsOn' dos dispositivos acionados
            Lamp lamp = new();
            Bell bell = new();
            Switcher lampSwitcher = new(lamp);
            Switcher bellSwitcher = new(bell);
            for (int index = 0; index < timesTriggered; index++)
            {
                lampSwitcher.Trigger();
                bellSwitcher.Trigger();
            }
            lamp.IsTurned().Should().Be(expectedValue);
        }
    }
}
