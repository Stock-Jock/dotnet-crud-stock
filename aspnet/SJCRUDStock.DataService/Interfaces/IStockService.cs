using SJObjectModel.Models;

namespace SJCRUDStock.DataService.Interfaces
{
    public interface IStockService
    {
        public async Stock[] GetStockList();
    }
}