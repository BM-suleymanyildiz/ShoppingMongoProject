using Microsoft.AspNetCore.Mvc;
using ShoppingNightMongo.Services.CategoryServices;
using ShoppingNightMongo.Services.ProductServices;
using ShoppingNightMongo.ViewModels;

namespace ShoppingNightMongo.ViewComponents
{
    public class _DefaultProductDetailComponentPartial : ViewComponent
    {
        private readonly IProductService _productService;

        public _DefaultProductDetailComponentPartial(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            var product = await _productService.GetProductByIdAsync(id);
            return View(product);
        }
    }
}
