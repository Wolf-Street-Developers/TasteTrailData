using TasteTrailData.Core.Filters.Specifications;

namespace TasteTrailData.Core.Common.Repositories.Base;

public interface IGetCountFilteredAsync<TEntity>
{
    Task<int> GetCountFilteredAsync(FilterParameters<TEntity>? parameters);
}
