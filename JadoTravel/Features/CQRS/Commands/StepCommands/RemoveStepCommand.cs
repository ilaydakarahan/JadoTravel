namespace JadoTravel.Features.CQRS.Commands.StepCommands
{
	public class RemoveStepCommand
	{
        public int Id { get; set; }

		public RemoveStepCommand(int id)
		{
			Id = id;
		}
	}
}
