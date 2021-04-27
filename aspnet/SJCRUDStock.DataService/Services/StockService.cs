using System.Threading.Tasks;
using System.Collections.Generic;
using SJCRUDStock.DataService.Interfaces;
using SJCRUDStock.ObjectModel.Models;
using SJCRUDStock.DataService.Repositories;

namespace SJCRUDStock.DataService.Services
{
    public class StockService : IStockService
    {
        private IStockRepo StockRepo;

        public StockService()
        {
            StockRepo = new StockRepo();
        }

        public async Task<IEnumerable<Stock>> GetStockList()
        {
            return await StockRepo.GetStocks();
        }
    }
}