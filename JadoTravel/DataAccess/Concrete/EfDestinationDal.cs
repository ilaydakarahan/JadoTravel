using JadoTravel.DataAccess.Abstract;
using JadoTravel.DataAccess.Context;
using JadoTravel.DataAccess.Entities;
using JadoTravel.DataAccess.Repositories;

namespace JadoTravel.DataAccess.Concrete
{
	public class EfDestinationDal : Repository<Destination>, IDestinationDal
	{
		private readonly JadooContext _context;

		public EfDestinationDal(JadooContext context) : base(context) 
		{
			_context = context;
		}

		public List<Destination> GetDestination3List()
		{
			return _context.Destinations.OrderByDescending(x=>x.DestinationId).Take(3).ToList();
		}

		public Destination GetLastDestination()
		{
			return _context.Destinations.OrderByDescending(x => x.DestinationId).Take(1).FirstOrDefault();
		}
	}
}
