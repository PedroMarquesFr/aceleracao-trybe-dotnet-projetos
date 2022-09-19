using Xunit;
using FluentAssertions;

namespace stock_options.Test.Test;

public class TestTestsStockOptions
{
  [Trait("Category", "1 - Criou testes para o HasStock")]
  [Theory(DisplayName = "HasStock deve ser executado com sucesso")]
  [InlineData("GOOG", "GOOG")]
  [InlineData("AAPL", "AAPL")]
  [InlineData("MSFT", "MSFT")]
  [InlineData("AMZN", "AMZN")]
  public void TestHasStock(string symbol, string findStock)
  {
    var testClass = new TestStock();
    Action act = () => testClass.HasStock(symbol, findStock);
    act.Should().NotThrow<Xunit.Sdk.XunitException>();
    act.Should().NotThrow<NotImplementedException>();
  }

  [Trait("Category", "1 - Criou testes para o HasStock")]
  [Theory(DisplayName = "HasStock deve ser executado com sucesso com input de falha")]
  [InlineData("GOOG", "FB")]
  [InlineData("AAPL", "MSFT")]
  [InlineData("MSFT", "AMZN")]
  [InlineData("AMZN", "AAPL")]
  public void TestHasStockExeption(string symbol, string findStock)
  {
    var testClass = new TestStock();
    Action act = () => testClass.HasStock(symbol, findStock);
    act.Should().Throw<Xunit.Sdk.XunitException>();
    act.Should().NotThrow<NotImplementedException>();
  }

}
public class TestTestsStockOptions2
{
  [Trait("Category", "2 - Criou testes para o HasStockRecomend")]
  [Theory(DisplayName = "HasStockRecomend deve ser executado com sucesso")]
  [InlineData("Common", "Common", 1030.00, 1000.00, 1500.00)]
  [InlineData("Preferred", "Preferred", 1030.00, 1000.00, 1500.00)]
  [InlineData("Common", "Common", 50.00, 10.00, 100.00)]
  [InlineData("Preferred", "Preferred", 25.00, 15.00, 80.00)]
  public void TestHasStockRecomend(string mockType, string findType, double price, double minValue, double maxValue)
  {
    var testClass = new TestStock();
    Action act = () => testClass.HasStockRecomend(mockType, findType, price, minValue, maxValue);
    act.Should().NotThrow<Xunit.Sdk.XunitException>();
    act.Should().NotThrow<NotImplementedException>();
  }

  [Trait("Category", "2 - Criou testes para o HasStockRecomend")]
  [Theory(DisplayName = "HasStockRecomend deve ser executado com sucesso com input de falha")]
  [InlineData("Common", "Common", 3000.00, 100.00, 1500.00)]
  [InlineData("Preferred", "Common", 4000.00, 10.00, 15.00)]
  [InlineData("Preferred", "Preferred", 50.00, 10.00, 15.00)]
  [InlineData("Common", "Preferred", 50.00, 39.00, 80.00)]
  public void TestHasStockRecomendException(string mockType, string findType, double price, double minValue, double maxValue)
  {
    var testClass = new TestStock();
    Action act = () => testClass.HasStockRecomend(mockType, findType, price, minValue, maxValue);
    act.Should().Throw<Xunit.Sdk.XunitException>();
    act.Should().NotThrow<NotImplementedException>();
  }
}
