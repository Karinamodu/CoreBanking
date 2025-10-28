using CoreBanking.Domain.Entities;

namespace CoreBanking.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        Task<Customer> GetByIdAsync(Guid customerId);
        Task<IEnumerable<Customer>> GetAllAsync();
        Task AddAsync(Customer customer);
        Task UpdateAsync(Customer customer);
        Task<bool> ExistAsync(Guid customerId);
    }
}
