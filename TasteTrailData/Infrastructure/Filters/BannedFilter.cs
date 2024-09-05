using TasteTrailData.Core.Common.Models.Base;
using TasteTrailData.Core.Filters.Specifications;

namespace TasteTrailData.Infrastructure.Filters;

public class BannedFilter<T> : IFilterSpecification<T> where T : IBanable
{
    public IQueryable<T> Apply(IQueryable<T> query)
    {
        return query.Where(e => e.IsBanned);
    }
}