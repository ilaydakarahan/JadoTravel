using JadoTravel.DataAccess.Abstract;
using JadoTravel.DataAccess.Entities;
using JadoTravel.Features.CQRS.Commands.StepCommands;

namespace JadoTravel.Features.CQRS.Handlers.StepHandlers
{
	public class RemoveStepCommandHandler
	{
		private readonly IRepository<Step> _repository;

		public RemoveStepCommandHandler(IRepository<Step> repository)
		{
			_repository = repository;
		}

		public void Handle(RemoveStepCommand removeStepCommand)
		{
			_repository.Delete(removeStepCommand.Id);
		}
	}
}
