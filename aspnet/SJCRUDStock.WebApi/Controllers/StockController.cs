using System.Collections;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SJCRUDStock.WebApi.Controllers
{
    /// </summary>
    /// Handles access to data in stock CRUD
    /// </summary>
    [ApiController]
    [Route("rest/stockjock/storage/[controller]")]
    public class StockController : ControllerBase
    {
        /// </summary>
        /// Allows access to stock symbol data
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetSymbol() => Ok("Boom!");
    }
}