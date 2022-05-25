namespace OrderApp2.Core.Domain.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerAddress { get; set; }
        public ICollection<Order>? Orders { get; set; } = new List<Order>();
    }
}