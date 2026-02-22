namespace MONEY_FLOW_API.Model
{
    public class Transfer : BaseClass
    {
        public string? TransferGroupId { get; set; }
        public int? FromAccountId { get; set; }
        public int? ToAccountId { get; set; }
        public string? Amount { get; set; }
        public string? TransferDate { get; set; }
        public string? Description { get; set; }
    }
}
