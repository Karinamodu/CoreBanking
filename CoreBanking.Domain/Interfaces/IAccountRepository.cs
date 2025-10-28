using CoreBanking.Domain.Entities;
using CoreBanking.Domain.ValueObjects;
using CoreBanking.Domain.Models;

namespace CoreBanking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        AccountModel GetById(int id);
        IEnumerable<AccountModel> GetAll();
        void Add(AccountModel account);

        Task<Account> GetByIdAsync(Guid accountId);
        Task<Account> GetByAccountNumberAsync(AccountNumber accountNumber);
        Task<IEnumerable<Account>> GetByCustomerid(Guid customerId);
        Task AddAsync(Account account);
        Task UpdateAsync(Account account);
        Task<bool> AccountNumberEsistAsync(AccountNumber accountNumber);
    }
}
