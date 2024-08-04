using JadoTravel.DataAccess.Context;
using JadoTravel.DataAccess.Entities;
using JadoTravel.Features.Mediator.Commands.SubscribeCommands;
using MediatR;

namespace JadoTravel.Features.Mediator.Handlers.SubscribeHandlers
{
	public class UpdateSubscribeCommandHandler : IRequestHandler<UpdateSubscribeCommand>
	{
		private readonly JadooContext _context;

		public UpdateSubscribeCommandHandler(JadooContext context)
		{
			_context = context;
		}

		public async Task Handle(UpdateSubscribeCommand request, CancellationToken cancellationToken)
		{
			var subscribe = new Subscribe
			{
				Mail = request.Mail,
				SubscribeId = request.SubscribeId
			};
			_context.Update(subscribe);
			await _context.SaveChangesAsync();
		}
	}
}
