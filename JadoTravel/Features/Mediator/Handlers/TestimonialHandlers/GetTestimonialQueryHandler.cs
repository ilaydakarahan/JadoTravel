using JadoTravel.DataAccess.Context;
using JadoTravel.Features.Mediator.Queries.TestimonialQueries;
using JadoTravel.Features.Mediator.Results.TestimonialResults;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace JadoTravel.Features.Mediator.Handlers.TestimonialHandlers
{
	public class GetTestimonialQueryHandler : IRequestHandler<GetTestimonialQuery, List<GetTestimonialQueryResult>>
	{
		private readonly JadooContext _context;

		public GetTestimonialQueryHandler(JadooContext context)
		{
			_context = context;
		}

		public async Task<List<GetTestimonialQueryResult>> Handle(GetTestimonialQuery request, CancellationToken cancellationToken)
		{
			var values = await _context.Testimonials.ToListAsync();
			//OrderByDescending(x=>x.TestimonialId).Take(3).
			var testimonialList = (from x in values
								   select new GetTestimonialQueryResult
								   {
									   City = x.City,
									   Description = x.Description,
									   NameSurname = x.NameSurname,
									   TestimonialId = x.TestimonialId,
									   ImageUrl = x.ImageUrl
								   }).ToList();
			return testimonialList;
		}
	}
}
