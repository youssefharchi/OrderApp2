using OrderApp2.Core.Application.Interfaces;
using OrderApp2.Core.Domain.Entities;
using OredApp2.Infrastructure.Persistance.DBContext;

namespace OredApp2.Infrastructure.Persistance.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        private readonly DataContext _context;

        public CustomerRepository(DataContext dataContext) : base(dataContext)
        {
            _context = dataContext;
        }

        public IQueryable<Customer> GetCustomersByItem(int ItemId)
        {
            var customers = _context.OrderDetails.Where(details => details.ItemId == ItemId).Select(o => o.order.Customer);
            return customers;
        }
    }
}