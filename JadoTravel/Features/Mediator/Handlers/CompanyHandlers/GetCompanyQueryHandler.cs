using JadoTravel.DataAccess.Context;
using JadoTravel.Features.Mediator.Queries.CompanyQueries;
using JadoTravel.Features.Mediator.Results.CompanyResults;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace JadoTravel.Features.Mediator.Handlers.CompanyHandlers
{
	public class GetCompanyQueryHandler : IRequestHandler<GetCompanyQuery, List<GetCompanyQueryResult>>
	{
		private readonly JadooContext _context;

		public GetCompanyQueryHandler(JadooContext context)
		{
			_context = context;
		}

		public async Task<List<GetCompanyQueryResult>> Handle(GetCompanyQuery request, CancellationToken cancellationToken)
		{
			var values = await _context.Companies.ToListAsync();
			var companyList = (from x in values
							   select new GetCompanyQueryResult
							   {
								   CompanyId = x.CompanyId,
								   ImageUrl = x.ImageUrl
							   }).ToList();
			return companyList;
		}
	}
}
