namespace EasyShop.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Category")]
    public class Category
    {
        [Key]
        public int Cat_Id { get; set; }
        public string? Cat_Name { get; set; }
        public string? Cat_Description { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
