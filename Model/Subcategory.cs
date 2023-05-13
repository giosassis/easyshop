using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyShop.Model
{
    public class Subcategory
    {
        [Key]
        public int Subcat_Id { get; set; }
        public string? Subcat_Name { get; set; }
        public string? Subcat_Description { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
