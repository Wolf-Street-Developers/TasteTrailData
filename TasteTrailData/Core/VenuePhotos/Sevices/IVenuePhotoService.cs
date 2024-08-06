using TasteTrailData.Core.VenuePhotos.Models;

namespace TasteTrailData.Core.VenuePhotos.Sevices;

public interface IVenuePhotosService
{
    Task CreateAsync(VenuePhoto entity);

    Task<List<VenuePhoto>> GetAllAsync();

    Task DeleteByIdAsync(int id);
    
    Task PutAsync(VenuePhoto entity);
}