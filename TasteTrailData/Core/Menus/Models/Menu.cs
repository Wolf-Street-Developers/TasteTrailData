#pragma warning disable CS8618

namespace TasteTrailData.Core.Menus.Models;

using System.Text.Json.Serialization;
using TasteTrailData.Core.MenuItems.Models;

public class Menu
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public string? Description { get; set; }
    
    public int VenueId { get; set; }

    public string UserId { get; set; }

    [JsonIgnore]
    public ICollection<MenuItem> MenuItems { get; set; }
}