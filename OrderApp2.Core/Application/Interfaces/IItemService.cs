using OrderApp2.Core.Application.Dto;

namespace OrderApp2.Core.Application.Interfaces
{
    public interface IItemService
    {
        public bool CreateItem(ItemDto newItem);

        public bool UpdateItem(ItemDto updatedItem);

        public bool DeleteItem(int deletedItemId);

        public bool ItemExists(int ItemId);

        public ItemDto GetItem(int ItemId);

        public ICollection<ItemDto> GetAllItems();

        public ICollection<ItemDto> GetItemsByOrder(int OrderId);
    }
}