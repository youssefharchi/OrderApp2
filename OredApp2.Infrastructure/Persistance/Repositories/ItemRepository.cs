using OrderApp2.Core.Application.Interfaces;
using OrderApp2.Core.Domain.Entities;
using OredApp2.Infrastructure.Persistance.DBContext;

namespace OredApp2.Infrastructure.Persistance.Reposit
{
    public class ItemRepository : IItemRepository
    {
        private readonly DataContext _dataContext;

        public ItemRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public bool CreateItem(Item item)
        {
            throw new NotImplementedException();
        }

        public bool DeleteItem(Item Item)
        {
            throw new NotImplementedException();
        }

        public Item GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Item> GetItems()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Item> GetItemsByOrder(int OrderId)
        {
            throw new NotImplementedException();
        }

        public bool ItemExists(int Id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool UpdateItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}