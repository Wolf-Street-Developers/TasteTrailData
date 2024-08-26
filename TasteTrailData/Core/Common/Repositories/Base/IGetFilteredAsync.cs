

using TasteTrailData.Core.Filters.Specifications;

namespace TasteTrailData.Core.Common.Repositories.Base;

public interface IGetFilteredAsync<TEntity>
{
    Task<List<TEntity>> GetFilteredAsync(FilterParameters<TEntity> parameters);
}