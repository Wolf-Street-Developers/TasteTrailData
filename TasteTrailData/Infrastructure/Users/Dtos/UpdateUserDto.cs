#pragma warning disable CS8618

namespace TasteTrailData.Infrastructure.Users.Dtos;

public class UpdateUserDto
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}