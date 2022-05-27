using OrderApp2.Core.Application.Dto;

namespace OrderApp2.Core.Application.Interfaces
{
    public interface IOrderDetailService
    {
        public bool CreateOrderDetail(OrderDetailDto newOrderDetail);

        public bool UpdateOrderDetail(OrderDetailDto updatedOrderDetail);

        public bool DeleteOrderDetail(int deletedOrderDetailId);

        public bool OrderDetailExists(int OrderDetailId);

        public OrderDetailDto GetOrderDetail(int OrderDetailId);

        public ICollection<OrderDetailDto> GetAllOrderDetails();

        public ICollection<OrderDetailDto> GetDetailsByOrder(int OrderId);
    }
}