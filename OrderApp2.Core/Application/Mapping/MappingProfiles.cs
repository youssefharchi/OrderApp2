using AutoMapper;
using OrderApp2.Core.Application.Dto;
using OrderApp2.Core.Domain.Entities;

namespace OrderApp2.Core.Application.Mapping
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<Item, ItemDto>().ReverseMap();
            CreateMap<OrderDetail, OrderDetailDto>().ReverseMap();
        }
    }
}