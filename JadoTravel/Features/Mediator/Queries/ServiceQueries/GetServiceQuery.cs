using JadoTravel.Features.Mediator.Results.ServiceResults;
using MediatR;

namespace JadoTravel.Features.Mediator.Queries.ServiceQueries
{
    public class GetServiceQuery : IRequest<List<GetServiceQueryResult>>
    {
        //içinde bir parametre olmicak. Dönüş tipini yani sınıfı belirtiyoruz.
    }
}
