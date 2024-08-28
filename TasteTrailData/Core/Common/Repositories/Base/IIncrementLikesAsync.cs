using TasteTrailData.Core.Common.Models.Base;

namespace TasteTrailData.Core.Common.Repositories.Base;

public interface IIncrementLikesAsync<TEntity, TReturn> where TEntity : ILikeable
{
    Task<TReturn> IncrementLikesAsync(TEntity entity);
}
