using FluentAssertions;
using Xunit;

namespace DevicesFactory.Test
{
    public class ButtonTestTest
    {
        [Trait("Category", "9 - Teste TestButtonCanInstantiateWithDifferentDevices foi criado")]
        [Theory(DisplayName = "TestButtonCanInstantiateWithDifferentDevices deve ser executado com sucesso")]
        [InlineData(1, true)]
        [InlineData(2, false)]
        [InlineData(13, true)]
        [InlineData(20, false)]
        public void TestTestButtonCanInstantiateWithDifferentDevices(int timesTriggered, bool expectedValue)
        {
            ButtonTest instance = new();
            Action act = () => instance.TestButtonCanInstantiateWithDifferentDevices(timesTriggered, expectedValue);
            act.Should().NotThrow<Xunit.Sdk.XunitException>();
            act.Should().NotThrow<NotImplementedException>();
        }
    }
}
