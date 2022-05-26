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
            return _customerRepository.CreateCustomer(customer);
        }

        public bool CustomerExists(int customerId)
        {
            return _customerRepository.CustomerExists(customerId);
        }

        public bool DeleteCustomer(int deletedCustomerId)
        {
            var customer = _customerRepository.GetCustomer(deletedCustomerId);
            if (customer != null)
                return _customerRepository.DeleteCustomer(customer);

            return false;
        }

        public ICollection<CustomerDto> GetAllCustomers()
        {
            return _mapper.Map<ICollection<CustomerDto>>(_customerRepository.GetCustomers().ToList());
        }

        public CustomerDto GetCustomer(int customerId)
        {
            return _mapper.Map<CustomerDto>(_customerRepository.GetCustomer(customerId));
        }

        public ICollection<CustomerDto> GetCustomersByItem(int itemId)
        {
            return _mapper.Map<ICollection<CustomerDto>>(_customerRepository.GetCustomersByItem(itemId).ToList());
        }

        public bool UpdateCustomer(int customerId, CustomerDto updatedCustomer)
        {
            var customer = _mapper.Map<Customer>(updatedCustomer);
            customer.CustomerId = customerId;
            return _customerRepository.UpdateCustomer(customer);
        }
    }
}