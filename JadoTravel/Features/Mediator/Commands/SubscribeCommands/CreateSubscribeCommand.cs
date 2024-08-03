using MediatR;

namespace JadoTravel.Features.Mediator.Commands.SubscribeCommands
{
	public class CreateSubscribeCommand : IRequest
	{
		public string Mail { get; set; }
	}
}
