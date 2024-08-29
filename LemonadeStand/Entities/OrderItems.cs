using System.ComponentModel.DataAnnotations.Schema;

namespace LemonadeStand.Entities
{
    public class OrderItems
    {
        public int Id { get; set; }
        [ForeignKey("Order")]
        public int OrderID { get; set; }
        public string?  MenuItemDescription { get; set; }
        

    }
}
