using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TasteTrail.Data.src.Core.Common.Repositories.Base;
using TasteTrailData.Core.Common.Tokens.RefreshTokens.Entities;

namespace TasteTrailData.Core.Common.Tokens.RefreshTokens.Repositories;

public interface IRefreshTokenRepository : IDeleteByIdAsync<Guid>, ICreateAsync<RefreshToken, Guid>, IGetByIdAsync<RefreshToken, Guid>
{
    public Task<int> DeleteRangeRefreshTokensAsync(string userId);
}

