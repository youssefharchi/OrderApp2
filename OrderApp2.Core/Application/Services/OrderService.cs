using AutoMapper;
using OrderApp2.Core.Application.Dto;
using OrderApp2.Core.Application.Interfaces;
using OrderApp2.Core.Domain.Entities;

namespace OrderApp2.Core.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _OrderRepository;
        private readonly IMapper _mapper;

        public OrderService(IOrderRepository OrderRepository, IMapper mapper)
        {
            _OrderRepository = OrderRepository;
            _mapper = mapper;
        }

        public ICollection<OrderDto?> GetOrderByItem(int ItemId)
        {
            return _mapper.Map<ICollection<OrderDto>>(_OrderRepository.GetOrderByItem(ItemId).ToList());
        }

        public ICollection<OrderDto> GetOrdersByCustomer(int customerId)
        {
            return _mapper.Map<ICollection<OrderDto>>(_OrderRepository.GetOrdersByCustomer(customerId).ToList());
        }

        public bool CreateOrder(OrderDto newOrder)
        {
            var Order = _mapper.Map<Order>(newOrder);
            return _OrderRepository.Insert(Order);
        }

        public bool DeleteOrder(int deletedOrderId)
        {
            return _OrderRepository.Delete(deletedOrderId);
        }

        public ICollection<OrderDto> GetAllOrders()
        {
            return _mapper.Map<ICollection<OrderDto>>(_OrderRepository.GetAll().ToList());
        }

        public OrderDto GetOrder(int OrderId)
        {
            return _mapper.Map<OrderDto>(_OrderRepository.GetById(OrderId));
        }

        public bool OrderExists(int OrderId)
        {
            return _OrderRepository.Exists(OrderId);
        }

        public bool UpdateOrder(OrderDto updatedOrder)
        {
            return _OrderRepository.Update(_mapper.Map<Order>(updatedOrder));
        }
    }
}