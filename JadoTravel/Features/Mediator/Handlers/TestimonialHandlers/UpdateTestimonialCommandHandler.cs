using JadoTravel.DataAccess.Context;
using JadoTravel.DataAccess.Entities;
using JadoTravel.Features.Mediator.Commands.TestimonialCommands;
using MediatR;

namespace JadoTravel.Features.Mediator.Handlers.TestimonialHandlers
{
	public class UpdateTestimonialCommandHandler : IRequestHandler<UpdateTestimonialCommand>
	{
		private readonly JadooContext _context;

		public UpdateTestimonialCommandHandler(JadooContext context)
		{
			_context = context;
		}

		public async Task Handle(UpdateTestimonialCommand request, CancellationToken cancellationToken)
		{
			var testimonial = new Testimonial
			{
				TestimonialId = request.TestimonialId,
				City = request.City,
				Description = request.Description,
				NameSurname = request.NameSurname,
				ImageUrl = request.ImageUrl
			};
			_context.Update(testimonial);
			await _context.SaveChangesAsync();
		}
	}
}
