using Microsoft.AspNetCore.Mvc;
using ShoppingNightMongo.Services.CategoryServices;
using ShoppingNightMongo.Services.SliderServices;
using ShoppingNightMongo.ViewComponents;

namespace ShoppingNightMongo.ViewComponents
{
    public class _DefaultBannerComponentPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        public _DefaultBannerComponentPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _categoryService.GetAllCategoryAsync();
            return View(value);
        }
    }
}
