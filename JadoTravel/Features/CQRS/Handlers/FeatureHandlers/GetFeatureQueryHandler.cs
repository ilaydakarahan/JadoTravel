using JadoTravel.DataAccess.Abstract;
using JadoTravel.DataAccess.Entities;
using JadoTravel.Features.CQRS.Results.FeatureResults;

namespace JadoTravel.Features.CQRS.Handlers.FeatureHandlers
{
	public class GetFeatureQueryHandler
	{
		private readonly IRepository<Feature> _repository;

		public GetFeatureQueryHandler(IRepository<Feature> repository)
		{
			_repository = repository;
		}

		public List<GetFeatureQueryResult> Handle()
		{
			var values = _repository.GetList();

			List<GetFeatureQueryResult> result = (from x in values
												  select new GetFeatureQueryResult
												  {
													  FeatureId = x.FeatureId,
													  ImageUrl = x.ImageUrl,
													  LongDescription = x.LongDescription,
													  ShortDescription = x.ShortDescription,
													  Title = x.Title
												  }).ToList();
			return result;
		}
	}
}
