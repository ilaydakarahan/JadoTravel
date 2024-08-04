using JadoTravel.DataAccess.Context;
using JadoTravel.Features.Mediator.Queries.SubscribeQueries;
using JadoTravel.Features.Mediator.Results.SubscribeResults;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace JadoTravel.Features.Mediator.Handlers.SubscribeHandlers
{
	public class GetSubscribeByIdQueryHandler : IRequestHandler<GetSubscribeByIdQuery, GetSubscribeByIdQueryResult>
	{
		private readonly JadooContext _context;

		public GetSubscribeByIdQueryHandler(JadooContext context)
		{
			_context = context;
		}

		public async Task<GetSubscribeByIdQueryResult> Handle(GetSubscribeByIdQuery request, CancellationToken cancellationToken)
		{
			var value = await _context.Subscribes.FirstOrDefaultAsync(x => x.SubscribeId == request.Id);
			var subscribe = new GetSubscribeByIdQueryResult
			{
				SubscribeId = value.SubscribeId,
				Mail = value.Mail
			};
			return subscribe;
		}
	}
}
