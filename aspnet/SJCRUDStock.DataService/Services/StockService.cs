using SJCRUDStock.DataService.Interfaces;
using SJObjectModel.Models;

namespace SJCRUDStock.DataService.Services
{
    public class StockService : IStockService
    {
        private Stock[] StockList;
        private Stock Stock;

        public StockService()
        {
            StockList = new Stock[];
            Stock = new Stock() {
                Symbol = "Stock Symbol",
                Name = "Stock Name",
                ExchangeNama = "Exchange Name",
                Currency = "Currency"
            };

            StockList[0] = Stock;
        }

        public async Stock[] GetStockList()
        {
            return await StockList;
        }
    }
}