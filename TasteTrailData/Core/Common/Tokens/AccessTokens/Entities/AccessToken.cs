#pragma warning disable CS8618

namespace TasteTrailData.Infrastructure.Common.Dtos;

public class AccessToken
{
    public Guid Refresh { get; set; }
    public string Jwt { get; set; }
}
