using Moq;
using FluentAssertions;

namespace stock_options.Test;
public class TestStock
{
    [Theory]
    [InlineData("GOOG", "GOOG")]
    public void HasStock(string symbol, string findStock)
    {
        //given
        var mockStockService = new Mock<IStockService>();
        var mockStock = new Mock<IStock>();
        mockStock.Setup(lib => lib.symbol).Returns(symbol);

        IStock[] stocks = { mockStock.Object };

        mockStockService.Setup(library => library.stocks()).Returns(stocks);

        IStockService stockServiceInstance = mockStockService.Object;


        //when
        StockOptions stockOptions = new(stockServiceInstance);
        var stockResult = stockOptions.getStock(symbol);

        //then
        stockResult.Should().NotBeNull();
        if (stockResult is not null) stockResult.symbol.Should().Be(findStock);
    }

    [Theory]
    [InlineData("Common", "Common", 1030.00, 1000.00, 1500.00)]
    public void HasStockRecomend(string mockType, string findType, double price, double minValue, double maxValue)
    {
        //given
        var mockStockService = new Mock<IStockService>();
        var mockStock = new Mock<IStock>();

        mockStock.Setup(lib => lib.type).Returns(mockType);
        mockStock.Setup(lib => lib.lastPrice).Returns(price);
        IStock[] stocks = { mockStock.Object };
        mockStockService.Setup(library => library.stocks()).Returns(stocks);

        //when
        IStockService stockServiceInstance = mockStockService.Object;
        StockOptions stockOptions = new(stockServiceInstance);
        var stockResult = stockOptions.recomendStock(mockType, minValue, maxValue);

        //then
        stockResult.Should().NotBeNull();
        if (stockResult is not null) stockResult[0].type.Should().Be(findType);
        if (stockResult is not null) stockResult[0].lastPrice.Should().Be(price);
    }
}
