using TasteTrailData.Core.Common.Models.Base;
using TasteTrailData.Core.Filters.Specifications;

namespace TasteTrailData.Infrastructure.Filters;

public class OldestFirstFilter<T> : IFilterSpecification<T> where T : ICreateable
{
    public IQueryable<T> Apply(IQueryable<T> query)
    {
        return query.OrderBy(e => e.CreationDate);
    }
}