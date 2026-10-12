using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MONEY_FLOW_API.IService;
using MONEY_FLOW_API.Model;

namespace MONEY_FLOW_API.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly IReportsService _reportsService;

        public ReportsController(IReportsService reportsService)
        {
            _reportsService = reportsService;
        }

        #region # Monthly Reconciliation Report
        [HttpPost]
        public async Task<IActionResult> MonthlyReconciliation(Reports obj)
        {
            var data = await _reportsService.MonthlyReconciliation(obj);

            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> CategoryBreakdown(Reports obj)
        {
            var data = await _reportsService.CategoryBreakdown(obj);

            return Ok(data);
        }
        #endregion
    }
}
