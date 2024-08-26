namespace TasteTrailData.Core.VenuePhotos.Models;

public class VenuePhoto
{
    public int Id { get; set; }

    public int VenueId { get; set; }

    public required string PhotoUrlPath { get; set; }
}