using TasteTrail.Data.src.Core.Common.Repositories.Base;
using TasteTrailData.Core.MenuItems.Models;

namespace TasteTrailData.Core.MenuItems.Repositories;

public interface IMenuItemRepository : IGetByCountAsync<MenuItem>, IGetByIdAsync<MenuItem, int>,
ICreateAsync<MenuItem, int>, IDeleteByIdAsync<int>, IPutAsync<MenuItem, int> 
{
    Task<IEnumerable<MenuItem>> GetAllByMenuId(int menuId);
}