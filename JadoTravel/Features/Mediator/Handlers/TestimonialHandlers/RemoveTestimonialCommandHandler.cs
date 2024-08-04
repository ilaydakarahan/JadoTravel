using JadoTravel.DataAccess.Context;
using JadoTravel.Features.Mediator.Commands.TestimonialCommands;
using MediatR;

namespace JadoTravel.Features.Mediator.Handlers.TestimonialHandlers
{
	public class RemoveTestimonialCommandHandler : IRequestHandler<RemoveTestimonialCommand>
	{
		private readonly JadooContext _context;

		public RemoveTestimonialCommandHandler(JadooContext context)
		{
			_context = context;
		}

		public async Task Handle(RemoveTestimonialCommand request, CancellationToken cancellationToken)
		{
			var value = await _context.Testimonials.FindAsync(request.Id);
			_context.Remove(value);
			await _context.SaveChangesAsync();
		}
	}
}
