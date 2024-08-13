#pragma warning disable CS8618

using TasteTrailData.Core.VenuePhotos.Models;
using TasteTrailData.Core.Feedbacks.Models;
using TasteTrailData.Core.Menus.Models;
using TasteTrailData.Core.Users.Models;
using System.ComponentModel.DataAnnotations;

namespace TasteTrailData.Core.Venues.Models;

public class Venue
{
    public int Id { get; set; }

    public required string Name { get; set; }
    
    public required string Address { get; set; }

    public string? Description { get; set; }

    public string? ContactNumber { get; set; }

    public required string Email { get; set; }

    public string? LogoUrlPath { get; set; }

    public float AveragePrice { get; set; }

    public float OverallRating { get; set; }

    public required ICollection<Menu> Menus { get; set; }

    public required ICollection<VenuePhoto> Photos { get; set; }

    public required ICollection<Feedback> Feedbacks { get; set; }

    public required string UserId { get; set; }
    
    public User User { get; set; }
}