using LemonadeStand.Entities;

namespace LemonadeStand.Model
{
    public class CreateOrderViewModel
    {
        public string? CustomerName { get; set; }
        public string? CustomerEmail { get; set; }
        public string? CustomerPhone { get; set; }
        public Decimal TotalAmount { get; set; }
        public required ICollection<OrderItems> OrderedItemsList { get; set; }
    }
}
