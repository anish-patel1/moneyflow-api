using MONEY_FLOW_API.IService;
using MONEY_FLOW_API.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MONEY_FLOW_API.Controllers.Admin
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VersionController : ControllerBase
    {
        private readonly IVersionService _versionService;
        public VersionController(IVersionService versionService)
        {
            _versionService = versionService;
        }

        #region # COMMON METHODS

        #region # SelectAll Method
        [HttpPost]
        public async Task<IActionResult> SelectAll(Versions obj)
        {
            var data = await _versionService.SelectAll(obj);

            return Ok(data);
        }
        #endregion

        #region # Select Method
        [HttpGet]
        public async Task<IActionResult> Select(int? id)
        {
            var data = await _versionService.Select(id);

            return Ok(data);
        }
        #endregion

        #region # Insert Method
        [HttpPost]
        public async Task<IActionResult> Insert(Versions obj)
        {
            var data = await _versionService.Insert(obj);

            return Ok(new { message = "Version created successfully!" });
        }
        #endregion

        #region # Update Method
        [HttpPost]
        public async Task<IActionResult> Update(Versions obj)
        {
            var data = await _versionService.Update(obj);

            return Ok(new { message = "Version updated successfully!" });
        }
        #endregion

        #region # Delete Method
        [HttpPost]
        public async Task<IActionResult> Delete(Versions obj)
        {
            var data = await _versionService.Delete(obj);

            return Ok(new { message = "Version deleted successfully!" });
        }
        #endregion

        #endregion

        #region # GET LATEST VERSION
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetLatestVersion()
        {
            var data = await _versionService.GetLatestVersion();

            return Ok(data);
        }
        #endregion
    }
}
