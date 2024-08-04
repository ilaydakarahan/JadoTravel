using JadoTravel.DataAccess.Context;
using JadoTravel.Features.Mediator.Queries.SubscribeQueries;
using JadoTravel.Features.Mediator.Results.SubscribeResults;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace JadoTravel.Features.Mediator.Handlers.SubscribeHandlers
{
	public class GetSubscribeQueryHandler : IRequestHandler<GetSubscribeQuery, List<GetSubscribeQueryResult>>
	{
		private readonly JadooContext _context;

		public GetSubscribeQueryHandler(JadooContext context)
		{
			_context = context;
		}

		public async Task<List<GetSubscribeQueryResult>> Handle(GetSubscribeQuery request, CancellationToken cancellationToken)
		{
			var values = await _context.Subscribes.ToListAsync();
			var list = (from x in values
						select new GetSubscribeQueryResult
						{
							Mail = x.Mail,
							SubscribeId = x.SubscribeId
						}).ToList();
			return list;
		}
	}
}
