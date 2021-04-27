using System;
using System.Collections.Generic;
using System.Threading.Tasks;
// using Microsoft.EntityFrameworkCore;
using System.Linq;
using SJCRUDStock.DataService.Interfaces;
using SJCRUDStock.ObjectModel.Models;

namespace SJCRUDStock.DataService.Repositories
{
    public class StockRepo : IStockRepo
    {
        // private StockContext _ctx;

        private List<Stock> StockList;
        private Stock Stock;
        private Stock Stock1;

        public StockRepo(/*StockContext context*/)
        {
            // _ctx = ctx;

            Stock = new Stock() {
                Symbol = "Stock Symbol",
                Name = "Stock Name",
                ExchangeName = "Exchange Name",
                Currency = "Currency"
            };

            Stock1 = new Stock() {
                Symbol = "Stock Symbol",
                Name = "Stock Name",
                ExchangeName = "Exchange Name",
                Currency = "Currency"
            };

            StockList = new List<Stock>();
            StockList.Add(Stock);
            StockList.Add(Stock1);
        }
        public async Task<List<Stock>> GetStockItems()
        {
            return StockList;

            // var query = _ctx.StockItems.{OrderByDescending}(p => p.Timestamp);
            // return await query.ToListAsync<Stock>();
        }
        public async Task<Stock> AddStockItem()
        {
            throw new NotImplementedException();
        }
    }
}