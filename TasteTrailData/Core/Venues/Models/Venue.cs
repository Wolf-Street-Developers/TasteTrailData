#pragma warning disable CS8618

using TasteTrailData.Core.VenuePhotos.Models;
using TasteTrailData.Core.Feedbacks.Models;
using TasteTrailData.Core.Menus.Models;
using System.Text.Json.Serialization;
using TasteTrailData.Core.Common.Models.Base;

namespace TasteTrailData.Core.Venues.Models;

public class Venue : ICreateable, IRateable, IFeedbackable
{
    public int Id { get; set; }

    public required string Name { get; set; }
    
    public required string Address { get; set; }

    public string? Description { get; set; }

    public string? ContactNumber { get; set; }

    public required string Email { get; set; }

    public string? LogoUrlPath { get; set; }

    public float AveragePrice { get; set; }

    public int Rating { get; set; }
    
    public DateTime CreationDate { get; set; }


    [JsonIgnore]
    public ICollection<Menu> Menus { get; set; }

    [JsonIgnore]
    public ICollection<VenuePhoto> Photos { get; set; }

    [JsonIgnore]
    public ICollection<Feedback> Feedbacks { get; set; }

    public required string UserId { get; set; }
}