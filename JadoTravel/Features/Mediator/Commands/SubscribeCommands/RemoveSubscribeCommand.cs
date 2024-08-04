using MediatR;

namespace JadoTravel.Features.Mediator.Commands.SubscribeCommands
{
	public class RemoveSubscribeCommand : IRequest
	{
        public int Id { get; set; }

		public RemoveSubscribeCommand(int id)
		{
			Id = id;
		}
	}
}
