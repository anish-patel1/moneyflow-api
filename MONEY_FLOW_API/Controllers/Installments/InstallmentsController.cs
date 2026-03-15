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

        #endregion
    }
}
