using Xunit;
using DevicesFactory.Trigger;
using DevicesFactory.Tools;
using FluentAssertions;

namespace DevicesFactory.Test
{
    public class ButtonTest
    {
        [Theory]
        [InlineData(1, true)]
        [InlineData(2, false)]
        [InlineData(13, true)]
        [InlineData(20, false)]
        public void TestButtonCanInstantiateWithDifferentDevices(int timesTriggered, bool expectedValue)
        {
            //timestriggered = número de vezes que o método 'Trigger' de 'Button' é acionado
            //expectedValue = o valor final da propriedade 'IsOn' dos dispositivos acionados
            Lamp lamp = new();
            Bell bell = new();
            Button lampButton = new(lamp);
            Button bellButton = new(bell);
            for (int index = 0; index < timesTriggered; index++)
            {
                lampButton.Trigger();
                bellButton.Trigger();
            }
            lamp.IsTurned().Should().Be(expectedValue);
        }
    }
}
