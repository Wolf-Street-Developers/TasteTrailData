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

    public ICollection<Feedback> Feedbacks { get; set; }

    public ICollection<Venue> Venues { get; set; }
    public ICollection<RefreshToken> RefreshTokens { get; set; }
}