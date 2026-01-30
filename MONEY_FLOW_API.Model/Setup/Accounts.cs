namespace MONEY_FLOW_API.Model
{
    public class Accounts : BaseClass
    {
        public int? AccountId { get; set; }
        public string? AccountName { get; set; }
        public string? AccountType { get; set; }
        public string? Balance { get; set; }
    }
}