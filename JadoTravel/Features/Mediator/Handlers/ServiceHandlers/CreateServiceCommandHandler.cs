using JadoTravel.DataAccess.Context;
using JadoTravel.DataAccess.Entities;
using JadoTravel.Features.Mediator.Commands.ServiceCommands;
using MediatR;

namespace JadoTravel.Features.Mediator.Handlers.ServiceHandlers
{
    public class CreateServiceCommandHandler : IRequestHandler<CreateServiceCommand>
    {
        private readonly JadooContext _context;

        public CreateServiceCommandHandler(JadooContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateServiceCommand request, CancellationToken cancellationToken)
        {
            var service = new Service
            {
                Description = request.Description,
                Title = request.Title,
                Icon = request.Icon
            };
            await _context.Services.AddAsync(service);
            await _context.SaveChangesAsync();
        }
    }
}
