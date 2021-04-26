using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SJCRUDStock.ObjectModel.Models;

namespace SJCRUDStock.DataService.Interfaces
{
    public interface IStockRepo
    {
        Task<List<Stock>> GetStocks();
    }
}