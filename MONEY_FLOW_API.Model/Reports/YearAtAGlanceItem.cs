namespace MONEY_FLOW_API.Model
{
    public class YearAtAGlanceItem
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public string Frequency { get; set; } = null!;
        public decimal Jan { get; set; }
        public decimal Feb { get; set; }
        public decimal Mar { get; set; }
        public decimal Apr { get; set; }
        public decimal May { get; set; }
        public decimal Jun { get; set; }
        public decimal Jul { get; set; }
        public decimal Aug { get; set; }
        public decimal Sep { get; set; }
        public decimal Oct { get; set; }
        public decimal Nov { get; set; }
        public decimal Dec { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal MonthlyAverage { get; set; }
    }
}
