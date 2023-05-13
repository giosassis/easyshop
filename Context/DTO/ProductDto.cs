using static EasyShop.Context.DTO.CategoryDto;
using static EasyShop.Context.DTO.SupplierDto;

namespace EasyShop.Context.DTO
{
    public class ProductDto
    {
        public class ProductCreateDto
        {
            public string? Prod_Name { get; set; }
            public string? Prod_Description { get; set; }
            public decimal Prod_PricePerUnity { get; set; }
            public int Prod_UnitsOnOrder { get; set; }
            public string? Prod_Unit_ImageUrl { get; set; }
            public string? Prod_Material { get; set; }
            public string? Prod_Color { get; set; }
            public string? Prod_Brand { get; set; }
            public string? Prod_Size { get; set; }
            public int Prod_Stock { get; set; }
            public int Cat_Id { get; set; }
            public int Supp_Id { get; set; }
        }

        public class ProductReadDto
        {
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
            public int Cat_Id { get; set; }
            public CategoryReadDTO? Category { get; set; }
            public int Supp_Id { get; set; }
            public ReadSupplierDto? Supplier { get; set; }
        }

        public class ProductUpdateDto
        {
            public string? Prod_Name { get; set; }
            public string? Prod_Description { get; set; }
            public decimal Prod_PricePerUnity { get; set; }
            public int Prod_UnitsOnOrder { get; set; }
            public string? Prod_Unit_ImageUrl { get; set; }
            public string? Prod_Material { get; set; }
            public string? Prod_Color { get; set; }
            public string? Prod_Brand { get; set; }
            public string? Prod_Size { get; set; }
            public int Prod_Stock { get; set; }
            public int Cat_Id { get; set; }
            public int Supp_Id { get; set; }
        }
    }
}
