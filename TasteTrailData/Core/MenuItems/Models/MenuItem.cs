#pragma warning disable CS8618

namespace TasteTrailData.Core.MenuItems.Models;

public class MenuItem
{
        public int Id { get; set; }

        public required string Name { get; set; }

        public string? Description { get; set; }

        public float Price { get; set; }

        public int PopularityRate { get; set; }

        public int MenuId { get; set; }

        public string UserId { get; set; }
}