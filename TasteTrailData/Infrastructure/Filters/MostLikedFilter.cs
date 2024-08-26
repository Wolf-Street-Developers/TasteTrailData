using TasteTrailData.Core.Common.Models.Base;
using TasteTrailData.Core.Filters.Specifications;

namespace TasteTrailData.Infrastructure.Filters;

public class MostLikedFilter<T> : IFilterSpecification<T> where T : ILikeable
{
    public IQueryable<T> Apply(IQueryable<T> query)
    {
        return query.OrderByDescending(e => e.Likes);
    }
}