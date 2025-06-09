using MRV.Domain.Entities;

namespace MRV.Domain.Abstractions
{
    public interface ILeadRepository
    {
        Task<IEnumerable<Lead>> GetLeadsInvited();
        Task<IEnumerable<Lead>> GetLeadsAccepted();
        Task<Lead> GetLeadById(int id);
        void UpdateLead(Lead lead);
    }
}
