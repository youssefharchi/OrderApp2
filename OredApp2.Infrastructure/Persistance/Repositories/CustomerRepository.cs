using OrderApp2.Core.Application.Interfaces;
using OrderApp2.Core.Domain.Entities;
using OredApp2.Infrastructure.Persistance.DBContext;

namespace OredApp2.Infrastructure.Persistance.Reposit
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _context;

        public CustomerRepository(DataContext dataContext)
        {
            _context = dataContext;
        }

        public bool CreateCustomer(Customer customer)
        {
            _context.Add(customer);
            return Save();
        }

        public bool CustomerExists(int id)
        {
            return _context.Customers.Any(c => c.CustomerId == id);
        }

        public bool DeleteCustomer(Customer customer)
        {
            _context.Customers.Remove(customer);
            return Save();
        }

        public Customer? GetCustomer(int CustomerId)
        {
            return _context.Customers.FirstOrDefault(c => c.CustomerId == CustomerId);
        }

        public IQueryable<Customer> GetCustomers()
        {
            return _context.Customers.OrderBy(c => c.CustomerId);
        }

        public IQueryable<Customer> GetCustomersByItem(int ItemId)
        {
            var customers = from details in _context.OrderDetails
                            join order in _context.Orders on details.OrderId equals order.OrderId
                            where details.ItemId == ItemId
                            select order.Customer;
            return customers;
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }

        public bool UpdateCustomer(Customer customer)
        {
            _context.Update(customer);
            return Save();
        }
    }
}