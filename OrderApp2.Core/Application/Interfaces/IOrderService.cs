using OrderApp2.Core.Application.Dto;

namespace OrderApp2.Core.Application.Interfaces
{
    public interface IOrderService
    {
        public bool CreateOrder(OrderDto newOrder);

        public bool UpdateOrder(OrderDto updatedOrder);

        public bool DeleteOrder(int deletedOrderId);

        public bool OrderExists(int OrderId);

        public OrderDto GetOrder(int OrderId);

        public ICollection<OrderDto> GetAllOrders();

        public ICollection<OrderDto?> GetOrderByItem(int ItemId);

        public ICollection<OrderDto> GetOrdersByCustomer(int customerId);
    }
}