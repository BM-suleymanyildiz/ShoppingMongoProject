using Microsoft.AspNetCore.Mvc;
using ShoppingNightMongo.Services.SliderServices;
using ShoppingNightMongo.Dtos.SliderDtos;
namespace ShoppingNightMongo.Controllers
{
    public class SlidersController : Controller
    {
        private readonly ISliderService _sliderService;
        public SlidersController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }
        public async Task<IActionResult> SliderList()
        {
            var values = await _sliderService.GetAllSliderAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateSlider()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSlider(CreateSliderDto createSliderDto)
        {
            await _sliderService.CreateSliderAsync(createSliderDto);
            return RedirectToAction("SliderList");
        }
        public async Task<IActionResult> DeleteSlider(string id)
        {
            await _sliderService.DeleteSliderAsync(id);
            return RedirectToAction("SliderList");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateSlider(string id)
        {
            var values = await _sliderService.GetSliderByIdAsync(id);
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateSlider(UpdateSliderDto updateSliderDto)
        {
            await _sliderService.UpdateSliderAsync(updateSliderDto);
            return RedirectToAction("SliderList");
        }

    }
}
