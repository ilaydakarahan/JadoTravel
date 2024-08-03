using JadoTravel.Features.Mediator.Results.CompanyResults;
using MediatR;

namespace JadoTravel.Features.Mediator.Queries.CompanyQueries
{
	public class GetCompanyQuery : IRequest<List<GetCompanyQueryResult>>
	{
	}
}
