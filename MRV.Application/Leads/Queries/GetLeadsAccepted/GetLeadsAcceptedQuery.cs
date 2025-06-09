using MediatR;
using MRV.Domain.Entities;

namespace MRV.Application.Leads.Queries.GetLeadsAccepted
{
    public class GetLeadsAcceptedQuery : IRequest<IEnumerable<Lead>>
    {
    }
}
