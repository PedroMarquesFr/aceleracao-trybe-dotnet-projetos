using FluentAssertions;
using Xunit;

namespace CharacterCounter.Test;

public class TestCharacterCounter
{

    [Theory]
    [InlineData("O Rato Roeu a Roupa do Rei de Roma", 34)]
    public void TestCharacterCounterSuccess(string text, int resultExpected)
    {
        int result = CharacterCounter.Action(text);
        result.Should().Be(resultExpected);

    }

    [Theory]
    [InlineData(null)]
    public void TestCharacterCounterException(string text)
    {
        Action act = () => CharacterCounter.Action(text);
        act.Should().Throw<NullReferenceException>().WithMessage("Valor de texto inválido");
    }
}