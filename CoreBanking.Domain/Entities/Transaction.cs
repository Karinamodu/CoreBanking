using CoreBanking.Domain.Enums;
using CoreBanking.Domain.ValueObjects;

namespace CoreBanking.Domain.Entities
{
    public class Transaction
    {
        public Guid TransactionId { get; private set; }
        public Guid AccountId { get; private set; }
        public TransactionType Type { get; private set; }
        public Money Amount { get; private set; }
        public string Description { get; private set; }
        public DateTime TimeStamp { get; private set; }
        public string Reference { get; private set; }

        //requiewd for EFCore
        private Transaction() { }

        public Transaction(Guid accountId, TransactionType type, Money amount, string description)
        {
            TransactionId = TransactionId;
            AccountId = accountId;
            Type = type;
            Amount = amount;
            Description = description ?? throw new ArgumentException(nameof(description));
            TimeStamp = DateTime.UtcNow;
            Reference = GenerateReference();
        }

        private string GenerateReference()
        {
            return $"{TimeStamp:yyyyMMddHHmmss}-{TransactionId.ToString().Substring(0, 8)}";
        }
    }
}
