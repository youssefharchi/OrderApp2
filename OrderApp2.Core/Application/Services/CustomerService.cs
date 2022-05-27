using OrderApp2.Core.Application.Dto;
using OrderApp2.Core.Application.Interfaces;
using OrderApp2.Core.Domain.Entities;
using AutoMapper;

namespace OrderApp2.Core.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public bool CreateCustomer(CustomerDto newCustomer)
        {
            var customer = _mapper.Map<Customer>(newCustomer);
            return _customerRepository.Insert(customer);
        }

        public bool CustomerExists(int customerId)
        {
            return _customerRepository.Exists(customerId);
        }

        public bool DeleteCustomer(int deletedCustomerId)
        {
            return _customerRepository.Delete(deletedCustomerId);
        }

        public ICollection<CustomerDto> GetAllCustomers()
        {
            return _mapper.Map<ICollection<CustomerDto>>(_customerRepository.GetAll().ToList());
        }

        public CustomerDto GetCustomer(int customerId)
        {
            return _mapper.Map<CustomerDto>(_customerRepository.GetById(customerId));
        }

        public ICollection<CustomerDto> GetCustomersByItem(int itemId)
        {
            return _mapper.Map<ICollection<CustomerDto>>(_customerRepository.GetCustomersByItem(itemId).ToList());
        }

        public bool UpdateCustomer(CustomerDto updatedCustomer)
        {
            var customer = _mapper.Map<Customer>(updatedCustomer);
            return _customerRepository.Update(customer);
        }
    }
}