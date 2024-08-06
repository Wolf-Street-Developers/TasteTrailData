using TasteTrailData.Core.Users.Models;

namespace TasteTrailData.Infrastructure.Users.Dtos;
public class UserDto
{
    public User? User { get; set; }
    public string? Role { get; set; } 
}