using OrderApp2.Core.Domain.Entities;

namespace OrderApp2.Core.Application.Interfaces
{
    public interface ICustomerRepository
    {
        IQueryable<Customer> GetCustomers();

        Customer? GetCustomer(int id);

        bool CreateCustomer(Customer customer);

        bool UpdateCustomer(Customer customer);

        bool DeleteCustomer(Customer customer);

        IQueryable<Customer> GetCustomersByItem(int ItemId);

        bool Save();

        bool CustomerExists(int id);
    }
}