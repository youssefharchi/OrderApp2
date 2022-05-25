﻿namespace OrderApp2.Core.Domain.Entities
{
    public class Item
    {
        public int ItemId { get; set; }
        public string? ItemName { get; set; }
        public float ShipWeight { get; set; }
        public string? Description { get; set; }
        public ICollection<OrderDetail> orderDetails { get; set; } = new List<OrderDetail>();
    }
}