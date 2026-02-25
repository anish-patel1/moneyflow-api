namespace MONEY_FLOW_API.Model
{
    public class Transfer : BaseClass
    {
        public Guid? TransferGroupId { get; set; }
        public int? FromAccountId { get; set; }
        public int? ToAccountId { get; set; }
        public decimal? Amount { get; set; }
        public string? TransferDate { get; set; }
        public string? Description { get; set; }
    }
}
