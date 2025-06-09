using MediatR;
using MRV.Domain.Entities;

namespace MRV.Application.Leads.Commands
{
    public class UpdateLeadCommand : IRequest<Lead>
    {
        public int Id { get; set; }
    }
}
