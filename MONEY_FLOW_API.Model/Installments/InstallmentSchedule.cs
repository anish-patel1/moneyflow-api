namespace MONEY_FLOW_API.Model
{
    public class InstallmentSchedule : BaseClass
    {
        public int? InstallmentScheduleId { get; set; }
        public int? InstallmentId { get; set; }
        public int? InstallmentNo { get; set; }
        public string? DueDate { get; set; }
        public string? DueDateFormatted { get; set; }
        public string? PaymentStartDate { get; set; }
        public string? PaymentStartDateFormatted { get; set; }
        public decimal? OpeningBalance { get; set; }
        public decimal? ScheduledAmount { get; set; }
        public decimal? Principal { get; set; }
        public decimal? Interest { get; set; }
        public decimal? InterestRate { get; set; }
        public decimal? ExtraCharges { get; set; }
        public string? ChargesDescription { get; set; }
        public decimal? ClosingBalance { get; set; }
        public string? ScheduleStatus { get; set; }
        public string? PaidDate { get; set; }
        public string? PaidDateFormatted { get; set; }
        public decimal? PaidAmount { get; set; }
        public int? TransactionId { get; set; }
        public string? Notes { get; set; }

        // Related Properties
        public int? AccountId { get; set; }
        public string? AccountName { get; set; }

        // For Bulk Operations
        public string? ScheduleJson { get; set; }
    }
}
