using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyShop.Model
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }
        public decimal? TotalPrice { get; set; }
        public int? Quantity { get; set; }

        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
        public virtual Customer? Cusomer { get; set; }

        [ForeignKey("OrderId")]
        public int OrderId { get; set; }
        public virtual Order? Order { get; set; }
    }
}
