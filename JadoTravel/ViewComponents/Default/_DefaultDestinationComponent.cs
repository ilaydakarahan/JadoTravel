using JadoTravel.Features.CQRS.Handlers.DestinationHandlers;
using JadoTravel.Features.CQRS.Results.DestinationResults;
using JadoTravel.Features.Mediator.Queries.ServiceQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace JadoTravel.ViewComponents.Default
{
    public class _DefaultDestinationComponent : ViewComponent
    {
		private readonly GetDestinationHomeQueryHandler _getDestinationHomeQueryHandler;

		public _DefaultDestinationComponent(GetDestinationHomeQueryHandler getDestinationHomeQueryHandler)
		{
			_getDestinationHomeQueryHandler = getDestinationHomeQueryHandler;
		}

		public IViewComponentResult Invoke()
        {
			var values = _getDestinationHomeQueryHandler.Handle();
			return View(values);
		}
    }
}
