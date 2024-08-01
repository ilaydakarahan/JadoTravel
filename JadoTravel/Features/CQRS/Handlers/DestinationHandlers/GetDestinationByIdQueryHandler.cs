using JadoTravel.DataAccess.Abstract;
using JadoTravel.DataAccess.Entities;
using JadoTravel.Features.CQRS.Queries.DestinationQueries;
using JadoTravel.Features.CQRS.Results.DestinationResults;

namespace JadoTravel.Features.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIdQueryHandler
    {
        private readonly IRepository<Destination> _repository;

        public GetDestinationByIdQueryHandler(IRepository<Destination> repository)
        {
            _repository = repository;
        }

        public GetDestinationByIdQueryResult Handle(GetDestinationByIdQuery query)
        {
            var values = _repository.GetById(query.Id);
            GetDestinationByIdQueryResult result = new GetDestinationByIdQueryResult();

            result.City = values.City;
            result.DestinationId = values.DestinationId;
            result.Duration = values.Duration;
            result.Image = values.Image;
            result.Price = values.Price;
            return result;
        }
    }
}
