using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using SJCRUDStock.ObjectModel.Models;

namespace SJCRUDStock.DataService.Repositories
{
    public class StockRepo : IStockRepo
    {
        // private StockContext _ctx;

        private List<Stock> StockList;
        private Stock Stock;

        public StockRepo(/*StockContext context*/)
        {
            // _ctx = ctx;

            Stock = new Stock() {
                Symbol = "Stock Symbol",
                Name = "Stock Name",
                ExchangeName = "Exchange Name",
                Currency = "Currency"
            };

            StockList = new List<Stock>();
            StockList.Add(Stock);
        }
        public async Task<List<Stock>> GetStocks()
        {
            IEnumerable<Stock> list = StockList;
            return list;

            // throw new NotImplementedException();

            // var query = _ctx.Posts.OrderByDescending(p => p.Timestamp).Skip(offset).Take(pageSize);
            // return await query.ToListAsync<PostModel>();
        }
    }
}