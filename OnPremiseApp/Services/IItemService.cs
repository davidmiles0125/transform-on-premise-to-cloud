using System.Collections.Generic;
using System.Threading.Tasks;
using OnPremiseApp.Models;

namespace OnPremiseApp.Services
{
    public interface IItemService
    {
        Task<IEnumerable<Item>> GetItemAsync();
        Task<Item> GetItemAsync(int id);
        Task AddItemAsync(Item item);
        Task UpdateItemAsync(Item item);
        Task UpdateItemAsync(Item itme);
        Task DeleteItemAsync(int id);
    }
}