using EasyShop.Model;

namespace EasyShop.Context.DTO
{
    public class OrderDto
    {
        public class OrderReadDTO
        {
            public int OrderId { get; set; }
            public int OrderNumber { get; set; }
            public int CustomerId { get; set; }
            public decimal TotalPrice { get; set; }
            public DateTime? OrderDate { get; set; }
            public PersonalInfo? PersonalInfo { get; set; }
            public BillingInfo? BillingInfo { get; set; }
        }

        public class OrderCreateDTO
        {
            public int OrderNumber { get; set; }
            public int CustomerId { get; set; }
            public int Freight { get; set; }
            public decimal TotalPrice { get; set; }
            public DateTime? OrderDate { get; set; }
            public int PersonalInfoId { get; set; }
            public int BillingInfoId { get; set; }
        }

        public class OrderUpdateDTO
        {
            public int OrderId { get; set; }
            public int OrderNumber { get; set; }
            public int CustomerId { get; set; }
            public int Freight { get; set; }
            public decimal TotalPrice { get; set; }
            public DateTime? OrderDate { get; set; }
            public int PersonalInfoId { get; set; }
            public int BillingInfoId { get; set; }
        }
    }
}
