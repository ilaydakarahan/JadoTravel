using JadoTravel.DataAccess.Context;
using JadoTravel.DataAccess.Entities;
using JadoTravel.Features.Mediator.Commands.TestimonialCommands;
using MediatR;

namespace JadoTravel.Features.Mediator.Handlers.TestimonialHandlers
{
    public class CreateTestimonialCommandHandler : IRequestHandler<CreateTestimonialCommand>
    {
        private readonly JadooContext _context;

        public CreateTestimonialCommandHandler(JadooContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateTestimonialCommand request, CancellationToken cancellationToken)
        {
            var testimonial = new Testimonial
            {
                City = request.City,
                Description = request.Description,
                ImageUrl = request.ImageUrl,
                NameSurname = request.NameSurname
            };
            await _context.Testimonials.AddAsync(testimonial);
            await _context.SaveChangesAsync();
        }
    }
}
