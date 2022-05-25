namespace OrderApp2.Core.Application.Dto
{
    public class OrderDetailDto
    {
        public int OrderDetailId { get; set; }
        public int Quantity { get; set; }
        public string? TaxStatus { get; set; }
    }
}