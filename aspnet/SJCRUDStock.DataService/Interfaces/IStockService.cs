using SJCRUDStock.ObjectModel.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SJCRUDStock.DataService.Interfaces
{
    public interface IStockService
    {
        Task<IEnumerable<Stock>> GetStockList();
    }
}