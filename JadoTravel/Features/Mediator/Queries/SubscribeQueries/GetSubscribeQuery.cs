using JadoTravel.Features.Mediator.Results.SubscribeResults;
using MediatR;

namespace JadoTravel.Features.Mediator.Queries.SubscribeQueries
{
	public class GetSubscribeQuery : IRequest<List<GetSubscribeQueryResult>>
	{
	}
}
