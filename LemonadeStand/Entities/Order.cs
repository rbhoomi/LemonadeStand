namespace LemonadeStand.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerEmail { get; set; }
        public string? CustomerPhone { get; set; }
        public Decimal TotalAmount { get; set; }
        public DateTime? CreatedDate { get; set; } = default(DateTime?);
    }
}
