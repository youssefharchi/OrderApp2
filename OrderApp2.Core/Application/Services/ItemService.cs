using AutoMapper;
using OrderApp2.Core.Application.Dto;
using OrderApp2.Core.Application.Interfaces;
using OrderApp2.Core.Domain.Entities;

namespace OrderApp2.Core.Application.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;
        private readonly IMapper _mapper;

        public ItemService(IItemRepository itemRepository, IMapper mapper)
        {
            _itemRepository = itemRepository;
            _mapper = mapper;
        }

        public bool CreateItem(ItemDto newItem)
        {
            var item = _mapper.Map<Item>(newItem);
            return _itemRepository.Insert(item);
        }

        public bool DeleteItem(int deletedItemId)
        {
            return _itemRepository.Delete(deletedItemId);
        }

        public ICollection<ItemDto> GetAllItems()
        {
            return _mapper.Map<ICollection<ItemDto>>(_itemRepository.GetAll().ToList());
        }

        public ItemDto GetItem(int ItemId)
        {
            return _mapper.Map<ItemDto>(_itemRepository.GetById(ItemId));
        }

        public ICollection<ItemDto> GetItemsByOrder(int OrderId)
        {
            return _mapper.Map<ICollection<ItemDto>>(_itemRepository.GetItemsByOrder(OrderId).ToList());
        }

        public bool ItemExists(int ItemId)
        {
            return _itemRepository.Exists(ItemId);
        }

        public bool UpdateItem(ItemDto updatedItem)
        {
            return _itemRepository.Update(_mapper.Map<Item>(updatedItem));
        }
    }
}