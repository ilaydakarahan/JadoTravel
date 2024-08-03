namespace JadoTravel.Features.CQRS.Results.FeatureResults
{
	public class GetFeatureQueryResult
	{
		public int FeatureId { get; set; }
		public string Title { get; set; }
		public string ShortDescription { get; set; }
		public string LongDescription { get; set; }
		public string ImageUrl { get; set; }
	}
}
