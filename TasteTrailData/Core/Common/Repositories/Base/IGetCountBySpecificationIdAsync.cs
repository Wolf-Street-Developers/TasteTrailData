using TasteTrailData.Core.Filters.Specifications;

namespace TasteTrailData.Core.Common.Repositories.Base;

public interface IGetCountBySpecificationIdAsync<TEntity, TId>
{
    Task<int> GetCountBySpecificationIdAsync(IFilterSpecification<TEntity>? specification, TId referenceId);
}