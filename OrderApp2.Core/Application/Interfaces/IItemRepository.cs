using OrderApp2.Core.Domain.Entities;

namespace OrderApp2.Core.Application.Interfaces
{
    public interface IItemRepository
    {
        IQueryable<Item> GetItems();

        IQueryable<Item> GetItemsByOrder(int OrderId);

        Item GetItem(int id);

        bool CreateItem(Item item);

        bool UpdateItem(Item item);

        bool DeleteItem(Item Item);

        bool Save();

        bool ItemExists(int Id);
    }
}