using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SJCRUDStock.DataService.Interfaces;
using SJCRUDStock.DataService.Services;
using SJCRUDStock.ObjectModel.Models;

namespace SJCRUDStock.WebApi.Controllers
{
    /// </summary>
    /// Handles access to data in stock CRUD
    /// </summary>
    [ApiController]
    [Route("rest/stockjock/storage/[controller]")]
    public class StockController : ControllerBase
    {
        private readonly IStockService stockService;

        public StockController()
        {
            stockService = new StockService();
        }
    
        /// </summary>
        /// Returns a list of stock items
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(Task), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetSymbol() => Ok(await stockService.GetStockItems());
    }
}