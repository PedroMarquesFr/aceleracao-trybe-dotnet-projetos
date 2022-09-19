using Xunit;
using FluentAssertions;
using month_name.Test;
using System;

namespace month_name.Test.Test;

public class TestTestMonthNameInCalendar1
{
    [Trait("Category", "1 - Criou testes para o TestMonthNameInCalendarSucess")]
    [Theory(DisplayName = "TestMonthNameInCalendarSucess deve ser executado com sucesso")] 
    [InlineData(1,"Janeiro")]
    [InlineData(2,"Fevereiro")]
    [InlineData(3,"Março")]
    [InlineData(4,"Abril")]
    [InlineData(5,"Maio")]
    [InlineData(6,"Junho")]
    [InlineData(7,"Julho")]
    [InlineData(8,"Agosto")]
    [InlineData(9,"Setembro")]
    [InlineData(10,"Outubro")]
    [InlineData(11,"Novembro")]
    [InlineData(12,"Dezembro")]
    [InlineData(0,"inválido")]
    [InlineData(13,"inválido")]
    public void TestSucessTestMonthNameInCalendarSucess(int month, string expected)
    {   
        TestMonthNameInCalendar instance = new();
        Action act = () => instance.TestMonthNameInCalendarSucess(month, expected);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

public class TestTestMonthNameInCalendar2 
{
    [Trait("Category", "2 - Criou testes para o TestMonthNameInCalendar")]
    [Theory(DisplayName = "TestMonthNameInCalendar deve falhar com input de falha")] 
    [InlineData(1,"")]
    [InlineData(2,"")]
    [InlineData(3,"")]
    [InlineData(4,"")]
    [InlineData(5,"")]
    [InlineData(6,"")]
    [InlineData(7,"")]
    [InlineData(8,"")]
    [InlineData(9,"")]
    [InlineData(10,"")]
    [InlineData(11,"")]
    [InlineData(12,"")]
    [InlineData(0,"")]
    [InlineData(13,"")]
    public void TestFailTestMonthNameInCalendarSucess(int month, string expected)
    {   
        TestMonthNameInCalendar instance = new();
        Action act = () => instance.TestMonthNameInCalendarSucess(month, expected);
        act.Should().Throw<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}
