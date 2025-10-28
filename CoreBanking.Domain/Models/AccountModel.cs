namespace CoreBanking.Domain.Models
{
    public class AccountModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public string Currency { get; set; }
    }
}
