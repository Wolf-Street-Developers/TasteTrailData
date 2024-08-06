using TasteTrail.Data.src.Core.Common.Repositories.Base;
using TasteTrailData.Core.MenuItems.Models;

namespace TasteTrailData.Core.MenuItems.Repositories;

public interface IMenuItemRepository : IGetByCountAsync<MenuItem>, IGetByIdAsync<MenuItem, int>,
ICreateAsync<MenuItem>, IDeleteByIdAsync<int>, IPutAsync<MenuItem> 
{
    Task<IEnumerable<MenuItem>> GetAllByMenuId(int menuId);
}