using TasteTrailData.Core.Common.Models.Base;
using TasteTrailData.Core.Filters.Specifications;

namespace TasteTrailData.Infrastructure.Filters;

public class NewestFirstFilter<T> : IFilterSpecification<T> where T : ICreateable
{
    public IQueryable<T> Apply(IQueryable<T> query)
    {
        return query.OrderByDescending(e => e.CreationDate);
    }
}