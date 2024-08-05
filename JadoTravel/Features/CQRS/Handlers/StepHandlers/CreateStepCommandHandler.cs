using JadoTravel.DataAccess.Abstract;
using JadoTravel.DataAccess.Entities;
using JadoTravel.Features.CQRS.Commands.StepCommands;

namespace JadoTravel.Features.CQRS.Handlers.StepHandlers
{
	public class CreateStepCommandHandler
	{
		private readonly IRepository<Step> _repository;

		public CreateStepCommandHandler(IRepository<Step> repository)
		{
			_repository = repository;
		}

		public void Handle(CreateStepCommand command)
		{
			var step = new Step
			{
				Description = command.Description,
				Title = command.Title,
				Icon = command.Icon,

			};
			_repository.Create(step);
		}
	}
}
