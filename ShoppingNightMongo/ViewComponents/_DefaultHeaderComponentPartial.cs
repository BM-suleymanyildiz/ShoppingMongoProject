using Microsoft.AspNetCore.Mvc;

namespace ShoppingNightMongo.ViewComponents
{
    public class _DefaultHeaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
