namespace JadoTravel.Features.CQRS.Queries.StepQueries
{
	public class GetStepByIdQuery
	{
        public int Id { get; set; }

		public GetStepByIdQuery(int id)
		{
			Id = id;
		}
	}
}
