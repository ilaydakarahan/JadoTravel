using JadoTravel.Features.CQRS.Handlers.DestinationHandlers;
using JadoTravel.Features.Mediator.Commands.SubscribeCommands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace JadoTravel.Controllers
{
    public class DefaultController : Controller
    {
		private readonly IMediator _mediator;
		private readonly GetDestinationQueryHandler _getDestinationQueryHandler;

		public DefaultController(GetDestinationQueryHandler getDestinationQueryHandler, IMediator mediator)
		{
			_getDestinationQueryHandler = getDestinationQueryHandler;
			_mediator = mediator;
		}
		public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllDestination()
        {
			var values = _getDestinationQueryHandler.Handle();
			return View(values);
		}

		public async Task<IActionResult> CreateSubscribe(CreateSubscribeCommand command)
		{
			await _mediator.Send(command);
			return RedirectToAction("Index");
		}
    }
}
