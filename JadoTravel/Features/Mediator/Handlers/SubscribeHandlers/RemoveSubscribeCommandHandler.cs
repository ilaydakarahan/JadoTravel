using JadoTravel.DataAccess.Context;
using JadoTravel.Features.Mediator.Commands.SubscribeCommands;
using MediatR;

namespace JadoTravel.Features.Mediator.Handlers.SubscribeHandlers
{
	public class RemoveSubscribeCommandHandler : IRequestHandler<RemoveSubscribeCommand>
	{
		private readonly JadooContext _context;

		public RemoveSubscribeCommandHandler(JadooContext context)
		{
			_context = context;
		}

		public async Task Handle(RemoveSubscribeCommand request, CancellationToken cancellationToken)
		{
			var value = await _context.Subscribes.FindAsync(request.Id);
			_context.Remove(value);
			await _context.SaveChangesAsync();
		}
	}
}
