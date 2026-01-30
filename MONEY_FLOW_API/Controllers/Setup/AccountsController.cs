using MONEY_FLOW_API.IService;
using MONEY_FLOW_API.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MONEY_FLOW_API.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountsService _accountsService;
        public AccountsController(IAccountsService accountsService)
        {
            _accountsService = accountsService;
        }

        #region # COMMON METHODS

        #region # SelectAll Method
        [HttpPost]
        public async Task<IActionResult> SelectAll(Accounts obj)
        {
            var data = await _accountsService.SelectAll(obj);

            return Ok(data);
        }
        #endregion

        #region # Select Method
        [HttpGet]
        public async Task<IActionResult> Select(int? id)
        {
            var data = await _accountsService.Select(id);

            return Ok(data);
        }
        #endregion

        #region # Insert Method
        [HttpPost]
        public async Task<IActionResult> Insert(Accounts obj)
        {
            var data = await _accountsService.Insert(obj);

            return Ok(new {message = "Account created successfully!" });
        }
        #endregion

        #region # Update Method
        [HttpPost]
        public async Task<IActionResult> Update(Accounts obj)
        {
            var data = await _accountsService.Update(obj);

            return Ok(new { message = "Account updated successfully!" });
        }
        #endregion

        #region # Delete Method
        [HttpPost]
        public async Task<IActionResult> Delete(Accounts obj)
        {
            var data = await _accountsService.Delete(obj);

            return Ok(new { message = "Account deleted successfully!" });
        }
        #endregion

        #region # Dropdown Method
        [HttpPost]
        public async Task<IActionResult> DropDown(Accounts obj)
        {
            var data = await _accountsService.DropDown(obj);

            return Ok(data);
        }
        #endregion

        #endregion
    }
}
