﻿namespace OrderApp2.Core.Application.Dto
{
    public class OrderDto
    {
        public int OrderId { get; set; }
        public DateTime Created { get; set; }
        public string? Status { get; set; }
    }
}