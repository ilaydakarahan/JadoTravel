using JadoTravel.DataAccess.Context;
using JadoTravel.DataAccess.Entities;
using JadoTravel.Features.Mediator.Commands.SubscribeCommands;
using MediatR;

namespace JadoTravel.Features.Mediator.Handlers.SubscribeHandlers
{
	public class CreateSubscribeCommandHandler : IRequestHandler<CreateSubscribeCommand>
	{
		private readonly JadooContext _context;

		public CreateSubscribeCommandHandler(JadooContext context)
		{
			_context = context;
		}

		public async Task Handle(CreateSubscribeCommand request, CancellationToken cancellationToken)
		{
			var subscribe = new Subscribe
			{
				Mail = request.Mail
			};
			await _context.Subscribes.AddAsync(subscribe);
			await _context.SaveChangesAsync();
		}
	}
}
