using FluentAssertions;
using Xunit;

namespace DevicesFactory.Test.Test
{
    public class BellTestTest
    {
        [Trait("Category", "5 - Teste TestBellIsInstanceOfIDevice foi criado")]
        [Fact(DisplayName = "TestBellIsInstanceOfIDevice deve ser executado com sucesso")]
        public void TestSuccesTestBellIsInstanceOfIDevice()
        {
            BellTest instance = new();
            Action act = () => instance.TestBellIsInstanceOfIDevice();

            act.Should().NotThrow<Xunit.Sdk.XunitException>();
            act.Should().NotThrow<NotImplementedException>();            

        }
    }
    public class BellTestTest2
    {
        [Trait("Category", "6 - Teste TestBellTurnOnWhenBellIsOff foi criado")]
        [Fact(DisplayName = "TestBellTurnOnWhenBellIsOff deve ser executado com sucesso")]
        public void TestSuccessTestBellTurnOnWhenBellIsOff()
        {
            BellTest instance = new();
            Action act = () => instance.TestBellTurnOnWhenBellIsOff();
            act.Should().NotThrow<Xunit.Sdk.XunitException>();
            act.Should().NotThrow<NotImplementedException>();
        }

        [Trait("Category", "6 - Teste TestBellTurnOnWhenBellIsOff foi criado")]
        [Fact(DisplayName = "TestBellTurnOnWhenBellIsOn deve ser executado com sucesso")]
        public void TestTestBellTurnOnWhenBellIsOn()
        {
            BellTest instance = new();
            Action act = () => instance.TestBellTurnOnWhenBellIsOn();
            act.Should().NotThrow<Xunit.Sdk.XunitException>();
            act.Should().NotThrow<NotImplementedException>();
        }
    }
    public class BellTestTest3
    {
        [Trait("Category", "7 - Teste TestBellTurnOffWhenBellIsOn foi criado")]
        [Fact(DisplayName = "TestBellTurnOffWhenBellIsOn deve ser executado com sucesso")]
        public void TestTestBellTurnOffWhenBellIsOn()
        {
            BellTest instance = new();
            Action act = () => instance.TestBellTurnOffWhenBellIsOn();
            act.Should().NotThrow<Xunit.Sdk.XunitException>();
            act.Should().NotThrow<NotImplementedException>();
        }

        [Trait("Category", "7 - Teste TestBellTurnOffWhenBellIsOn foi criado")]
        [Fact(DisplayName = "TestBellTurnOffWhenBellIsOff deve ser executado com sucesso")]
        public void TestTestBellTurnOffWhenBellIsOff()
        {
            BellTest instance = new();
            Action act = () => instance.TestBellTurnOffWhenBellIsOff();
            act.Should().NotThrow<Xunit.Sdk.XunitException>();
            act.Should().NotThrow<NotImplementedException>();
        }
    }
    public class BellTestTest4
    {
        [Trait("Category", "8 - Teste TestBellTurnOnAndTurnOffSequentially foi criado")]
        [Fact(DisplayName = "TestBellTurnOnAndTurnOffSequentially deve ser executado com sucesso")]
        public void TestTestBellTurnOnAndTurnOffSequentially()
        {
            BellTest instance = new();
            Action act = () => instance.TestBellTurnOnAndTurnOffSequentially();
            act.Should().NotThrow<Xunit.Sdk.XunitException>();
            act.Should().NotThrow<NotImplementedException>();
        }
    }
}
