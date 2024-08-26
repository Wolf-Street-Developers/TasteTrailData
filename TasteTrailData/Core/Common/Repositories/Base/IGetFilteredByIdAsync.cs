using TasteTrailData.Core.Filters.Specifications;

namespace TasteTrailData.Core.Common.Repositories.Base;

public interface IGetFilteredByIdAsync<TEntity, TId>
{
    Task<List<TEntity>> GetFilteredByIdAsync(FilterParameters<TEntity> parameters, TId referenceId);
}