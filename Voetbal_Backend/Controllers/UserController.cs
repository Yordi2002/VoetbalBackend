using Microsoft.AspNetCore.Mvc;

namespace VoetbalWeb.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
