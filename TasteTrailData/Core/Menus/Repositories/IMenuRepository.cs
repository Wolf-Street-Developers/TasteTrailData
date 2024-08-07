using TasteTrail.Data.src.Core.Common.Repositories.Base;
using TasteTrailData.Core.Menus.Models;

namespace TasteTrailData.Core.Menus.Repositories;

public interface IMenuRepository : IGetAllAsync<Menu>, IGetByIdAsync<Menu, int>,
ICreateAsync<Menu, int>, IDeleteByIdAsync<int>, IPutAsync<Menu, int> 
{
    Task<IEnumerable<Menu>> GetAllByVenueId(int venueId);
}