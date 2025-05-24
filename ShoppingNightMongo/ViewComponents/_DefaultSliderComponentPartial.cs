using Microsoft.AspNetCore.Mvc;
using ShoppingNightMongo.Services;
using ShoppingNightMongo.Services.SliderServices;
namespace ShoppingNightMongo.ViewComponents
{
    public class _DefaultSliderComponentPartial : ViewComponent
    {
        private readonly ISliderService _sliderService;

        public _DefaultSliderComponentPartial(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _sliderService.GetAllSliderAsync();
            return View(value);
        }

    }
}
