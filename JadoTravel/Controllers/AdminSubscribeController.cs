using JadoTravel.Features.Mediator.Commands.SubscribeCommands;
using JadoTravel.Features.Mediator.Queries.SubscribeQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace JadoTravel.Controllers
{
	public class AdminSubscribeController : Controller
	{
		private readonly IMediator _mediator;

		public AdminSubscribeController(IMediator mediator)
		{
			_mediator = mediator;
		}

		public async Task<IActionResult> Index()
		{
			var values = await _mediator.Send(new GetSubscribeQuery());
			return View(values);
		}

		public async Task<IActionResult> DeleteSubscribe(int id)
		{
			await _mediator.Send(new RemoveSubscribeCommand(id));
			return RedirectToAction("Index");
		}

		[HttpGet]
		public async Task<IActionResult> UpdateSubscribe(int id)
		{
			var value = await _mediator.Send(new GetSubscribeByIdQuery(id));

			var subscribe = new UpdateSubscribeCommand
			{
				SubscribeId = value.SubscribeId,
				Mail = value.Mail
			};

			return View(subscribe);
		}
		[HttpPost]
		public async Task<IActionResult> UpdateSubscribe(UpdateSubscribeCommand command)
		{
			await _mediator.Send(command);
			return RedirectToAction("Index");
		}
	}
}
