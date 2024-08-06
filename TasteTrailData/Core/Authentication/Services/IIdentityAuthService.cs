using Microsoft.AspNetCore.Identity;
using TasteTrailData.Core.Users.Models;
using TasteTrailData.Infrastructure.Common.Dtos;

namespace TasteTrail.Data.src.Core.Authentication.Services;
public interface IIdentityAuthService
{
    Task<IdentityResult> RegisterAsync(User user, string password);

    Task<AccessToken> SignInAsync(string username, string password, bool rememberMe);
    
    Task SignOutAsync(Guid refresh, string jwt);

    Task<AccessToken> UpdateToken(Guid refresh, string jwt);
}