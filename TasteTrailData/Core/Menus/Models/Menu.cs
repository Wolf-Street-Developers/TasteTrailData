#pragma warning disable CS8618

namespace TasteTrailData.Core.Menus.Models;

using TasteTrailData.Core.MenuItems.Models;
using TasteTrailData.Core.Venues.Models;

public class Menu
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string? Description { get; set; }
}