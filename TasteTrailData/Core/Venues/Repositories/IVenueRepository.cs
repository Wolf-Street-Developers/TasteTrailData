using TasteTrail.Data.src.Core.Common.Repositories.Base;
using TasteTrailData.Core.Venues.Models;

namespace TasteTrailData.Core.Venues.Repositories;

public interface IVenueRepository : IGetByCountAsync<Venue>, IGetByIdAsync<Venue, int>,
ICreateAsync<Venue, int>, IDeleteByIdAsync<int>, IPutAsync<Venue, int>
{
    Task<List<Venue>> GetAllAsync();

    Task<int> CreateAsyncReturningId(Venue venue);

    Task PatchLogoUrlPathAsync(Venue venue, string logoUrlPath);
}