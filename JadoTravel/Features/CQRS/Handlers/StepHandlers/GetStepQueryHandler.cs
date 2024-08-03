using JadoTravel.DataAccess.Abstract;
using JadoTravel.DataAccess.Entities;
using JadoTravel.Features.CQRS.Results.StepResults;

namespace JadoTravel.Features.CQRS.Handlers.StepHandlers
{
	public class GetStepQueryHandler
	{
		private readonly IRepository<Step> _repository;

		public GetStepQueryHandler(IRepository<Step> repository)
		{
			_repository = repository;
		}

		public List<GetStepQueryResult> Handle()
		{
			var values = _repository.GetList();
			List<GetStepQueryResult> result = (from x in values
											   select new GetStepQueryResult
											   {
												   Description = x.Description,
												   Icon = x.Icon,
												   StepId = x.StepId,
												   Title = x.Title
											   }).ToList();
			return result;
		}
	}
}
