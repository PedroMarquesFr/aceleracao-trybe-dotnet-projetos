using System;

namespace CommissionCalculation;
public class CommissionCalculator
{
    public const decimal CommissionPerCarSold = 250;
    public decimal FixedSalary { get; set; }
    public int AmountCarsSold { get; set; }
    public decimal TotalSalesValue { get; set; }
    public decimal FinalSalary { get; set; }
    public decimal FixedComission { get; set; }
    public decimal TotalSalesComission { get; set; }

    public void CalculateFinalSalary(decimal fixedSalary, int amountCarsSold, decimal totalSalesValue)
    {
        FixedSalary = fixedSalary;
        AmountCarsSold = amountCarsSold;
        TotalSalesValue = totalSalesValue;
        int commision = 250;
        decimal fixedComission = amountCarsSold * commision;
        decimal totalSalesComission = totalSalesValue * 0.03M;
        FixedComission = fixedComission;
        TotalSalesComission = totalSalesComission;
        FinalSalary = fixedSalary + fixedComission + totalSalesComission;
    }

    public void ShowFinalSalary(string contributorName, string month)
    {
        var culture = new System.Globalization.CultureInfo("en-US");
        var resultStr = new string[] {
        $"O colaborador {contributorName} neste mês de {month} obteve o salário final de R${FinalSalary.ToString("N2", culture)} referente à:",
        $"SALARIO FIXO: R${FixedSalary.ToString("N2", culture)}",
        $"TOTAL DE CARROS VENDIDOS: {AmountCarsSold}",
        $"VALOR TOTAL DE VENDAS NO MES: R${TotalSalesValue.ToString("N2", culture)}",
        $"COMISSÃO POR CARROS VENDIDOS: R${FixedComission.ToString("N2", culture)}",
        $"COMISSÃO DE 3% DO TOTAL DE VENDAS: R${TotalSalesComission.ToString("N2", culture)}"
    };
        Console.WriteLine(string.Join("", resultStr));
    }
}
