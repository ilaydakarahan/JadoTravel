using JadoTravel.DataAccess.Context;
using JadoTravel.Features.Mediator.Commands.CompanyCommands;
using MediatR;

namespace JadoTravel.Features.Mediator.Handlers.CompanyHandlers
{
	public class RemoveCompanyCommandHandler : IRequestHandler<RemoveCompanyCommand>
	{
		private readonly JadooContext _context;

		public RemoveCompanyCommandHandler(JadooContext context)
		{
			_context = context;
		}

		public async Task Handle(RemoveCompanyCommand request, CancellationToken cancellationToken)
		{
			var value = await _context.Companies.FindAsync(request.Id);
			_context.Remove(value);
			await _context.SaveChangesAsync();
		}
	}
}
