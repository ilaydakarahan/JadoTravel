using MediatR;

namespace JadoTravel.Features.Mediator.Commands.TestimonialCommands
{
    public class CreateTestimonialCommand : IRequest
    {
        public string NameSurname { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string ImageUrl { get; set; }
    }
}
