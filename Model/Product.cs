namespace EasyShop.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Products")]
    public class Product
    {
        [Key]
        public int Prod_Id { get; set; }
        public string? Prod_Name { get; set; }
        public string? Prod_Description { get; set; }
        public decimal Prod_PricePerUnity { get; set; }
        public decimal Prod_PriceWithDiscount { get; set; }
        public int Prod_UnitsOnOrder { get; set; }
        public string? Prod_Unit_ImageUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? Prod_Material { get; set; }
        public string? Prod_Color { get; set; }
        public string? Prod_Brand { get; set; }
        public string? Prod_Size { get; set; }
        public int Prod_Stock { get; set; }
        [ForeignKey("CategoryId")]
        public int Cat_Id { get; set; }
        public virtual Category? Category { get; set; }

        [ForeignKey("SupplierId")]
        public int Supp_Id { get; set; }
        public virtual Supplier? Supplier { get; set; }
    }
}
