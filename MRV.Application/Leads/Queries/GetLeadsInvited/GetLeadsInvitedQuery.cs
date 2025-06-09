using MediatR;
using MRV.Domain.Entities;

namespace MRV.Application.Leads.Queries.GetLeadsInvited
{
    public class GetLeadsInvitedQuery : IRequest<IEnumerable<Lead>>
    {
    }
}
