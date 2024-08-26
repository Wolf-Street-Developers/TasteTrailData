using TasteTrailData.Core.Filters.Specifications;

namespace TasteTrailData.Core.Common.Repositories.Base;

public interface IGetCountBySpecificationAsync<TEntity>
{
    Task<int> GetCountBySpecificationAsync(IFilterSpecification<TEntity>? specification);
}