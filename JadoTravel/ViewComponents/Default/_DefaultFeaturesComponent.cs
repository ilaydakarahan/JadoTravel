using JadoTravel.Features.CQRS.Handlers.FeatureHandlers;
using Microsoft.AspNetCore.Mvc;

namespace JadoTravel.ViewComponents.Default
{
    public class _DefaultFeaturesComponent : ViewComponent
    {
        private readonly GetFeatureQueryHandler _getFeatureQueryHandler;

		public _DefaultFeaturesComponent(GetFeatureQueryHandler getFeatureQueryHandler)
		{
			_getFeatureQueryHandler = getFeatureQueryHandler;
		}

		public IViewComponentResult Invoke()
        {
            var values = _getFeatureQueryHandler.Handle();
            return View(values);
        }
    }
}
