namespace CoreBanking.Domain.ValueObjects
{
    public record Money
    {
        public decimal Amount { get; }
        public string Currency { get; } = "NGN";

        public Money(decimal amount, string currency = "NGN")
        {
            if (amount <= 0)
                throw new ArgumentException("Money cannot be negeative");

            Amount = amount;
            Currency = currency;
        }

        public static Money operator +(Money a, Money b)
        {
            if (a.Currency != b.Currency)
                throw new InvalidOperationException("Cannot add different currencies");

            return new Money(a.Amount + b.Amount, a.Currency);
        }

        public static Money operator -(Money a, Money b)
        {
            if (a.Currency != b.Currency)
                throw new InvalidOperationException("Cannot add different currencies");

            return new Money(a.Amount - b.Amount, a.Currency);
        }
    }
}
