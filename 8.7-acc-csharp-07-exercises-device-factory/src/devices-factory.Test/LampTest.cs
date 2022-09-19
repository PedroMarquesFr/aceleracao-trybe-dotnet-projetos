using Xunit;
using DevicesFactory.Tools;
using FluentAssertions;

namespace DevicesFactory.Test
{
    public class LampTest
    {
        [Fact]
        public void TestLampIsInstanceOfIDevice()
        {
            //Escreva um teste que verifique se,
            //classe 'Lamp' foi injetada via interface,
            //checando se ele � do tipo 'IDevice'
            var classType = typeof(Lamp).GetInterface(nameof(IDevice)) != null;
            classType.Should().Be(true);
        }

        [Fact]
        public void TestLampTurnOnWhenLampIsOff()
        {
            //Escreva um teste que verifique se,
            //ao chamar o m�todo 'TurnOn()' da classe 'Lamp' quando a propriedade 'IsOn' � 'false',
            //o valor da propriedade 'IsOn' ser� true
            Lamp lamp = new();
            lamp.TurnOn();
            lamp.IsTurned().Should().Be(true);
        }

        [Fact]
        public void TestLampTurnOnWhenLampIsOn()
        {
            //Escreva um teste que verifique se,
            //ao chamar o m�todo 'TurnOn()' da classe 'Lamp' quando a propriedade 'IsOn' � 'true',
            //ser� disparado uma exce��o com a mensagem 'Lamp is already on'
            Lamp lamp = new();
            lamp.TurnOn();
            Action act = () => lamp.TurnOn();
            act.Should().Throw<Exception>().WithMessage("Lamp is already on");
        }

        [Fact]
        public void TestLampTurnOffWhenLampIsOn()
        {
            //Escreva um teste que verifique se,
            //ao chamar o m�todo 'TurnOff()' da classe 'Lamp' quando a propriedade 'IsOn' � 'true',
            //o valor da propriedade 'IsOn' ser� false
            Lamp lamp = new();
            lamp.TurnOn();
            lamp.TurnOff();
            lamp.IsTurned().Should().Be(false);
        }

        [Fact]
        public void TestLampTurnOffWhenLampIsOff()
        {
            //Escreva um teste que verifique se,
            //ao chamar o m�todo 'TurnOff()' da classe 'Lamp' quando a propriedade 'IsOn' � 'false',
            //ser� disparado uma exce��o com a mensagem 'Lamp is already off'
            Lamp lamp = new();
            Action act = () => lamp.TurnOff();
            act.Should().Throw<Exception>().WithMessage("Lamp is already off");
        }

        [Fact]
        public void TestLampTurnOnAndTurnOffSequentially()
        {
            //Escreva um teste que verifique se,
            //ao chamar em sequ�ncia os m�todos 'TurnOn()' e 'TurnOff()' da classe 'Lamp',
            //o valor da propriedade 'IsOn' ser� 'false'
            Lamp lamp = new();
            lamp.TurnOn();
            lamp.TurnOff();
            lamp.IsTurned().Should().Be(false);
        }
    }
}
