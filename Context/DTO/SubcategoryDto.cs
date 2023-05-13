namespace EasyShop.Context.DTO
{
    public class SubcategoryDto
    {
        public class SubcategoryCreateDto
        {
            public string? Subcat_Name { get; set; }
            public string? Subcat_Description { get; set; }
            public int CategoryId { get; set; }
        }

        public class SubcategoryReadDto
        {
            public int Subcat_Id { get; set; }
            public string? Subcat_Name { get; set; }
            public string? Subcat_Description { get; set; }
            public int CategoryId { get; set; }
            public string? CategoryName { get; set; }
        }

        public class SubcategoryUpdateDto
        {
            public string? Subcat_Name { get; set; }
            public string? Subcat_Description { get; set; }
            public int CategoryId { get; set; }
        }
    }
}
