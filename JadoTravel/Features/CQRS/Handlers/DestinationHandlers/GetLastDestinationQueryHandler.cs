using JadoTravel.DataAccess.Abstract;
using JadoTravel.Features.CQRS.Results.DestinationResults;

namespace JadoTravel.Features.CQRS.Handlers.DestinationHandlers
{
	public class GetLastDestinationQueryHandler
	{
		private readonly IDestinationDal _destinationDal;

		public GetLastDestinationQueryHandler(IDestinationDal destinationDal)
		{
			_destinationDal = destinationDal;
		}

		public GetLastDestinationQueryResult Handle()
		{
			var value = _destinationDal.GetLastDestination();

			GetLastDestinationQueryResult result = new GetLastDestinationQueryResult();
			result.Duration = value.Duration;
			result.DestinationId = value.DestinationId;
			result.Image = value.Image;
			result.City = value.City;
			result.Price = value.Price;
			return result;
		}
	}
}
