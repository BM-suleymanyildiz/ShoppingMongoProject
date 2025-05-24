using Microsoft.AspNetCore.Mvc;

namespace ShoppingNightMongo.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
