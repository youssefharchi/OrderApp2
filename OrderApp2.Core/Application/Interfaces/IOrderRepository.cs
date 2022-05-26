using OrderApp2.Core.Domain.Entities;

namespace OrderApp2.Core.Application.Interfaces
{
    public interface IOrderRepository
    {
        IQueryable<Order> GetOrders();

        Order GetOrder(int id);

        bool OrderExists(int id);

        bool CreateOrder(int CustomerId, Order order);

        bool UpdateOrder(int CustomerId, Order order);

        bool DeleteOrder(Order Order);

        bool Save();

        ICollection<Order> GetOrderByItem(int ItemId);

        ICollection<Order> GetOrdersByCustomer(int customerId);
    }
}