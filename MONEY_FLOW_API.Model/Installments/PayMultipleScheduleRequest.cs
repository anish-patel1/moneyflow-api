namespace MONEY_FLOW_API.Model
{
    public class PayMultipleScheduleRequest : BaseClass
    {
        public int InstallmentId { get; set; }
        public string ScheduleIds { get; set; } = string.Empty; // Comma-separated: "31,32"
        public int AccountId { get; set; }
        public string TransactionDate { get; set; } = null!;
        public decimal Amount { get; set; }
        public decimal ExtraCharges { get; set; }
        public string? ChargesDescription { get; set; }
        public string? Description { get; set; }
    }
}
