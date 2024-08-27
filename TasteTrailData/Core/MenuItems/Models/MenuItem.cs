#pragma warning disable CS8618

using System.Text.Json.Serialization;
using TasteTrailData.Core.Common.Models.Base;
using TasteTrailData.Core.MenuItemLikes.Models;

namespace TasteTrailData.Core.MenuItems.Models;

public class MenuItem : ILikeable
{
        public int Id { get; set; }

        public required string Name { get; set; }

        public string? Description { get; set; }

        public required string ImageUrlPath { get; set; }

        public float Price { get; set; }

        public int Likes { get; set; }

        public int PopularityRate { get; set; }

        public required int MenuId { get; set; }

        public required string UserId { get; set; }
        
        [JsonIgnore]
        public ICollection<MenuItemLike> MenuItemLikes { get; set; }
}