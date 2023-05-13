using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyShop.Model
{
    public class Supplier
    {
        [Key]
        public int Supp_Id { get; set; }
        public string? ContactFirstName { get; set; }
        public string? ContactLastFName { get; set; }
        public string? ContactTitle { get; set; }
        [ForeignKey("PersonalInfoId")]
        public int PersonalInfoId { get; set; }
        public virtual PersonalInfo? PersonalInfo { get; set; }
    }
}
