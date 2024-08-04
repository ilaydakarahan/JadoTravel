using MediatR;

namespace JadoTravel.Features.Mediator.Commands.SubscribeCommands
{
	public class UpdateSubscribeCommand : IRequest
	{
		public int SubscribeId { get; set; }
		public string Mail { get; set; }
	}
}
