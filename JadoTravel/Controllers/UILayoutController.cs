using Microsoft.AspNetCore.Mvc;

namespace JadoTravel.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
