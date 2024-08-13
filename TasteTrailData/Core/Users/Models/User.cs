#pragma warning disable CS8618

using Microsoft.AspNetCore.Identity;
using TasteTrailData.Core.Common.Tokens.RefreshTokens.Entities;
using TasteTrailData.Core.Feedbacks.Models;
using TasteTrailData.Core.Venues.Models;

namespace TasteTrailData.Core.Users.Models;

public class User : IdentityUser
{
    public bool IsBanned { get; set; }

    public bool IsMuted { get; set; }

    public string? AvatarPath { get; set; }

    public required ICollection<Feedback> Feedbacks { get; set; }

    public required ICollection<Venue> Venues { get; set; }

    public required ICollection<RefreshToken> RefreshTokens { get; set; }
}