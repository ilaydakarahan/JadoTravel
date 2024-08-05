using JadoTravel.Features.CQRS.Commands.FeatureCommands;
using JadoTravel.Features.CQRS.Handlers.FeatureHandlers;
using JadoTravel.Features.CQRS.Queries.FeatureQueries;
using Microsoft.AspNetCore.Mvc;

namespace JadoTravel.Controllers
{
    public class AdminFeatureController : Controller
    {
        private readonly GetFeatureQueryHandler _getFeatureQueryHandler;
        private readonly GetFeatureByIdQueryHandler _getFeatureByIdQueryHandler;
        private readonly UpdateFeatureCommandHandler _updateFeatureCommandHandler;

		public AdminFeatureController(GetFeatureQueryHandler getFeatureQueryHandler, GetFeatureByIdQueryHandler getFeatureByIdQueryHandler, UpdateFeatureCommandHandler updateFeatureCommandHandler)
		{
			_getFeatureQueryHandler = getFeatureQueryHandler;
			_getFeatureByIdQueryHandler = getFeatureByIdQueryHandler;
			_updateFeatureCommandHandler = updateFeatureCommandHandler;
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

            var feature = new UpdateFeatureCommand
            {
                FeatureId = value.FeatureId,
                Title = value.Title,
                ImageUrl = value.ImageUrl,
                LongDescription = value.LongDescription,
                ShortDescription = value.ShortDescription
            };
            return View(feature);
        }

        [HttpPost]
		public IActionResult UpdateFeature(UpdateFeatureCommand command)
        {
            _updateFeatureCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }


	}
}
