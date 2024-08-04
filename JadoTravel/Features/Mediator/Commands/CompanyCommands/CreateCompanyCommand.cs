using MediatR;

namespace JadoTravel.Features.Mediator.Commands.CompanyCommands
{
	public class CreateCompanyCommand : IRequest
	{
		public string ImageUrl { get; set; }
	}
}
