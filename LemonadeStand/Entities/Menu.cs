using LemonadeStand.Enums;

namespace LemonadeStand.Entities
{
    public class Menu
    {
        public  int ID { get; set; }
        public string? ItemTitle { get; set; }
        public string? ItemSize { get; set; }
        public decimal ItemPrice {  get; set; }
    }
}
