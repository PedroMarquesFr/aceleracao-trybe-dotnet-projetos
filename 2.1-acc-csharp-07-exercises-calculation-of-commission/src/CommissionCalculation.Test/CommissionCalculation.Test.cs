using Xunit;
using FluentAssertions;
using System.IO;
using CommissionCalculation;

namespace CommissionCalculation.Test;

public class CommissionCalculatorTest
{
    [Theory(DisplayName = "Deve calcular corretamente o salário e armazenar o resultado no atributo FinalSalary.")]
    [InlineData(1200, 2, 60000, 3500)]
    public void TestCalculateFinalSalary(decimal fixedSalary, int amountCarsSold, decimal totalSalesValue, decimal expectedFinalSalary)
    {
        CommissionCalculator commissionCalculator = new();
        commissionCalculator.CalculateFinalSalary(fixedSalary, amountCarsSold, totalSalesValue);
        decimal result = commissionCalculator.FinalSalary;
        result.Should().Be(expectedFinalSalary);
    }

    [Theory(DisplayName = "Deve exibir corretamente a mensagem de salário final.")]
    [InlineData("Nome Contribuidor", "janeiro", new string[] {
        "O colaborador Nome Contribuidor neste mês de janeiro obteve o salário final de R$0.00 referente à:",
        "SALARIO FIXO: R$0.00",
        "TOTAL DE CARROS VENDIDOS: 0",
        "VALOR TOTAL DE VENDAS NO MES: R$0.00",
        "COMISSÃO POR CARROS VENDIDOS: R$0.00",
        "COMISSÃO DE 3% DO TOTAL DE VENDAS: R$0.00"
    })]
    public void TestShowFinalSalary(string contributorName, string month, string[] expectedMessage)
    {
        using (var NewOutput = new StringWriter())
        {
            Console.SetOut(NewOutput);

            var commissionCalculator = new CommissionCalculator();
            commissionCalculator.ShowFinalSalary(contributorName, month);

            string result = NewOutput.ToString().Trim();
            Console.WriteLine(":)");

            result.Should().Be(string.Join("", expectedMessage));
        }
    }
}
