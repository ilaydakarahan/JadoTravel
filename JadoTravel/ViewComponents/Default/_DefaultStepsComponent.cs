using JadoTravel.Features.CQRS.Handlers.StepHandlers;
using Microsoft.AspNetCore.Mvc;

namespace JadoTravel.ViewComponents.Default
{
    public class _DefaultStepsComponent : ViewComponent
    {
        private readonly GetStepQueryHandler _getStepQueryHandler;

		public _DefaultStepsComponent(GetStepQueryHandler getStepQueryHandler)
		{
			_getStepQueryHandler = getStepQueryHandler;
		}

		public IViewComponentResult Invoke()
        {
            var values = _getStepQueryHandler.Handle();
            return View(values);
        }
    }
}
