using OrderApp2.Core.Application.Interfaces;
using OrderApp2.Core.Domain.Entities;
using OredApp2.Infrastructure.Persistance.DBContext;

namespace OredApp2.Infrastructure.Persistance.Reposit
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly DataContext _dataContext;

        public OrderDetailRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public bool CreateDetail(OrderDetail orderDetail, int itemId, int orderId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteDetail(OrderDetail detail)
        {
            throw new NotImplementedException();
        }

        public IQueryable<OrderDetail> GetAllDetails()
        {
            throw new NotImplementedException();
        }

        public IQueryable<OrderDetail> GetDetailsByOrder(int OrderId)
        {
            throw new NotImplementedException();
        }

        public OrderDetail GetOrderDetail(int DetailId)
        {
            throw new NotImplementedException();
        }

        public bool OrderDetailExists(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool UpdateDetail(OrderDetail orderDetail, int itemId, int orderId)
        {
            throw new NotImplementedException();
        }
    }
}