using JadoTravel.DataAccess.Abstract;
using JadoTravel.DataAccess.Entities;
using JadoTravel.Features.CQRS.Results.DestinationResults;

namespace JadoTravel.Features.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationQueryHandler
    {
        private readonly IRepository<Destination> _repository;

        public GetDestinationQueryHandler(IRepository<Destination> repository)
        {
            _repository = repository;
        }

        public List<GetDestinationQueryResult> Handle()
        {
            var values = _repository.GetList();

            List<GetDestinationQueryResult> result = (from x in values
                                                      select new GetDestinationQueryResult
                                                      {
                                                          DestinationId = x.DestinationId,
                                                          City = x.City,
                                                          Duration = x.Duration,
                                                          Image = x.Image,
                                                          Price = x.Price
                                                      }).ToList();

            return result;
        }


    }
}
