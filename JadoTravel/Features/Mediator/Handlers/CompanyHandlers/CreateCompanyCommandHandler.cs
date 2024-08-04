using JadoTravel.DataAccess.Context;
using JadoTravel.DataAccess.Entities;
using JadoTravel.Features.Mediator.Commands.CompanyCommands;
using MediatR;

namespace JadoTravel.Features.Mediator.Handlers.CompanyHandlers
{
	public class CreateCompanyCommandHandler : IRequestHandler<CreateCompanyCommand>
	{
		private readonly JadooContext _context;

		public CreateCompanyCommandHandler(JadooContext context)
		{
			_context = context;
		}

		public async Task Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
		{
			var company = new Company
			{
				ImageUrl = request.ImageUrl
			};
			await _context.Companies.AddAsync(company);
			await _context.SaveChangesAsync();
		}
	}
}
