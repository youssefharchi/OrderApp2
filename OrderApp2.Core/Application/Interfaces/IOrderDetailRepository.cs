using OrderApp2.Core.Domain.Entities;

namespace OrderApp2.Core.Application.Interfaces
{
    public interface IOrderDetailRepository
    {
        OrderDetail GetOrderDetail(int DetailId);

        IQueryable<OrderDetail> GetAllDetails();

        IQueryable<OrderDetail> GetDetailsByOrder(int OrderId);

        bool CreateDetail(OrderDetail orderDetail, int itemId, int orderId);

        bool UpdateDetail(OrderDetail orderDetail, int itemId, int orderId);

        bool DeleteDetail(OrderDetail detail);

        bool Save();

        bool OrderDetailExists(int id);
    }
}