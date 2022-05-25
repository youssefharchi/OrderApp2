namespace OrderApp2.Core.Domain.Entities
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int Quantity { get; set; }
        public string? TaxStatus { get; set; }
        public int OrderId { get; set; }
        public Order? order { get; set; }
        public int ItemId { get; set; }
        public Item? item { get; set; }
    }
}