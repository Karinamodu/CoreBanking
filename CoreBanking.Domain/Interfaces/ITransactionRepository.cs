using CoreBanking.Domain.Entities;

namespace CoreBanking.Domain.Interfaces
{
    public interface ITransactionRepository
    {
        Task<IEnumerable<Transaction>> GetByAccountIdAsync(Guid accountId);
        Task AddAsync(Transaction transaction);
    }
}
