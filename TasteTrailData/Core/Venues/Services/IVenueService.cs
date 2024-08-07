using Microsoft.AspNetCore.Http;
using TasteTrailData.Core.Venues.Models;

namespace TasteTrailData.Core.Venues.Services;

public interface IVenueService
{
    Task<int> CreateAsync(Venue venue, IFormFile? logo);

    Task<List<Venue>> GetAllAsync();
    Task<List<Venue>> GetByCountAsync(int count);

    Task<Venue> GetByIdAsync(int id);

    Task<int> DeleteByIdAsync(int id);
    
    Task<int> PutAsync(Venue entity);

    Task<int> SetVenueLogo(Venue venue, IFormFile? logo);

    Task<int> DeleteVenueLogoAsync(int venueId);

    Task<int> CreateAsyncRerturningId(Venue venue);
}