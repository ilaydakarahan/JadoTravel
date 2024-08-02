using Microsoft.AspNetCore.Mvc;

namespace JadoTravel.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
