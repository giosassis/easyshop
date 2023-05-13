using System.ComponentModel.DataAnnotations;

namespace EasyShop.Model
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string? AdmFirstName { get; set; }
        public string? AdmLastName { get; set;}
        public string? AdmEmail { get; set;}
        public string? AdmPassword { get; set;}
    }
}
