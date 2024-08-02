using JadoTravel.DataAccess.Context;
using JadoTravel.DataAccess.Entities;
using JadoTravel.Features.Mediator.Commands.ServiceCommands;
using MediatR;

namespace JadoTravel.Features.Mediator.Handlers.ServiceHandlers
{
    public class UpdateServiceCommandHandler : IRequestHandler<UpdateServiceCommand>
    {
        private readonly JadooContext _context;

        public UpdateServiceCommandHandler(JadooContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateServiceCommand request, CancellationToken cancellationToken)
        {
            var service = new Service
            {
                ServiceId = request.ServiceId,
                Description = request.Description,
                Title = request.Title,
                Icon = request.Icon
            };

            _context.Update(service);
            await _context.SaveChangesAsync();
        }
    }
}
