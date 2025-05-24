using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShoppingNightMongo.Dtos.ProductDtos;
using ShoppingNightMongo.Entities;
using ShoppingNightMongo.Services.CategoryServices;
using ShoppingNightMongo.Services.ProductServices;
using ShoppingNightMongo.ViewModels;


namespace ShoppingNightMongo.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public ProductsController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public async Task<IActionResult> ProductList(string categoryId)
        {
            var allProducts = await _productService.GetAllProductAsync();
            var categories = await _categoryService.GetAllCategoryAsync();

            if (!string.IsNullOrEmpty(categoryId))
            {
                allProducts = allProducts.Where(p => p.CategoryId == categoryId).ToList();
            }

            var model = new ProductCategoryViewModel
            {
                Products = allProducts,
                Categories = categories
            };

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> CreateProduct()
        {
            var categories = await _categoryService.GetAllCategoryAsync();
            ViewBag.v = categories.Select(c => new SelectListItem
            {
                Text = c.CategoryName,
                Value = c.CategoryId
            }).ToList();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {

            await _productService.CreateProductAsync(createProductDto);
            return RedirectToAction("ProductList");
        }

        public async Task<IActionResult> DeleteProduct(string id)
        {
            await _productService.DeleteProductAsync(id);
            return RedirectToAction("ProductList");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateProduct(string id)
        {
            var values = await _productService.GetProductByIdAsync(id);
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        {
            await _productService.UpdateProductAsync(updateProductDto);
            return RedirectToAction("ProductList");
        }
    }
}
