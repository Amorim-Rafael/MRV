using MediatR;
using MRV.Domain.Abstractions;
using MRV.Domain.Entities;

namespace MRV.Application.Leads.Queries.GetLeadsInvited
{
    public class GetLeadsInvitedQueryHandler : IRequestHandler<GetLeadsInvitedQuery, IEnumerable<Lead>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetLeadsInvitedQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Lead>> Handle(GetLeadsInvitedQuery request, CancellationToken cancellationToken)
        {
            var leadsInvited = await _unitOfWork.LeadRepository.GetLeadsInvited();
            return leadsInvited;
        }
    }
}
