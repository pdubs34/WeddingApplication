using Microsoft.AspNetCore.Mvc;

namespace WeddingApplication.Controllers
{
    public class WPController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
