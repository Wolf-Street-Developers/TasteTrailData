using TasteTrailData.Core.MenuItems.Models;
using TasteTrailData.Core.Menus.Models;

namespace TasteTrailData.Infrastructure.Menus.Dtos;
public class MenuDto
{
    public Menu? Menu { get; set; }
    
    public IEnumerable<MenuItem>? MenuItems { get; set; }
}