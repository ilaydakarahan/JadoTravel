using JadoTravel.Features.CQRS.Handlers.DestinationHandlers;
using JadoTravel.Features.CQRS.Results.DestinationResults;
using JadoTravel.Features.Mediator.Queries.ServiceQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace JadoTravel.ViewComponents.Default
{
    public class _DefaultDestinationComponent : ViewComponent
    {
		private readonly GetDestinationQueryHandler _getDestinationQueryHandler;

		public _DefaultDestinationComponent(GetDestinationQueryHandler getDestinationQueryHandler)
		{
			_getDestinationQueryHandler = getDestinationQueryHandler;
		}

		public IViewComponentResult Invoke()
        {
			var values = _getDestinationQueryHandler.Handle();
			return View(values);
		}
    }
}
