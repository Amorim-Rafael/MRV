using MediatR;
using MRV.Domain.Abstractions;
using MRV.Domain.Entities;

namespace MRV.Application.Leads.Queries.GetLeadsAccepted
{
    public class GetLeadsAcceptedQueryHandler : IRequestHandler<GetLeadsAcceptedQuery, IEnumerable<Lead>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetLeadsAcceptedQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Lead>> Handle(GetLeadsAcceptedQuery request, CancellationToken cancellationToken)
        {
            var leadsAccepted = await _unitOfWork.LeadRepository.GetLeadsAccepted();
            return leadsAccepted;
        }
    }
}
