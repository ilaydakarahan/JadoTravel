using MediatR;

namespace JadoTravel.Features.Mediator.Commands.CompanyCommands
{
	public class RemoveCompanyCommand : IRequest
	{
        public int Id { get; set; }

		public RemoveCompanyCommand(int id)
		{
			Id = id;
		}
	}
}
