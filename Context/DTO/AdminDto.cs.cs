namespace EasyShop.Context.DTO
{
    public class AdminDTO
    {
        public class AdminReadDTO
        {
            public int Id { get; set; }
            public string? AdmFirstName { get; set; }
            public string? AdmLastName { get; set; }
            public string? AdmEmail { get; set; }
        }

        public class AdminCreateDTO
        {
            public string? AdmFirstName { get; set; }
            public string? AdmLastName { get; set; }
            public string? AdmEmail { get; set; }
            public string? AdmPassword { get; set; }
        }

        public class AdminUpdateDTO
        {
            public int Id { get; set; }
            public string? AdmFirstName { get; set; }
            public string? AdmLastName { get; set; }
            public string? AdmEmail { get; set; }
        }
    }
}
