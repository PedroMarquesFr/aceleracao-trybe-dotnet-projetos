using FluentAssertions;
using Xunit;

namespace DevicesFactory.Test
{
    public class SwitcherTestTest
    {
        [Trait("Category", "10 - Test TestSwitcherCanRecieveDifferentDevices foi criado")]
        [Theory(DisplayName = "TestSwitcherCanRecieveDifferentDevices deve ser executado com sucesso")]
        [InlineData(1, true)]
        [InlineData(2, false)]
        [InlineData(13, true)]
        [InlineData(20, false)]
        public void TestSwitcherCanRecieveDifferentDevices(int timesTriggered, bool expectedValue)
        {
            SwitcherTest instance = new();
            Action act = () => instance.TestSwitcherCanRecieveDifferentDevices(timesTriggered, expectedValue);
            act.Should().NotThrow<Xunit.Sdk.XunitException>();
            act.Should().NotThrow<NotImplementedException>();
        }
    }
}
