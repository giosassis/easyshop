using EasyShop.Model;

namespace EasyShop.Context.DTO
{
    public class CategoryDto
    {
        public class CategoryReadDTO
        {
            public int Cat_Id { get; set; }
            public string? Cat_Name { get; set; }
            public string? Cat_Description { get; set; }
            public ICollection<ProductDto> Products { get; set; }
        }

        public class CategoryCreateDTO
        {
            public string? Cat_Name { get; set; }
            public string? Cat_Description { get; set; }
        }

        public class CategoryUpdateDTO
        {
            public int Cat_Id { get; set; }
            public string? Cat_Name { get; set; }
            public string? Cat_Description { get; set; }
        }
    }
}
