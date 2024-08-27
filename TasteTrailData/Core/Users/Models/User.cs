#pragma warning disable CS8618

using System.ComponentModel;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;
using TasteTrailData.Core.Common.Tokens.RefreshTokens.Entities;
using TasteTrailData.Core.FeedbackLikes.Models;
using TasteTrailData.Core.Feedbacks.Models;
using TasteTrailData.Core.MenuItemLikes.Models;
using TasteTrailData.Core.MenuItems.Models;
using TasteTrailData.Core.Menus.Models;
using TasteTrailData.Core.Venues.Models;

namespace TasteTrailData.Core.Users.Models;

public class User : IdentityUser
{
    [DefaultValue(false)]
    public bool IsBanned { get; set; }

    [DefaultValue(false)]
    public bool IsMuted { get; set; }

    public required string AvatarPath { get; set; }

    [JsonIgnore]
    public ICollection<Feedback> Feedbacks { get; set; }

    [JsonIgnore]
    public ICollection<Venue> Venues { get; set; }

    [JsonIgnore]
    public ICollection<RefreshToken> RefreshTokens { get; set; }

    [JsonIgnore]
    public ICollection<MenuItem> MenuItems { get; set; }

    [JsonIgnore]
    public ICollection<Menu> Menus { get; set; }

    [JsonIgnore]
    public ICollection<MenuItemLike> MenuItemLikes { get; set; }

    [JsonIgnore]
    public ICollection<FeedbackLike> FeedbackLikes { get; set; }
}