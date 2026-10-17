using MONEY_FLOW_API.IService;
using MONEY_FLOW_API.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MONEY_FLOW_API.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BudgetsController : ControllerBase
    {
        private readonly IBudgetsService _budgetsService;
        public BudgetsController(IBudgetsService budgetsService)
        {
            _budgetsService = budgetsService;
        }

        #region # COMMON METHODS

        #region # SelectAll Method
        [HttpPost]
        public async Task<IActionResult> SelectAll(Budgets obj)
        {
            var data = await _budgetsService.SelectAll(obj);
            return Ok(data);
        }
        #endregion

        #region # Insert Method
        [HttpPost]
        public async Task<IActionResult> Insert(Budgets obj)
        {
            var data = await _budgetsService.Insert(obj);
            return Ok(new { message = "Budget saved successfully!" });
        }
        #endregion

        #region # Delete Method
        [HttpPost]
        public async Task<IActionResult> Delete(Budgets obj)
        {
            var data = await _budgetsService.Delete(obj);
            return Ok(new { message = "Budget deleted successfully!" });
        }
        #endregion

        #region # AutoGenerate Method
        [HttpPost]
        public async Task<IActionResult> AutoGenerate(Budgets obj)
        {
            var data = await _budgetsService.AutoGenerate(obj);
            return Ok(new { message = "Budgets auto-generated from active categories successfully!" });
        }
        #endregion

        #endregion
    }
}
