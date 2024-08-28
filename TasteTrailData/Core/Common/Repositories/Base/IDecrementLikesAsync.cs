using TasteTrailData.Core.Common.Models.Base;

namespace TasteTrailData.Core.Common.Repositories.Base;

public interface IDecrementLikesAsync<TEntity, TReturn> where TEntity : ILikeable
{
    Task<TReturn> DecrementLikesAsync(TEntity entity);
}
