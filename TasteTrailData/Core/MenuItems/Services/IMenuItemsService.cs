using TasteTrailData.Core.MenuItems.Models;

namespace TasteTrailData.Core.MenuItems.Services;

public interface IMenuItemService
{
    Task<int> CreateAsync(MenuItem entity);

    Task<List<MenuItem>> GetByCountAsync(int count);

    Task<MenuItem> GetByIdAsync(int id);

    Task<int> DeleteByIdAsync(int id);
    
    Task<int> PutAsync(MenuItem entity);

    Task<IEnumerable<MenuItem>> GetAllMenuItemsByMenuId(int menuId);
}