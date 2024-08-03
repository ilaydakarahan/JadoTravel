using JadoTravel.Features.Mediator.Queries.CompanyQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace JadoTravel.ViewComponents.Default
{
    public class _DefaultCompanyComponent : ViewComponent
    {
        private readonly IMediator _mediator;

		public _DefaultCompanyComponent(IMediator mediator)
		{
			_mediator = mediator;
		}

		public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _mediator.Send(new GetCompanyQuery());
            return View(values);
        }
    }
}
