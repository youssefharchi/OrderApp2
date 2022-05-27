using AutoMapper;
using OrderApp2.Core.Application.Dto;
using OrderApp2.Core.Application.Interfaces;
using OrderApp2.Core.Domain.Entities;

namespace OrderApp2.Core.Application.Services
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IOrderDetailRepository _OrderDetailRepository;
        private readonly IMapper _mapper;

        public OrderDetailService(IOrderDetailRepository OrderDetailRepository, IMapper mapper)
        {
            _OrderDetailRepository = OrderDetailRepository;
            _mapper = mapper;
        }

        public ICollection<OrderDetailDto> GetDetailsByOrder(int OrderId)
        {
            return _mapper.Map<ICollection<OrderDetailDto>>(_OrderDetailRepository.GetDetailsByOrder(OrderId).ToList());
        }

        public bool CreateOrderDetail(OrderDetailDto newOrderDetail)
        {
            var OrderDetail = _mapper.Map<OrderDetail>(newOrderDetail);
            return _OrderDetailRepository.Insert(OrderDetail);
        }

        public bool DeleteOrderDetail(int deletedOrderDetailId)
        {
            return _OrderDetailRepository.Delete(deletedOrderDetailId);
        }

        public ICollection<OrderDetailDto> GetAllOrderDetails()
        {
            return _mapper.Map<ICollection<OrderDetailDto>>(_OrderDetailRepository.GetAll().ToList());
        }

        public OrderDetailDto GetOrderDetail(int OrderDetailId)
        {
            return _mapper.Map<OrderDetailDto>(_OrderDetailRepository.GetById(OrderDetailId));
        }

        public bool OrderDetailExists(int OrderDetailId)
        {
            return _OrderDetailRepository.Exists(OrderDetailId);
        }

        public bool UpdateOrderDetail(OrderDetailDto updatedOrderDetail)
        {
            return _OrderDetailRepository.Update(_mapper.Map<OrderDetail>(updatedOrderDetail));
        }
    }
}