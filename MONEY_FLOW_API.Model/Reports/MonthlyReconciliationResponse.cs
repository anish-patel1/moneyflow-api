namespace MONEY_FLOW_API.Model
{
    public class MonthlyReconciliationResponse
    {
        public ReconciliationSummary Summary { get; set; } = new();
        public List<AccountReconciliation> Accounts { get; set; } = new();
        public List<CategoryReconciliation> Categories { get; set; } = new();
    }
}
