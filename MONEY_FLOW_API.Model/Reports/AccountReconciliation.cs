namespace MONEY_FLOW_API.Model
{
    public class AccountReconciliation
    {
        public int AccountId { get; set; }
        public string? AccountName { get; set; }
        public string? AccountType { get; set; }
        public decimal OpeningBalance { get; set; }
        public decimal Inflow { get; set; }
        public decimal Outflow { get; set; }
        public decimal ExternalInflow { get; set; }
        public decimal ExternalOutflow { get; set; }
        public decimal TransferIn { get; set; }
        public decimal TransferOut { get; set; }
        public decimal ClosingBalance { get; set; }
        public decimal NetChange { get; set; }
        public int TransactionCount { get; set; }
    }
}
