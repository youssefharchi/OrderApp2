using OrderApp2.Core.Application.Interfaces;
using OrderApp2.Core.Domain.Entities;
using OredApp2.Infrastructure.Persistance.DBContext;

namespace OredApp2.Infrastructure.Persistance.Reposit
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext _dataContext;

        public OrderRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public bool CreateOrder(int CustomerId, Order order)
        {
            throw new NotImplementedException();
        }

        public bool DeleteOrder(Order Order)
        {
            throw new NotImplementedException();
        }

        public Order GetOrder(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Order> GetOrderByItem(int ItemId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Order> GetOrders()
        {
            throw new NotImplementedException();
        }

        public ICollection<Order> GetOrdersByCustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public bool OrderExists(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool UpdateOrder(int CustomerId, Order order)
        {
            throw new NotImplementedException();
        }
    }
}