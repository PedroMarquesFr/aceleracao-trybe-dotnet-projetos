using Xunit;
using FluentAssertions;

namespace SelectionProcessValidation.Test.Test;

public class TestTestSelectionProcessValidation
{
        [Trait("Category", "1 - Criou testes para o TestSelectionProcessValidationSuccess")]
        [Theory(DisplayName = "TestSelectionProcessValidationSuccess deve ser executado com sucesso")] 
        [InlineData("Maria;João;Fernanda;Felipe;Maurício;Mayara", "Maria", true)]
        [InlineData("Maria;João;Fernanda;Felipe;Maurício;Mayara", "João", true)]
        [InlineData("Maria;João;Fernanda;Felipe;Maurício;Mayara", "Luiz", false)]
        [InlineData("Maria;João;Fernanda;Felipe;Maurício;Mayara", "Patrícia", false)]
        public void TestSuccessTestSelectionProcessValidationSuccess(string selectedPeople, string name, bool resultExpected)
        {   
            Action act = () => new TestSelectionProcessValidation().TestSelectionProcessValidationSuccess(selectedPeople, name, resultExpected);
            act.Should().NotThrow<Xunit.Sdk.XunitException>();
            act.Should().NotThrow<NotImplementedException>();
        } 

        [Trait("Category", "1 - Criou testes para o TestSelectionProcessValidationSuccess")]
        [Theory(DisplayName = "TestSelectionProcessValidationSuccess deve falhar com input de falha")] 
        [InlineData("Maria;João;Fernanda;Felipe;Maurício;Mayara", "Maria", false)]
        [InlineData("Maria;João;Fernanda;Felipe;Maurício;Mayara", "João", false)]
        [InlineData("Maria;João;Fernanda;Felipe;Maurício;Mayara", "Luiz", true)]
        [InlineData("Maria;João;Fernanda;Felipe;Maurício;Mayara", "Patrícia", true)]
        public void TestFailTestSelectionProcessValidationSuccess(string selectedPeople, string name, bool resultUnexpected)
        {          
            Action act = () => new TestSelectionProcessValidation().TestSelectionProcessValidationSuccess(selectedPeople, name, resultUnexpected);
            act.Should().Throw<Xunit.Sdk.XunitException>();
            act.Should().NotThrow<NotImplementedException>();
        }

}
public class TestTestSelectionProcessValidation2
{
        [Trait("Category", "2 - Criou testes para o TestSelectionProcessValidationException")]
        [Theory(DisplayName = "TestSelectionProcessValidationException deve ser executado com sucesso com input de falha")] 
        // [InlineData("Maria;João;Fernanda;Felipe;Maurício;Mayara", null)]
        [InlineData("Maria;João;Fernanda;Felipe;Maurício;Mayara", "")]
        public void TestSuccessTestSelectionProcessValidationException(string selectedPeople, string name)
        {   
            Action act = () => new TestSelectionProcessValidation().TestSelectionProcessValidationException(selectedPeople, name);
            act.Should().NotThrow<Xunit.Sdk.XunitException>();
            act.Should().NotThrow<NotImplementedException>();
        }

        [Trait("Category", "2 - Criou testes para o TestSelectionProcessValidationException")]
        [Theory(DisplayName = "TestSelectionProcessValidationException deve falhar com input de sucesso")] 
        [InlineData("Maria;João;Fernanda;Felipe;Maurício;Mayara", "Maria")]
        [InlineData("Maria;João;Fernanda;Felipe;Maurício;Mayara", "José")]
        public void TestFailTestCharacterCounterException(string selectedPeople, string name)
        {   
            Action act = () => new TestSelectionProcessValidation().TestSelectionProcessValidationException(selectedPeople, name);
            act.Should().Throw<Xunit.Sdk.XunitException>();
            act.Should().NotThrow<NotImplementedException>();
        }
}
