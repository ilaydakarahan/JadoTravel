using JadoTravel.DataAccess.Abstract;
using JadoTravel.DataAccess.Entities;
using JadoTravel.Features.CQRS.Commands.DestinationCommands;

namespace JadoTravel.Features.CQRS.Handlers.DestinationHandlers
{
    public class RemoveDestinationCommandHandler
    {
        private readonly IRepository<Destination> _repository;

        public RemoveDestinationCommandHandler(IRepository<Destination> repository)
        {
            _repository = repository;
        }

        public void Handle(RemoveDestinationCommand command)
        {
            _repository.Delete(command.Id);
        }

    }
}
