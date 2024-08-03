using JadoTravel.DataAccess.Abstract;
using JadoTravel.DataAccess.Entities;
using JadoTravel.Features.CQRS.Queries.FeatureQueries;
using JadoTravel.Features.CQRS.Results.FeatureResults;

namespace JadoTravel.Features.CQRS.Handlers.FeatureHandlers
{
	public class GetFeatureByIdQueryHandler
	{
		private readonly IRepository<Feature> _repository;

		public GetFeatureByIdQueryHandler(IRepository<Feature> repository)
		{
			_repository = repository;
		}

		public GetFeatureByIdQueryResult Handle(GetFeatureByIdQuery query)
		{
			var value = _repository.GetById(query.Id);
			GetFeatureByIdQueryResult result = new GetFeatureByIdQueryResult();

			result.Title= value.Title;
			result.FeatureId = value.FeatureId;
			result.ShortDescription= value.ShortDescription;
			result.LongDescription= value.LongDescription;
			result.ImageUrl = value.ImageUrl;
			return result;

		}
	}
}
