namespace MONEY_FLOW_API.Model
{
    public class BaseClass
    {
        public int? UserId { get; set; }
        public string? Status { get; set; }
        public string? StatusText { get; set; }
        public int? CreatedBy { get; set; }
        public string? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public string? UpdatedDate { get; set; }
        public string? FromDate { get; set; }
        public string? ToDate { get; set; }
        public int? IsExist { get; set; }
    }
}
