using JadoTravel.Features.CQRS.Handlers.FeatureHandlers;
using JadoTravel.Features.CQRS.Queries.FeatureQueries;
using Microsoft.AspNetCore.Mvc;

namespace JadoTravel.Controllers
{
    public class AdminFeatureController : Controller
    {
        private readonly GetFeatureQueryHandler _getFeatureQueryHandler;
        private readonly GetFeatureByIdQueryHandler _getFeatureByIdQueryHandler;

		public AdminFeatureController(GetFeatureQueryHandler getFeatureQueryHandler, GetFeatureByIdQueryHandler getFeatureByIdQueryHandler)
		{
			_getFeatureQueryHandler = getFeatureQueryHandler;
			_getFeatureByIdQueryHandler = getFeatureByIdQueryHandler;
		}

		public IActionResult Index()
        {
            var values = _getFeatureQueryHandler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult UpdateFeature(int id)
        {
            var value = _getFeatureByIdQueryHandler.Handle(new GetFeatureByIdQuery(id));
            return View(value);
        }
        

    }
}
