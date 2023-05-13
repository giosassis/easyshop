namespace EasyShop.Context.DTO
{
    public class SupplierDto
    {
        public class ReadSupplierDto
        {
            public int Supp_Id { get; set; }
            public string? ContactFirstName { get; set; }
            public string? ContactLastFName { get; set; }
            public string? ContactTitle { get; set; }
            public int PersonalInfoId { get; set; }
            public PersonalInfoDto PersonalInfo { get; set; }
        }

        public class CreateSupplierDto
        {
            public string? ContactFirstName { get; set; }
            public string? ContactLastFName { get; set; }
            public string? ContactTitle { get; set; }
            public int PersonalInfoId { get; set; }
        }

        public class UpdateSupplierDto
        {
            public string? ContactFirstName { get; set; }
            public string? ContactLastFName { get; set; }
            public string? ContactTitle { get; set; }
            public int PersonalInfoId { get; set; }
        }
    }
}
