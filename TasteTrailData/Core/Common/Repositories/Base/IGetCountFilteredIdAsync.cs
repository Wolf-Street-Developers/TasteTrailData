using TasteTrailData.Core.Filters.Specifications;

namespace TasteTrailData.Core.Common.Repositories.Base;

public interface IGetCountFilteredIdAsync<TEntity, TId>
{
    Task<int> GetCountFilteredIdAsync(FilterParameters<TEntity>? parameters, TId referenceId);
}
