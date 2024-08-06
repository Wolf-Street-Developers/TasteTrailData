using TasteTrailData.Core.Feedbacks.Models;
using TasteTrailData.Core.Menus.Models;
using TasteTrailData.Core.Venues.Models;

namespace TasteTrailData.Infrastructure.Venues.Dtos;
public class VenueDto
{
    public Venue? Venue { get; set; }
    public ICollection<Menu>? Menus { get; set; }
    public ICollection<Feedback>? Feedbacks { get; set; }
}