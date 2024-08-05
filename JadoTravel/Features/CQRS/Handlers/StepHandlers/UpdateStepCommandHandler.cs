using JadoTravel.DataAccess.Abstract;
using JadoTravel.DataAccess.Entities;
using JadoTravel.Features.CQRS.Commands.StepCommands;

namespace JadoTravel.Features.CQRS.Handlers.StepHandlers
{
	public class UpdateStepCommandHandler
	{
		private readonly IRepository<Step> _stepRepository;

		public UpdateStepCommandHandler(IRepository<Step> stepRepository)
		{
			_stepRepository = stepRepository;
		}
		public void Handle(UpdateStepCommand command)
		{
			var step = new Step
			{
				Description = command.Description,
				Icon = command.Icon,
				StepId = command.StepId,
				Title = command.Title
			};
			_stepRepository.Update(step);
		}
	}
}
