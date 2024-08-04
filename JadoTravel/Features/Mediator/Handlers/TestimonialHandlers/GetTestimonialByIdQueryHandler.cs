using JadoTravel.DataAccess.Context;
using JadoTravel.Features.Mediator.Queries.TestimonialQueries;
using JadoTravel.Features.Mediator.Results.TestimonialResults;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace JadoTravel.Features.Mediator.Handlers.TestimonialHandlers
{
	public class GetTestimonialByIdQueryHandler : IRequestHandler<GetTestimonialByIdQuery, GetTestimonialByIdQueryResult>
	{
		private readonly JadooContext _context;

		public GetTestimonialByIdQueryHandler(JadooContext context)
		{
			_context = context;
		}

		public async Task<GetTestimonialByIdQueryResult> Handle(GetTestimonialByIdQuery request, CancellationToken cancellationToken)
		{
			var value = await _context.Testimonials.FirstOrDefaultAsync(x => x.TestimonialId == request.Id);

			var testimonial = new GetTestimonialByIdQueryResult
			{
				City = value.City,
				Description = value.Description,
				ImageUrl = value.ImageUrl,
				NameSurname = value.NameSurname,
				TestimonialId = value.TestimonialId
			};
			return testimonial;
		}
	}
}
