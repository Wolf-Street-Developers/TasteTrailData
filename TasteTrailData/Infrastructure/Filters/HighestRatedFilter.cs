using TasteTrailData.Core.Common.Models.Base;
using TasteTrailData.Core.Filters.Specifications;

namespace TasteTrailData.Infrastructure.Filters;

public class HighestRatedFilter<T> : IFilterSpecification<T> where T : IRateable
{
    public IQueryable<T> Apply(IQueryable<T> query)
    {
        return query.OrderByDescending(e => e.Rating);
    }
}