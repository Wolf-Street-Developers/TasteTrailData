using TasteTrailData.Core.VenuePhotos.Models;

namespace TasteTrailData.Core.VenuePhotos.Services;

public interface IVenuePhotosService
{
    Task<int> CreateAsync(VenuePhoto entity);

    Task<List<VenuePhoto>> GetAllAsync();

    Task<int> DeleteByIdAsync(int id);
    
    Task<int> PutAsync(VenuePhoto entity);
}