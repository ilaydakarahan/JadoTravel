namespace JadoTravel.Features.CQRS.Commands.FeatureCommands
{
	public class UpdateFeatureCommand
	{
		public int FeatureId { get; set; }
		public string Title { get; set; }
		public string ShortDescription { get; set; }
		public string LongDescription { get; set; }
		public string ImageUrl { get; set; }
	}
}
