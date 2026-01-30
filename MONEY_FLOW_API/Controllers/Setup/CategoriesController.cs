using MONEY_FLOW_API.IService;
using MONEY_FLOW_API.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MONEY_FLOW_API.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriesService _categoriesService;
        public CategoriesController(ICategoriesService categoriesService)
        {
            _categoriesService = categoriesService;
        }

        #region # COMMON METHODS

        #region # SelectAll Method
        [HttpPost]
        public async Task<IActionResult> SelectAll(Categories obj)
        {
            var data = await _categoriesService.SelectAll(obj);

            return Ok(data);
        }
        #endregion

        #region # Select Method
        [HttpGet]
        public async Task<IActionResult> Select(int? id)
        {
            var data = await _categoriesService.Select(id);

            return Ok(data);
        }
        #endregion

        #region # Insert Method
        [HttpPost]
        public async Task<IActionResult> Insert(Categories obj)
        {
            var data = await _categoriesService.Insert(obj);

            return Ok(new {message = "Category created successfully!" });
        }
        #endregion

        #region # Update Method
        [HttpPost]
        public async Task<IActionResult> Update(Categories obj)
        {
            var data = await _categoriesService.Update(obj);

            return Ok(new { message = "Category updated successfully!" });
        }
        #endregion

        #region # Delete Method
        [HttpPost]
        public async Task<IActionResult> Delete(Categories obj)
        {
            var data = await _categoriesService.Delete(obj);

            return Ok(new { message = "Category deleted successfully!" });
        }
        #endregion

        #region # Dropdown Method
        [HttpPost]
        public async Task<IActionResult> DropDown(Categories obj)
        {
            var data = await _categoriesService.DropDown(obj);

            return Ok(data);
        }
        #endregion

        #endregion
    }
}
