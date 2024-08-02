using System.Collections.Generic;
using System.Threading.Tasks;
using OnPremiseApp.Data;
using OnPremiseApp.Models;

namespace OnPremiseApp.Services
{
    public class Itemservice : IItemService
    {
        private readonly ItemRespository _itemRespository;

        public ItemService(ItemRepository itemRepository)
        {
            _itemRespository = itemRepository;
        }

        public async Task<IEnumerable<Item>> GetItemsAsync()
        {
            return await _itemRespository.GetItemsAsync();
        }

        public async Task<Item> GetItemAsync(int id)
        {
            return await _itemRepository.GetItemAsync(id);
        }

        public async Task<Item> GetItemAsync(int id)
        {
            return await _itemRepository.GetItemAsync(id);
        }

        public async Task UpdateItemAsync(Item item)
        {
            await _itemRepository.UpdateItemAsync(item);
        }

        public async Task DeleteItemAsync(int id)
        {
            await _itemRepository.DeleteItemAsync(id);
        }
    }
}