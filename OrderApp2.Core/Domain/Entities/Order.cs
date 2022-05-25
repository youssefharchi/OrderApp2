﻿namespace OrderApp2.Core.Domain.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime Created { get; set; }
        public string? Status { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = new();
        public ICollection<OrderDetail>? Details { get; set; } = new List<OrderDetail>();
    }
}