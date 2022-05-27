using OrderApp2.Core.Domain.Entities;
using OrderApp2.Core.Application.Interfaces;

namespace OrderApp2.Core.Application.Interfaces
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        IQueryable<Customer> GetCustomersByItem(int ItemId);
    }
}