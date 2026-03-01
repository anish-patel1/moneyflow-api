
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
    public class TransferController : ControllerBase
    {
        private readonly ITransferService _transferService;
        public TransferController(ITransferService transferService)
        {
            _transferService = transferService;
        }

        #region # COMMON METHODS

        #region # Select Method
        [HttpPost]
        public async Task<IActionResult> Select(Transfer obj)
        {
            var data = await _transferService.Select(obj);

            return Ok(data);
        }
        #endregion

        #region # Insert Method
        [HttpPost]
        public async Task<IActionResult> Insert(Transfer obj)
        {
            try
            {
                await _transferService.Insert(obj);

                return Ok(new
                {
                    success = true,
                    type = "success",
                    message = "Transfer created successfully!"
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
        public async Task<IActionResult> Update(Transfer obj)
        {
            try
            {
                await _transferService.Update(obj);

                return Ok(new
                {
                    success = true,
                    type = "success",
                    message = "Transfer updated successfully!"
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
        public async Task<IActionResult> Delete(Transfer obj)
        {
            try
            {
                await _transferService.Delete(obj);

                return Ok(new
                {
                    success = true,
                    type = "success",
                    message = "Transfer deleted successfully!"
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
