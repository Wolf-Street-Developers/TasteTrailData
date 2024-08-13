#pragma warning disable CS8618

namespace TasteTrailData.Core.VenuePhotos.Models;

using TasteTrailData.Core.Venues.Models;

public class VenuePhoto
{
    public int Id { get; set; }

    public int VenueId { get; set; }

    public required string PhotoUrlPath { get; set; }
}