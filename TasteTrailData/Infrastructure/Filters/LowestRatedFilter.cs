using TasteTrailData.Core.Common.Models.Base;
using TasteTrailData.Core.Filters.Specifications;

namespace TasteTrailData.Infrastructure.Filters;

public class LowestRatedFilter<T> : IFilterSpecification<T> where T : IRateable
{
    public IQueryable<T> Apply(IQueryable<T> query)
    {
        return query.OrderBy(e => e.Rating);
    }
}