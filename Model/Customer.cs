using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyShop.Model
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ContactName { get; set; }
        public string? CPF { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public DateTime? Birthday { get; set; }
        [ForeignKey("PersonalInfoId")]
        public int PersonalInfoId { get; set; }
        public virtual PersonalInfo? PersonalInfo { get; set; }

    }
}
