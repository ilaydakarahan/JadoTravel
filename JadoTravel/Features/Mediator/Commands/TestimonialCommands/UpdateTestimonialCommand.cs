using MediatR;

namespace JadoTravel.Features.Mediator.Commands.TestimonialCommands
{
    public class UpdateTestimonialCommand : IRequest
    {
        public int TestimonialId { get; set; }
        public string NameSurname { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string ImageUrl { get; set; }
    }
}
