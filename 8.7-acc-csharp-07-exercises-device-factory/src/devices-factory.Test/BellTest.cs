using Xunit;
using DevicesFactory.Tools;
using FluentAssertions;

namespace DevicesFactory.Test
{
    public class BellTest
    {
        [Fact]
        public void TestBellIsInstanceOfIDevice()
        {
            //Escreva um teste que verifique se,
            //classe 'Bell' foi injetada via interface,
            //checando se ele � do tipo 'IDevice'
            var classType = typeof(Bell).GetInterface(nameof(IDevice)) != null;
            classType.Should().Be(true);
        }

        [Fact]
        public void TestBellTurnOnWhenBellIsOff()
        {
            //Escreva um teste que verifique se,
            //ao chamar o m�todo 'TurnOn()' da classe 'Bell' quando a propriedade 'IsOn' � false,
            //o valor da propriedade 'IsOn' ser� true
            Bell bell = new();
            bell.TurnOn();
            bell.IsTurned().Should().Be(true);

        }

        [Fact]
        public void TestBellTurnOnWhenBellIsOn()
        {
            //Escreva um teste que verifique se,
            //ao chamar o m�todo 'TurnOn()' da classe 'Bell' quando a propriedade 'IsOn' � 'true',
            //ser� disparado uma exce��o com a mensagem 'Bell is already on'
            Bell bell = new();
            bell.TurnOn();
            Action act = () => bell.TurnOn();
            act.Should().Throw<Exception>().WithMessage("Bell is already on");
        }

        [Fact]
        public void TestBellTurnOffWhenBellIsOn()
        {
            //Escreva um teste que verifique se,
            //ao chamar o m�todo 'TurnOff()' da classe 'Bell' quando a propriedade 'IsOn' � true,
            //o valor da propriedade 'IsOn' ser� false
            Bell bell = new();
            bell.TurnOn();
            bell.TurnOff();
            bell.IsTurned().Should().Be(false);
        }

        [Fact]
        public void TestBellTurnOffWhenBellIsOff()
        {
            //Escreva um teste que verifique se,
            //ao chamar o m�todo 'TurnOff()' da classe 'Bell' quando a propriedade 'IsOn' � 'false',
            //ser� disparado uma exce��o com a mensagem 'Bell is already off'
            Bell bell = new();
            Action act = () => bell.TurnOff();
            act.Should().Throw<Exception>().WithMessage("Bell is already off");

        }

        [Fact]
        public void TestBellTurnOnAndTurnOffSequentially()
        {
            //Escreva um teste que verifique se,
            //ao chamar em sequ�ncia os m�todos 'TurnOn()' e 'TurnOff()' da classe 'Bell',
            //o valor da propriedade 'IsOn' ser� false
            Bell bell = new();
            bell.TurnOn();
            bell.TurnOff();
            bell.IsTurned().Should().Be(false);
        }
    }
}
