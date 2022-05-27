using OrderApp2.Core.Domain.Entities;

namespace OrderApp2.Core.Application.Interfaces
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        IQueryable<Order?> GetOrderByItem(int ItemId);

        IQueryable<Order> GetOrdersByCustomer(int customerId);
    }
}