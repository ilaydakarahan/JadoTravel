using JadoTravel.DataAccess.Abstract;
using JadoTravel.DataAccess.Entities;
using JadoTravel.Features.CQRS.Queries.StepQueries;
using JadoTravel.Features.CQRS.Results.StepResults;

namespace JadoTravel.Features.CQRS.Handlers.StepHandlers
{
	public class GetStepByIdQueryHandler
	{
		private readonly IRepository<Step> _repository;

		public GetStepByIdQueryHandler(IRepository<Step> repository)
		{
			_repository = repository;
		}

		public GetStepByIdQueryResult Handle(GetStepByIdQuery query)
		{
			var values = _repository.GetById(query.Id);
			GetStepByIdQueryResult result = new GetStepByIdQueryResult();

			result.Title = values.Title;
			result.StepId = values.StepId;
			result.Description = values.Description;
			result.Icon = values.Icon;
			return result;
		}
	}
}
