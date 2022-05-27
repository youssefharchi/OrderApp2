using OrderApp2.Core.Domain.Entities;

namespace OrderApp2.Core.Application.Interfaces
{
    public interface IItemRepository : IGenericRepository<Item>
    {
        IQueryable<Item?> GetItemsByOrder(int OrderId);
    }
}