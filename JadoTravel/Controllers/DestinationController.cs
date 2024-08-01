using JadoTravel.Features.CQRS.Commands;
using JadoTravel.Features.CQRS.Commands.DestinationCommands;
using JadoTravel.Features.CQRS.Handlers.DestinationHandlers;
using JadoTravel.Features.CQRS.Queries.DestinationQueries;
using Microsoft.AspNetCore.Mvc;

namespace JadoTravel.Controllers
{
    public class DestinationController : Controller
    {
        private readonly GetDestinationQueryHandler _getDestinationQueryHandler;
        private readonly GetDestinationByIdQueryHandler _getByIdHandler;
        private readonly CreateDestinationCommandHandler _createDestinationCommandHandler;
        private readonly RemoveDestinationCommandHandler _removeDestinationCommandHandler;
        private readonly UpdateDestinationCommandHandler _updateDestinationCommandHandler;

        public DestinationController(GetDestinationQueryHandler getDestinationQueryHandler, GetDestinationByIdQueryHandler getByIdHandler, CreateDestinationCommandHandler createDestinationCommandHandler, RemoveDestinationCommandHandler removeDestinationCommandHandler, UpdateDestinationCommandHandler updateDestinationCommandHandler)
        {
            _getDestinationQueryHandler = getDestinationQueryHandler;
            _getByIdHandler = getByIdHandler;
            _createDestinationCommandHandler = createDestinationCommandHandler;
            _removeDestinationCommandHandler = removeDestinationCommandHandler;
            _updateDestinationCommandHandler = updateDestinationCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _getDestinationQueryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var value = _getByIdHandler.Handle(new GetDestinationByIdQuery(id));
            //id'ye göre getirme işleminde değerler byidquery türünde geliyor ama post işleminde command türünde gönderdiğimiz için altta mapleme yaptık.
            var destination = new UpdateDestinationCommand
            {
                City = value.City,
                DestinationId = value.DestinationId,
                Price = value.Price,
                Image = value.Image,
                Duration = value.Duration
            };
            return View(destination);
        }

        [HttpPost]
        public IActionResult UpdateDestination(UpdateDestinationCommand command)
        {
            _updateDestinationCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateDestination()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateDestination(CreateDestinationCommand command)
        {
            _createDestinationCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteDestination(int id)
        {
            _removeDestinationCommandHandler.Handle(new RemoveDestinationCommand(id));
            return RedirectToAction("Index");
        }
    }
}
