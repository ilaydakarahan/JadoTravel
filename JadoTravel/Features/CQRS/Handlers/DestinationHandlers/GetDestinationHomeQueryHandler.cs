using JadoTravel.DataAccess.Abstract;
using JadoTravel.Features.CQRS.Results.DestinationResults;

namespace JadoTravel.Features.CQRS.Handlers.DestinationHandlers
{
	public class GetDestinationHomeQueryHandler
	{
		private readonly IDestinationDal _destination;

		public GetDestinationHomeQueryHandler(IDestinationDal destination)
		{
			_destination = destination;
		}
		public List<GetDestinationHomeQueryResult> Handle()
		{
			var value = _destination.GetDestination3List();

			List<GetDestinationHomeQueryResult> results = (from x in value select new GetDestinationHomeQueryResult
			{
				City = x.City,
				DestinationId = x.DestinationId,
				Duration = x.Duration,
				Image = x.Image,
				Price = x.Price
			}).ToList();
			return results;

		}
	}
}
