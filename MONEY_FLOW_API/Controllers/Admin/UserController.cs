using MONEY_FLOW_API.IService;
using MONEY_FLOW_API.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MONEY_FLOW_API.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        #region # COMMON METHODS

        #region # SelectAll Method
        [HttpPost]
        public async Task<IActionResult> SelectAll(User obj)
        {
            var data = await _userService.SelectAll(obj);

            return Ok(data);
        }
        #endregion

        #region # Select Method
        [HttpGet]
        public async Task<IActionResult> Select(int? id)
        {
            var data = await _userService.Select(id);

            return Ok(data);
        }
        #endregion

        #region # Insert Method
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Insert(User obj)
        {
            var data = await _userService.Insert(obj);

            if (data.IsExist > 0)
                return Ok(new { status = "exists", message = "User already exists!" });

            return Ok(new { status = "success", message = "User created successfully!" });
        }
        #endregion
        
        #region # Update Method
        [HttpPost]
        public async Task<IActionResult> Update(User obj)
        {
            var data = await _userService.Update(obj);

            return Ok(new { message = "User updated successfully!" });
        }
        #endregion

        #region # Delete Method
        [HttpPost]
        public async Task<IActionResult> Delete(User obj)
        {
            var data = await _userService.Delete(obj);

            return Ok(new { message = "User deleted successfully!" });
        }
        #endregion

        #endregion

        #region # UPDATE STATUS
        [HttpPost]
        public async Task<IActionResult> UpdateStatus(User obj)
        {
            var data = await _userService.UpdateStatus(obj);

            return Ok(new { message = "User status updated successfully!" });
        }
        #endregion

        #region # UNLOCK USER
        [HttpPost]
        public async Task<IActionResult> UnlockUser(User obj)
        {
            var data = await _userService.UnlockUser(obj);

            return Ok(new { message = "User unlocked successfully!" });
        }
        #endregion

        #region # USER LOG - SELECTALL
        [HttpPost]
        public async Task<IActionResult> Log_SelectAll(UserLog obj)
        {
            var data = await _userService.Log_SelectAll(obj);

            return Ok(data);
        }
        #endregion
    }
}
