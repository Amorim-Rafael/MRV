using MRV.Domain.Abstractions;
using MRV.Infrastructure.Context;

namespace MRV.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private ILeadRepository? _leadRepository;
        private readonly SqlDbContext _dbContext;

        public UnitOfWork(SqlDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ILeadRepository LeadRepository
        {
            get 
            { 
                return _leadRepository = _leadRepository ?? new LeadRepository(_dbContext);
            }
        }

        public async Task CommitAsync() => await _dbContext.SaveChangesAsync();
    }
}
