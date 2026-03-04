using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MONEY_FLOW_API.IService;

namespace MONEY_FLOW_API.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IDashboardService _dashboardService;
        public DashboardController(IDashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }

        #region # Summary Select Method
        [HttpGet]
        public async Task<IActionResult> SummarySelect(int? id)
        {
            var data = await _dashboardService.SummarySelect(id);

            return Ok(data);
        }
        #endregion
    }
}
