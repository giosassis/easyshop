namespace EasyShop.Context.DTO
{
    public class BillingInfoDto
    {
        public class BillingInfoReadDTO
        {
            public int Id { get; set; }
            public string? Name { get; set; }
        }

        public class BillingInfoCreateDTO
        {
            public string? Name { get; set; }
        }

        public class BillingInfoUpdateDTO
        {
            public int Id { get; set; }
            public string? Name { get; set; }
        }
    }
}
