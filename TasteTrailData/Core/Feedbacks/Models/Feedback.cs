#pragma warning disable CS8618

using TasteTrailData.Core.Users.Models;
using TasteTrailData.Core.Venues.Models;

namespace TasteTrailData.Core.Feedbacks.Models;

public class Feedback
{
    public int Id { get; set; }

    public string? Text { get; set; }

    public int Rating { get; set; }

    public DateTime CreationDate { get; set; }

    public required string UserId { get; set; }
    
    public int VenueId { get; set; }
}