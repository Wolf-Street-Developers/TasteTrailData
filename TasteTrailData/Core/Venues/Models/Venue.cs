#pragma warning disable CS8618

using TasteTrailData.Core.VenuePhotos.Models;
using TasteTrailData.Core.Feedbacks.Models;
using TasteTrailData.Core.Menus.Models;
using TasteTrailData.Core.Users.Models;

namespace TasteTrailData.Core.Venues.Models;

public class Venue
{
    public int Id { get; set; }
    
    public string Name { get; set; }

    public string Address { get; set; }

    public string Description { get; set; }

    public string ContactNumber { get; set; }

    public string Email { get; set; }

    public string? LogoUrlPath { get; set; }

    public float AveragePrice { get; set; }

    public float OverallRating { get; set; }

    public ICollection<VenuePhoto> Photos { get; set; }

    public ICollection<Feedback> Feedbacks { get; set; }

    public string? UserId { get; set; }

    public User User { get; set; }
}