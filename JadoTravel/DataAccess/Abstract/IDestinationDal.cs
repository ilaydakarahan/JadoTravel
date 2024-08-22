using JadoTravel.DataAccess.Entities;

namespace JadoTravel.DataAccess.Abstract
{
	public interface IDestinationDal : IRepository<Destination>
	{
		List<Destination> GetDestination3List();
		Destination GetLastDestination();
	}
}
