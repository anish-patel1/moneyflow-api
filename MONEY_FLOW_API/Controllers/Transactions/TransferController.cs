using MONEY_FLOW_API.IService;
using MONEY_FLOW_API.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
        [HttpGet]
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
            var data = await _transferService.Insert(obj);

            return Ok(new {message = "Transfer created successfully!" });
        }
        #endregion

        #region # Update Method
        [HttpPost]
        public async Task<IActionResult> Update(Transfer obj)
        {
            var data = await _transferService.Update(obj);

            return Ok(new { message = "Transfer updated successfully!" });
        }
        #endregion

        #region # Delete Method
        [HttpPost]
        public async Task<IActionResult> Delete(Transfer obj)
        {
            var data = await _transferService.Delete(obj);

            return Ok(new { message = "Transfer deleted successfully!" });
        }
        #endregion
        
        #endregion
    }
}
