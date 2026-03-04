namespace MONEY_FLOW_API.Model
{
    public class DashboardSummary
    {
        public decimal TotalBalance { get; set; }
        public decimal MonthlyIncome { get; set; }
        public decimal MonthlyExpense { get; set; }
        public decimal NetFlow { get; set; }
    }
}
