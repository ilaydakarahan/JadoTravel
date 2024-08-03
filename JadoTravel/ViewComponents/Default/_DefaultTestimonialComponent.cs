using JadoTravel.Features.Mediator.Queries.TestimonialQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace JadoTravel.ViewComponents.Default
{
    public class _DefaultTestimonialComponent : ViewComponent
    {
        private readonly IMediator _mediator;

		public _DefaultTestimonialComponent(IMediator mediator)
		{
			_mediator = mediator;
		}

		public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _mediator.Send(new GetTestimonialQuery());
            return View(values);
        }
    }
}
