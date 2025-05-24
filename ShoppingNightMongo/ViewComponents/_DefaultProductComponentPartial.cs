using Microsoft.AspNetCore.Mvc;
using ShoppingNightMongo.Services.CategoryServices;
using ShoppingNightMongo.Services.ProductServices;
using ShoppingNightMongo.ViewModels;

namespace ShoppingNightMongo.ViewComponents
{
    public class _DefaultProductComponentPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        public _DefaultProductComponentPartial(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var products = await _productService.GetAllProductAsync();
            var categories = await _categoryService.GetAllCategoryAsync();

            var model = new ProductCategoryViewModel
            {
                Products = products,
                Categories = categories
            };

            return View(model);
        }
    }
}
