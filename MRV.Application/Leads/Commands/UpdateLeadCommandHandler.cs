using MediatR;
using MRV.Domain.Abstractions;
using MRV.Domain.Entities;

namespace MRV.Application.Leads.Commands
{
    public class UpdateLeadCommandHandler : IRequestHandler<UpdateLeadCommand, Lead>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateLeadCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Lead> Handle(UpdateLeadCommand request, CancellationToken cancellationToken)
        {
            var lead = await _unitOfWork.LeadRepository.GetLeadById(request.Id);

            if (lead is null)
                throw new InvalidOperationException("Lead not found");

            lead.UpdateStatus(true);
            _unitOfWork.LeadRepository.UpdateLead(lead);
            await _unitOfWork.CommitAsync();

            return lead;
        }
    }
}
