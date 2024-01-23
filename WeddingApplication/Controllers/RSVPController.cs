using Microsoft.AspNetCore.Mvc;

namespace WeddingApplication.Controllers
{
    public class RSVPController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
