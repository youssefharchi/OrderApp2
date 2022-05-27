using OrderApp2.Core.Application.Dto;

namespace OrderApp2.Core.Application.Interfaces
{
    public interface ICustomerService
    {
        public bool CreateCustomer(CustomerDto newCustomer);

        public bool UpdateCustomer(CustomerDto updatedCustomer);

        public bool DeleteCustomer(int deletedCustomerId);

        public bool CustomerExists(int customerId);

        public CustomerDto GetCustomer(int customerId);

        public ICollection<CustomerDto> GetAllCustomers();

        public ICollection<CustomerDto> GetCustomersByItem(int itemId);
    }
}