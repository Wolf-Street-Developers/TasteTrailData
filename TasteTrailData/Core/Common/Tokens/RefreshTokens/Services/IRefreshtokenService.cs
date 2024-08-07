using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TasteTrailData.Core.Common.Tokens.RefreshTokens.Entities;

namespace TasteTrailData.Core.Common.Tokens.RefreshTokens.Services;

public interface IRefreshtokenService
{
    public Task DeleteRangeRefreshTokensAsync(string userId);
    Task<Guid> DeleteByIdAsync(Guid id);
    Task<Guid> CreateAsync(RefreshToken entity);
    Task<RefreshToken?> GetByIdAsync(Guid id);
}
