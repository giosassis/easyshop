namespace EasyShop.Context.DTO
{
    public class CartDto
    {
        public class CartReadDTO
        {
            public int CartId { get; set; }
            public int ProductId { get; set; }
            public double TotalPrice { get; set; }
            public int CustomerId { get; set; }
            public int OrderId { get; set; }
        }

        public class CartCreateDTO
        {
            public int ProductId { get; set; }
            public double TotalPrice { get; set; }
            public int CustomerId { get; set; }
            public int OrderId { get; set; }
        }

        public class CartUpdateDTO
        {
            public int CartId { get; set; }
            public int ProductId { get; set; }
            public double TotalPrice { get; set; }
            public int CustomerId { get; set; }
            public int OrderId { get; set; }
        }
    }
}
