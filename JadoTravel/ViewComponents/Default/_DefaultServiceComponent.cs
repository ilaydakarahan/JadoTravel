using JadoTravel.Features.Mediator.Queries.ServiceQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace JadoTravel.ViewComponents.Default
{
    public class _DefaultServiceComponent : ViewComponent
    {
        private readonly IMediator _mediator;

        public _DefaultServiceComponent(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _mediator.Send(new GetServiceQuery());

            return View(values);
        }
    }
}
