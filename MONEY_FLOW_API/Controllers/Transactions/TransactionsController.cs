using MONEY_FLOW_API.IService;
using MONEY_FLOW_API.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MONEY_FLOW_API.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionsService _transactionsService;
        public TransactionsController(ITransactionsService transactionsService)
        {
            _transactionsService = transactionsService;
        }

        #region # COMMON METHODS

        #region # SelectAll Method
        [HttpPost]
        public async Task<IActionResult> SelectAll(Transactions obj)
        {
            var data = await _transactionsService.SelectAll(obj);

            return Ok(data);
        }
        #endregion

        #region # Select Method
        [HttpGet]
        public async Task<IActionResult> Select(int? id)
        {
            var data = await _transactionsService.Select(id);

            return Ok(data);
        }
        #endregion

        #region # Insert Method
        [HttpPost]
        public async Task<IActionResult> Insert(Transactions obj)
        {
            var data = await _transactionsService.Insert(obj);

            return Ok(new {message = "Transaction created successfully!" });
        }
        #endregion

        #region # Update Method
        [HttpPost]
        public async Task<IActionResult> Update(Transactions obj)
        {
            var data = await _transactionsService.Update(obj);

            return Ok(new { message = "Transaction updated successfully!" });
        }
        #endregion

        #region # Delete Method
        [HttpPost]
        public async Task<IActionResult> Delete(Transactions obj)
        {
            var data = await _transactionsService.Delete(obj);

            return Ok(new { message = "Transaction deleted successfully!" });
        }
        #endregion
        
        #endregion
    }
}
