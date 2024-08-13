using TasteTrailData.Core.Users.Models;

#pragma warning disable CS8618

namespace TasteTrailData.Core.Common.Tokens.RefreshTokens.Entities;

public class RefreshToken
{
    public Guid Token { get; set; }
    public required string UserId { get; set; }
}
