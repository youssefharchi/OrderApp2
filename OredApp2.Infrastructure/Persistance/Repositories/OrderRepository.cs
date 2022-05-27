using OrderApp2.Core.Application.Interfaces;
using OrderApp2.Core.Domain.Entities;
using OredApp2.Infrastructure.Persistance.DBContext;

namespace OredApp2.Infrastructure.Persistance.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        private readonly DataContext _dataContext;

        public OrderRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public IQueryable<Order?> GetOrderByItem(int ItemId)
        {
            var orders = _dataContext.OrderDetails.Where(c => c.ItemId == ItemId).Select(o => o.order);
            return orders;
        }

        public IQueryable<Order> GetOrdersByCustomer(int customerId)
        {
            var orders = _dataContext.Orders.Where(o => o.CustomerId == customerId);
            return orders;
        }
    }
}