using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyShop.Model
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string? OrderNumber { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public int? Freight { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        [ForeignKey("PersonalInfoId")]
        public int PersonalInfoId { get; set; }
        public PersonalInfo? PersonalInfo { get; set; }
        [ForeignKey("BillingInfoId")]
        public int BillingInfoId { get; set; }
        public BillingInfo? BillingInfo { get; set; }
    }
}
