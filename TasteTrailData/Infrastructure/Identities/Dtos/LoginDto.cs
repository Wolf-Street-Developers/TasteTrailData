#pragma warning disable CS8618

namespace TasteTrailData.Infrastructure.Identities.Dtos;

public class LoginDto
{
    public string Username { get; set; }
    
    public string Password { get; set; }
}