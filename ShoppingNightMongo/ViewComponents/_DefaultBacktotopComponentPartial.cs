using Microsoft.AspNetCore.Mvc;

namespace ShoppingNightMongo.ViewComponents
{
    public class _DefaultBacktotopComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
