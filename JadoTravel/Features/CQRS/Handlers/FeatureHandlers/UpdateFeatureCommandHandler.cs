using JadoTravel.DataAccess.Abstract;
using JadoTravel.DataAccess.Entities;
using JadoTravel.Features.CQRS.Commands.FeatureCommands;

namespace JadoTravel.Features.CQRS.Handlers.FeatureHandlers
{
	public class UpdateFeatureCommandHandler
	{
		private readonly IRepository<Feature> _repository;

		public UpdateFeatureCommandHandler(IRepository<Feature> repository)
		{
			_repository = repository;
		}

		public void Handle(UpdateFeatureCommand command)
		{
			var feature = new Feature
			{
				FeatureId = command.FeatureId,
				ImageUrl = command.ImageUrl,
				LongDescription = command.LongDescription,
				ShortDescription = command.ShortDescription,
				Title = command.Title
			};
			_repository.Update(feature);

		}
	}
}
