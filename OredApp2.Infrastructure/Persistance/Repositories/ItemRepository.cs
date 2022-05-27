using OrderApp2.Core.Application.Interfaces;
using OrderApp2.Core.Domain.Entities;
using OredApp2.Infrastructure.Persistance.DBContext;

namespace OredApp2.Infrastructure.Persistance.Repositories
{
    public class ItemRepository : GenericRepository<Item>, IItemRepository
    {
        private readonly DataContext _context;

        public ItemRepository(DataContext dataContext) : base(dataContext)
        {
            _context = dataContext;
        }

        public IQueryable<Item?> GetItemsByOrder(int OrderId)
        {
            var items = _context.OrderDetails.Where(d => d.OrderId == OrderId).Select(c => c.item);
            return items;
        }
    }
}