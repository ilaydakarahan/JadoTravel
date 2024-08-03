using JadoTravel.Features.Mediator.Results.TestimonialResults;
using MediatR;

namespace JadoTravel.Features.Mediator.Queries.TestimonialQueries
{
	public class GetTestimonialQuery : IRequest<List<GetTestimonialQueryResult>>
	{
	}
}
