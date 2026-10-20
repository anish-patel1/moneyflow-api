namespace MONEY_FLOW_API.Model
{
    public class SavingsSummaryItem
    {
        public int Month { get; set; }
        public string MonthName { get; set; } = null!;
        public decimal Income { get; set; }
        public decimal Expense { get; set; }
        public decimal Transfers { get; set; }
        public decimal NetSavings { get; set; }
        public decimal SavingsRate { get; set; }
        public decimal CumulativeSavings { get; set; }
    }
}
