namespace MONEY_FLOW_API.Model
{
    public class Budgets : BaseClass
    {
        public int? BudgetId { get; set; }
        public int? CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? CategoryType { get; set; }
        public string? Frequency { get; set; }
        public int? BudgetYear { get; set; }
        public int? BudgetMonth { get; set; }
        public decimal? BudgetAmount { get; set; }
        public decimal? ActualSpent { get; set; }
        public decimal? Variance { get; set; }
    }
}
