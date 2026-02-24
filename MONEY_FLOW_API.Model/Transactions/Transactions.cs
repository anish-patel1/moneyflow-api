namespace MONEY_FLOW_API.Model
{
    public class Transactions : BaseClass
    {
        public int? TransactionId { get; set; }
        public int? AccountId { get; set; }
        public string? AccountName { get; set; }
        public int? CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public int? InstallmentId { get; set; }
        public string? TransactionDate { get; set; }
        public decimal? Amount { get; set; }
        public string? TransactionType { get; set; }
        public string? Description { get; set; }

        // For Transfer
        public Guid? TransferGroupId { get; set; }
        public string? FromAccountName { get; set; }
        public string? ToAccountName { get; set; }
        public string? RowType { get; set; }
    }
}