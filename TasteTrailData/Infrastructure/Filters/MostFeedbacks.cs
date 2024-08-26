using TasteTrailData.Core.Common.Models.Base;
using TasteTrailData.Core.Filters.Specifications;

namespace TasteTrailData.Infrastructure.Filters;

public class MostFeedbacks<T> : IFilterSpecification<T> where T : IFeedbackable
{
    public IQueryable<T> Apply(IQueryable<T> query)
    {
        return query.OrderByDescending(e => e.Feedbacks.Count);
    }
}