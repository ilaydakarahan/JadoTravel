using JadoTravel.Features.CQRS.Handlers.DestinationHandlers;
using Microsoft.AspNetCore.Mvc;

namespace JadoTravel.ViewComponents.Default
{
	public class _DefaultLastDestinationComponent : ViewComponent
	{
		private readonly GetLastDestinationQueryHandler _handler;

		public _DefaultLastDestinationComponent(GetLastDestinationQueryHandler handler)
		{
			_handler = handler;
		}

		public IViewComponentResult Invoke()
		{
			var value = _handler.Handle();
			return View(value);
		}
	}
}
