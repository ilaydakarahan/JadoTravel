using JadoTravel.DataAccess.Abstract;
using JadoTravel.DataAccess.Entities;
using JadoTravel.Features.CQRS.Commands.DestinationCommands;

namespace JadoTravel.Features.CQRS.Handlers.DestinationHandlers
{
    public class UpdateDestinationCommandHandler
    {
        private readonly IRepository<Destination> _repository;

        public UpdateDestinationCommandHandler(IRepository<Destination> repository)
        {
            _repository = repository;
        }

        public void Handle(UpdateDestinationCommand command)
        {
            var destination = new Destination
            {
                City = command.City,
                DestinationId = command.DestinationId,
                Duration = command.Duration,
                Image = command.Image,
                Price = command.Price
            };

            _repository.Update(destination);
        }
    }
}
