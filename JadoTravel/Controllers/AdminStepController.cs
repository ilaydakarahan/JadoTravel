using JadoTravel.Features.CQRS.Handlers.StepHandlers;
using Microsoft.AspNetCore.Mvc;

namespace JadoTravel.Controllers
{
	public class AdminStepController : Controller
	{
		private readonly GetStepQueryHandler _getStepQueryHandler;

		public AdminStepController(GetStepQueryHandler getStepQueryHandler)
		{
			_getStepQueryHandler = getStepQueryHandler;
		}

		public IActionResult Index()
		{
			return View();
		}
	}
}
