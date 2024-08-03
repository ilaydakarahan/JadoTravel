using Microsoft.AspNetCore.Mvc;

namespace JadoTravel.Controllers
{
	public class AdminLayoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
