namespace EasyShop.Context.DTO
{
    public class PersonalInfoDto
    {
        public class PersonalInfoReadDto
        {
            public int PersonalId { get; set; }
            public string? Phone { get; set; }
            public string? Email { get; set; }
            public string? City { get; set; }
            public string? State { get; set; }
            public string? Country { get; set; }
            public string? Address { get; set; }
            public string? PostalCode { get; set; }
            public int ResidenceHouseNumber { get; set; }
        }

        public class PersonalInfoCreateDto
        {
            public string? Phone { get; set; }
            public string? Email { get; set; }
            public string? City { get; set; }
            public string? State { get; set; }
            public string? Country { get; set; }
            public string? Address { get; set; }
            public string? PostalCode { get; set; }
            public string? ResidenceHouse { get; set; }
        }

        public class PersonalInfoUpdateDto
        {
            public string? Phone { get; set; }
            public string? Email { get; set; }
            public string? City { get; set; }
            public string? State { get; set; }
            public string? Country { get; set; }
            public string? Address { get; set; }
            public string? PostalCode { get; set; }
            public string? ResidenceHouse { get; set; }
        }
    }
}
