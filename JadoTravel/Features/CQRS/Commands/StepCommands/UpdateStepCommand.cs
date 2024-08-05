namespace JadoTravel.Features.CQRS.Commands.StepCommands
{
	public class UpdateStepCommand
	{
		public int StepId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Icon { get; set; }
	}
}
