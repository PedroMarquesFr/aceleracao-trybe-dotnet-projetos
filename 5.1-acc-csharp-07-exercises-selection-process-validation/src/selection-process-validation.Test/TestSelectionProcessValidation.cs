using FluentAssertions;
using Xunit;

namespace SelectionProcessValidation.Test;

public class TestSelectionProcessValidation
{
    [Theory(DisplayName = "Teste de sucesso para validação de processo de seleção")]
    [InlineData("Maria;João;Fernanda;Felipe;Maurício;Mayara", "Maria", true)]
    [InlineData("Maria;João;Fernanda;Felipe;Maurício;Mayara", "Aaaa", false)]
    public void TestSelectionProcessValidationSuccess(string selectedPeople, string name, bool resultExpected)
    {
        SelectionProcessValidation.ValidateName(selectedPeople, name).Should().Be(resultExpected);
    }

    [Theory(DisplayName = "Teste de exceção para validação de processo de seleção onde nome não pode ser vazio")]
    [InlineData("Maria;João;Fernanda;Felipe;Maurício;Mayara", null)]
    public void TestSelectionProcessValidationException(string selectedPeople, string name)
    {
        Action act = () => SelectionProcessValidation.ValidateName(selectedPeople, name);
        act.Should().Throw<ArgumentNullException>();
    }
}
