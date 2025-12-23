namespace BUDGET.User
{
    public class Income
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string Description   { get; set; }
        public Decimal  Amount { get; set; }
        public DateTime  Date { get; set; }
    }
}
