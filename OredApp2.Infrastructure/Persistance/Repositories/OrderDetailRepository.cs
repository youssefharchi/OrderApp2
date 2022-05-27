using OrderApp2.Core.Application.Interfaces;
using OrderApp2.Core.Domain.Entities;
using OredApp2.Infrastructure.Persistance.DBContext;

namespace OredApp2.Infrastructure.Persistance.Repositories
{
    public class OrderDetailRepository : GenericRepository<OrderDetail>, IOrderDetailRepository
    {
        private readonly DataContext _dataContext;

        public OrderDetailRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public IQueryable<OrderDetail> GetDetailsByOrder(int OrderId)
        {
            var details = _dataContext.OrderDetails.Where(d => d.OrderId == OrderId);
            return details;
        }
    }
}