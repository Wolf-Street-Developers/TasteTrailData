using TasteTrailData.Core.Common.Models.Base;
using TasteTrailData.Core.Filters.Specifications;

namespace TasteTrailData.Infrastructure.Filters;

public class NotMutedFilter<T> : IFilterSpecification<T> where T : IMuteable
{
    public IQueryable<T> Apply(IQueryable<T> query)
    {
        return query.Where(e => !e.IsMuted);
    }
}
