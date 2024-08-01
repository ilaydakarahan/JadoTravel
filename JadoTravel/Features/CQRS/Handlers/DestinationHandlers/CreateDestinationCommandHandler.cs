using JadoTravel.DataAccess.Abstract;
using JadoTravel.DataAccess.Entities;
using JadoTravel.Features.CQRS.Commands.DestinationCommands;

namespace JadoTravel.Features.CQRS.Handlers.DestinationHandlers
{
    public class CreateDestinationCommandHandler
    {
        private readonly IRepository<Destination> _repository;

        public CreateDestinationCommandHandler(IRepository<Destination> repository)
        {
            _repository = repository;
        }

        public void Handle(CreateDestinationCommand command)
        {
            var destination = new Destination
            {
                City = command.City,
                Duration = command.Duration,
                Image = command.Image,
                Price = command.Price
            };

            _repository.Create(destination);
        }

    }
}
