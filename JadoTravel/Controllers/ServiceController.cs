using JadoTravel.Features.Mediator.Queries.ServiceQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace JadoTravel.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IMediator _mediator;

        public ServiceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetServiceQuery());

            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateService(int id)
        {
            var value = await _mediator.Send(new GetServiceByIdQuery(id));
            return View(value);
        }

    }
}
