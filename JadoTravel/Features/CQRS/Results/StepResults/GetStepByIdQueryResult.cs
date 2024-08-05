namespace JadoTravel.Features.CQRS.Results.StepResults
{
	public class GetStepByIdQueryResult
	{
		public int StepId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Icon { get; set; }
	}
}
