namespace MONEY_FLOW_API.Model
{
    public class Installments : BaseClass
    {
        public int? InstallmentId { get; set; }
        public string? InstallmentName { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? DurationMonths { get; set; }
        public decimal? MonthlyAmount { get; set; }
        public string? StartDate { get; set; }
        public int? BillingDay { get; set; }
        public string? Description { get; set; }

        // Other
        public int? PaidMonths { get; set; }
        public int? RemainingMonths { get; set; }
    }
}
