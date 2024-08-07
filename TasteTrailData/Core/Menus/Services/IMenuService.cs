using TasteTrailData.Core.Menus.Models;

namespace TasteTrailData.Core.Menus.Services;

public interface IMenuService
{
    Task<int> CreateAsync(Menu entity);

    Task<List<Menu>> GetAllAsync();

    Task<Menu> GetByIdAsync(int id);

    Task<int> DeleteByIdAsync(int id);
    
    Task<int> PutAsync(Menu entity);

    Task<IEnumerable<Menu>> GetAllMenusByVenueId(int venueId);
}