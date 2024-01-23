using Microsoft.AspNetCore.Mvc;

namespace WeddingApplication.Controllers
{
    public class HWMController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
