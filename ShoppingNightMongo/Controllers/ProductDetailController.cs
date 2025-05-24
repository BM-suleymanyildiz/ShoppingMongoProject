using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShoppingNightMongo.Dtos.ProductDetailDtos;
using ShoppingNightMongo.Services.ProductDetailService;
using ShoppingNightMongo.Services.ProductServices;

namespace ShoppingNightMongo.Controllers
{
    public class ProductDetailController : Controller
    {
        private readonly IProductDetailService _productDetailService;
        private readonly IProductService _productService;

        public ProductDetailController(IProductDetailService productDetailService, IProductService productService)
        {
            _productDetailService = productDetailService;
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _productDetailService.GetAllProductDetailAsync();
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> CreateProductDetail()
        {
            var products = await _productService.GetAllProductAsync();
            ViewBag.v = products.Select(c => new SelectListItem
            {
                Text = c.ProductName,
                Value = c.ProductId
            }).ToList();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductDetail(CreateProductDetailDto createProductDetailDto)
        {
            await _productDetailService.CreateProductDetailAsync(createProductDetailDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteProductDetail(string id)
        {
            await _productDetailService.DeleteProductDetailAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateProductDetail(string id)
        {
            var products = await _productService.GetAllProductAsync();
            ViewBag.v = products.Select(c => new SelectListItem
            {
                Text = c.ProductName,
                Value = c.ProductId
            }).ToList();

            var ProductDetail = await _productDetailService.GetProductDetailByIdAsync(id);
            return View(ProductDetail);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProductDetail(UpdateProductDetailDto updateProductDetailDto)
        {
            await _productDetailService.UpdateProductDetailAsync(updateProductDetailDto);
            return RedirectToAction("Index");
        }
    }
}
