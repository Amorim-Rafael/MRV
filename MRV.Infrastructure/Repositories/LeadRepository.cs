using Microsoft.EntityFrameworkCore;
using MRV.Domain.Abstractions;
using MRV.Domain.Entities;
using MRV.Infrastructure.Context;

namespace MRV.Infrastructure.Repositories
{
    public class LeadRepository : ILeadRepository
    {
        protected readonly SqlDbContext _dbContext;

        public LeadRepository(SqlDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Lead>> GetLeadsAccepted()
        {
            var leadsAccepted = await _dbContext.Leads.Where(l => l.Accepted).ToListAsync();
            return leadsAccepted ?? Enumerable.Empty<Lead>();
        }

        public async Task<IEnumerable<Lead>> GetLeadsInvited()
        {
            var leadsInvited = await _dbContext.Leads.Where(l => !l.Accepted).ToListAsync();
            return leadsInvited ?? Enumerable.Empty<Lead>();
        }

        public async Task<Lead> GetLeadById(int id)
        {
            var lead = await _dbContext.Leads.FindAsync(id);

            if (lead is null)
                throw new InvalidOperationException("Lead not found");

            return lead;
        }

        public void UpdateLead(Lead lead)
        {
            if (lead is null)
                throw new ArgumentNullException(nameof(lead));

            _dbContext.Leads.Update(lead);
        }
    }
}
