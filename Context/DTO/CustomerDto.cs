using EasyShop.Model;

namespace EasyShop.Context.DTO
{
    public class CustomerDto
    {
        public class CustomerReadDTO
        {
            public int CustomerId { get; set; }
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
            public string? CPF { get; set; }
            public string? ContactName { get; set; }
            public string? Username { get; set; }
            public DateTime Birthday { get; set; }
            public PersonalInfo? PersonalInfo { get; set; }
        }

        public class CustomerCreateDTO
        {
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
            public string? ContactName { get; set; }
            public string? CPF { get; set; }
            public string? Username { get; set; }
            public string? Password { get; set; }
            public DateTime Birthday { get; set; }
            public int PersonalInfoId { get; set; }
        }

        public class CustomerUpdateDTO
        {
            public int CustomerId { get; set; }
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
            public string? ContactName { get; set; }
            public string? Username { get; set; }
            public string? Password { get; set; }
            public DateTime Birthday { get; set; }
            public int PersonalInfoId { get; set; }
        }
    }
}
