using MONEY_FLOW_API.IService;
using MONEY_FLOW_API.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

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
            try
            {
                await _transactionsService.Insert(obj);

                return Ok(new
                {
                    success = true,
                    type = "success",
                    message = "Transaction created successfully!"
                });
            }
            catch (SqlException ex)
            {
                return Ok(new
                {
                    success = false,
                    type = "warning",
                    message = ex.Message
                });
            }
            catch (Exception)
            {
                return StatusCode(500, new
                {
                    success = false,
                    type = "error",
                    message = "Something went wrong."
                });
            }
        }
        #endregion

        #region # Update Method
        [HttpPost]
        public async Task<IActionResult> Update(Transactions obj)
        {
            try
            {
                await _transactionsService.Update(obj);

                return Ok(new
                {
                    success = true,
                    type = "success",
                    message = "Transaction updated successfully!"
                });
            }
            catch (SqlException ex)
            {
                return Ok(new
                {
                    success = false,
                    type = "warning",
                    message = ex.Message
                });
            }
            catch (Exception)
            {
                return StatusCode(500, new
                {
                    success = false,
                    type = "error",
                    message = "Something went wrong."
                });
            }
        }
        #endregion

        #region # Delete Method
        [HttpPost]
        public async Task<IActionResult> Delete(Transactions obj)
        {
            try
            {
                await _transactionsService.Delete(obj);

                return Ok(new
                {
                    success = true,
                    type = "success",
                    message = "Transaction deleted successfully!"
                });
            }
            catch (SqlException ex)
            {
                return Ok(new
                {
                    success = false,
                    type = "warning",
                    message = ex.Message
                });
            }
            catch (Exception)
            {
                return StatusCode(500, new
                {
                    success = false,
                    type = "error",
                    message = "Something went wrong."
                });
            }
        }
        #endregion

        #endregion
    }
}
