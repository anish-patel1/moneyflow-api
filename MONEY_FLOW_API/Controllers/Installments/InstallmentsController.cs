using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MONEY_FLOW_API.IService;
using MONEY_FLOW_API.Model;
using MONEY_FLOW_API.Service;
using System.Data.SqlClient;

namespace MONEY_FLOW_API.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InstallmentsController : ControllerBase
    {
        private readonly IInstallmentsService _installmentsService;
        public InstallmentsController(IInstallmentsService installmentsService)
        {
            _installmentsService = installmentsService;
        }

        #region # COMMON METHODS

        #region # SelectAll Method
        [HttpPost]
        public async Task<IActionResult> SelectAll(Installments obj)
        {
            var data = await _installmentsService.SelectAll(obj);

            return Ok(data);
        }
        #endregion

        #region # Select Method
        [HttpGet]
        public async Task<IActionResult> Select(int? id)
        {
            var data = await _installmentsService.Select(id);

            return Ok(data);
        }
        #endregion

        #region # Insert Method
        [HttpPost]
        public async Task<IActionResult> Insert(Installments obj)
        {
            try
            {
                await _installmentsService.Insert(obj);

                return Ok(new
                {
                    success = true,
                    type = "success",
                    message = "Installment created successfully!"
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
        public async Task<IActionResult> Update(Installments obj)
        {
            try
            {
                await _installmentsService.Update(obj);

                return Ok(new
                {
                    success = true,
                    type = "success",
                    message = "Installment updated successfully!"
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
        public async Task<IActionResult> Delete(Installments obj)
        {
            try
            {
                await _installmentsService.Delete(obj);

                return Ok(new
                {
                    success = true,
                    type = "success",
                    message = "Installment deleted successfully!"
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

        #region # Dropdown Method
        [HttpPost]
        public async Task<IActionResult> DropDown(Installments obj)
        {
            var data = await _installmentsService.DropDown(obj);

            return Ok(data);
        }
        #endregion

        #region # SCHEDULE ENDPOINTS

        #region # ScheduleSelectAll
        [HttpPost]
        public async Task<IActionResult> ScheduleSelectAll(InstallmentSchedule obj)
        {
            var data = await _installmentsService.ScheduleSelectAll(obj);
            return Ok(data);
        }
        #endregion

        #region # ScheduleInsert
        [HttpPost]
        public async Task<IActionResult> ScheduleInsert(InstallmentSchedule obj)
        {
            try
            {
                await _installmentsService.ScheduleInsert(obj);
                return Ok(new
                {
                    success = true,
                    type = "success",
                    message = "Schedule entry saved successfully!"
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

        #region # ScheduleBulkInsert
        [HttpPost]
        public async Task<IActionResult> ScheduleBulkInsert(InstallmentSchedule obj)
        {
            try
            {
                await _installmentsService.ScheduleBulkInsert(obj);
                return Ok(new
                {
                    success = true,
                    type = "success",
                    message = "Amortization schedule saved successfully!"
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

        #region # ScheduleDelete
        [HttpPost]
        public async Task<IActionResult> ScheduleDelete(InstallmentSchedule obj)
        {
            try
            {
                await _installmentsService.ScheduleDelete(obj);
                return Ok(new
                {
                    success = true,
                    type = "success",
                    message = "Schedule entry deleted successfully!"
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

        #region # SchedulePayMultiple
        [HttpPost]
        public async Task<IActionResult> SchedulePayMultiple(PayMultipleScheduleRequest obj)
        {
            try
            {
                await _installmentsService.SchedulePayMultiple(obj);
                return Ok(new
                {
                    success = true,
                    type = "success",
                    message = "Batch installment payment recorded successfully!"
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
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    success = false,
                    type = "error",
                    message = ex.Message
                });
            }
        }
        #endregion

        #endregion

        #endregion
    }
}
