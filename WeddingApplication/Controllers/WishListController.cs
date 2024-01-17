using Microsoft.AspNetCore.Mvc;

namespace WeddingApplication.Controllers
{
    public class WishListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
