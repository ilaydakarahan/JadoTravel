using JadoTravel.Features.CQRS.Commands.StepCommands;
using JadoTravel.Features.CQRS.Handlers.StepHandlers;
using JadoTravel.Features.CQRS.Queries.StepQueries;
using Microsoft.AspNetCore.Mvc;

namespace JadoTravel.Controllers
{
	public class AdminStepController : Controller
	{
		private readonly GetStepQueryHandler _getStepQueryHandler;
		private readonly GetStepByIdQueryHandler _getStepByIdQueryHandler;
		private readonly CreateStepCommandHandler _createStepCommandHandler;
		private readonly RemoveStepCommandHandler _removeStepCommandHandler;
		private readonly UpdateStepCommandHandler _updateStepCommandHandler;

		public AdminStepController(GetStepQueryHandler getStepQueryHandler, CreateStepCommandHandler createStepCommandHandler, RemoveStepCommandHandler removeStepCommandHandler, GetStepByIdQueryHandler getStepByIdQueryHandler, UpdateStepCommandHandler updateStepCommandHandler)
		{
			_getStepQueryHandler = getStepQueryHandler;
			_getStepByIdQueryHandler = getStepByIdQueryHandler;
			_createStepCommandHandler = createStepCommandHandler;
			_removeStepCommandHandler = removeStepCommandHandler;
			_updateStepCommandHandler = updateStepCommandHandler;
		}

		public IActionResult Index()
		{
			var values = _getStepQueryHandler.Handle();
			return View(values);
		}

		[HttpGet]
		public IActionResult CreateStep()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CreateStep(CreateStepCommand command)
		{
			_createStepCommandHandler.Handle(command);
			return RedirectToAction("Index");
		}

		public IActionResult DeleteStep(int id)
		{
			_removeStepCommandHandler.Handle(new RemoveStepCommand(id));
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult UpdateStep(int id)
		{
			var value = _getStepByIdQueryHandler.Handle(new GetStepByIdQuery(id));
			var step = new UpdateStepCommand
			{
				Description = value.Description,
				Title = value.Title,
				Icon = value.Icon,
				StepId = value.StepId
			};
			return View(step);

		}
		[HttpPost]
		public IActionResult UpdateStep(UpdateStepCommand command)
		{
			_updateStepCommandHandler.Handle(command);
			return RedirectToAction("Index");
		}
	}
}
