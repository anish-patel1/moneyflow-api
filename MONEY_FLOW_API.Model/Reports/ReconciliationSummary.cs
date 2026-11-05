namespace MONEY_FLOW_API.Model
{
    public class ReconciliationSummary
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal TotalOpeningBalance { get; set; }
        public decimal TotalInflow { get; set; }
        public decimal TotalOutflow { get; set; }
        public decimal TotalTransfers { get; set; }
        public decimal TotalAccountInflow { get; set; }
        public decimal TotalAccountOutflow { get; set; }
        public decimal NetFlow { get; set; }
        public decimal TotalClosingBalance { get; set; }
        public decimal SavingsRate { get; set; }
    }
}
