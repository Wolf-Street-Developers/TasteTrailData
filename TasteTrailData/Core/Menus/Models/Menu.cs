#pragma warning disable CS8618

namespace TasteTrailData.Core.Menus.Models;

using TasteTrailData.Core.MenuItems.Models;
using TasteTrailData.Core.Venues.Models;

public class Menu
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public string? Description { get; set; }
    
    public int VenueId { get; set; }

    public required ICollection<MenuItem> MenuItems { get; set; }
}