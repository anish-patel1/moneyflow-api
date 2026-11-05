namespace MONEY_FLOW_API.Model
{
    public class CategoryReconciliation
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? TransactionType { get; set; }
        public decimal TotalAmount { get; set; }
        public int TransactionCount { get; set; }
    }
}
