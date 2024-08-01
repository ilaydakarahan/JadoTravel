namespace JadoTravel.Features.CQRS.Commands.DestinationCommands
{
    public class CreateDestinationCommand
    {
        public string Image { get; set; }
        public string City { get; set; }
        public string Duration { get; set; }
        public decimal Price { get; set; }
    }
}
