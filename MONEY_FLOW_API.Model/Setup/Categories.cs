namespace MONEY_FLOW_API.Model
{
    public class Categories : BaseClass
    {
        public int? CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? CategoryType { get; set; }
        public string? Frequency { get; set; }
        public bool? IsExcludeFromIncome { get; set; } = false;
        public bool? IsSystem { get; set; }
    }
}