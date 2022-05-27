using OrderApp2.Core.Domain.Entities;

namespace OrderApp2.Core.Application.Interfaces
{
    public interface IOrderDetailRepository : IGenericRepository<OrderDetail>
    {
        IQueryable<OrderDetail> GetDetailsByOrder(int OrderId);
    }
}