using System.ComponentModel.DataAnnotations;

namespace EasyShop.Model
{
    public class BillingInfo
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
