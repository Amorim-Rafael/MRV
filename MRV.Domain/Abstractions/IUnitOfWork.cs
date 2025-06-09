namespace MRV.Domain.Abstractions
{
    public interface IUnitOfWork
    {
        ILeadRepository LeadRepository { get; }

        Task CommitAsync();
    }
}
