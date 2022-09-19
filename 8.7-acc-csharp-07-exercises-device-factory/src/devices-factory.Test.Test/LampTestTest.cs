using FluentAssertions;
using Xunit;

namespace DevicesFactory.Test.Test
{
    public class LampTestTest
    {
        [Trait("Category", "1 - Teste TestLampIsInstanceOfIDevice foi criado")]
        [Fact(DisplayName = "TestLampIsInstanceOfIDevice deve ser executado com sucesso")]
        public void TestSuccesTestLampIsInstanceOfIDevice()
        {
            LampTest instance = new();
            Action act = () => instance.TestLampIsInstanceOfIDevice();
            act.Should().NotThrow<Xunit.Sdk.XunitException>();
            act.Should().NotThrow<NotImplementedException>();
        }
    }
    public class LampTestTest2
    {
        [Trait("Category", "2 - Teste TestLampTurnOnWhenLampIsOff foi criado")]
        [Fact(DisplayName = "TestLampTurnOnWhenLampIsOff deve ser executado com sucesso")]
        public void TestSuccessTestLampTurnOnWhenLampIsOff()
        {
            LampTest instance = new();
            Action act = () => instance.TestLampTurnOnWhenLampIsOff();
            act.Should().NotThrow<Xunit.Sdk.XunitException>();
            act.Should().NotThrow<NotImplementedException>();
        }

        [Trait("Category", "2 - Teste TestLampTurnOnWhenLampIsOff foi criado")]
        [Fact(DisplayName = "TestLampTurnOnWhenLampIsOn deve ser executado com sucesso")]
        public void TestTestLampTurnOnWhenLampIsOn()
        {
            LampTest instance = new();
            Action act = () => instance.TestLampTurnOnWhenLampIsOn();
            act.Should().NotThrow<Xunit.Sdk.XunitException>();
            act.Should().NotThrow<NotImplementedException>();
        }
    }
    public class LampTestTest3
    {
        [Trait("Category", "3 - Teste TestLampTurnOffWhenLampIsOn foi criado")]
        [Fact(DisplayName = "TestLampTurnOffWhenLampIsOn deve ser executado com sucesso")]
        public void TestTestLampTurnOffWhenLampIsOn()
        {
            LampTest instance = new();
            Action act = () => instance.TestLampTurnOffWhenLampIsOn();
            act.Should().NotThrow<Xunit.Sdk.XunitException>();
            act.Should().NotThrow<NotImplementedException>();
        }

        [Trait("Category", "3 - Teste TestLampTurnOffWhenLampIsOn foi criado")]
        [Fact(DisplayName = "TestLampTurnOffWhenLampIsOff deve ser executado com sucesso")]
        public void TestTestLampTurnOffWhenLampIsOff()
        {
            LampTest instance = new();
            Action act = () => instance.TestLampTurnOffWhenLampIsOff();
            act.Should().NotThrow<Xunit.Sdk.XunitException>();
            act.Should().NotThrow<NotImplementedException>();
        }
    }
    public class LampTestTest4
    {
        [Trait("Category", "4 - Teste TestLampTurnOnAndTurnOffSequentially foi criado")]
        [Fact(DisplayName = "TestLampTurnOnAndTurnOffSequentially deve ser executado com sucesso")]
        public void TestTestLampTurnOnAndTurnOffSequentially()
        {
            LampTest instance = new();
            Action act = () => instance.TestLampTurnOnAndTurnOffSequentially();
            act.Should().NotThrow<Xunit.Sdk.XunitException>();
            act.Should().NotThrow<NotImplementedException>();
        }
    }
}
