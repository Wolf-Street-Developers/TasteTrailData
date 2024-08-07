using TasteTrail.Data.src.Core.Common.Repositories.Base;
using TasteTrailData.Core.VenuePhotos.Models;

namespace TasteTrailData.Core.VenuePhotos.Repositories;

public interface IVenuePhotosRepository : IGetAllAsync<IVenuePhotosRepository>, ICreateAsync<VenuePhoto, int>,
IDeleteByIdAsync<int>, IPutAsync<VenuePhoto, int>
{
    
}