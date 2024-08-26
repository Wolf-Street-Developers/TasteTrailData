namespace TasteTrailData.Core.Filters.Specifications;

public interface IFilterSpecification<T>
{
    IQueryable<T> Apply(IQueryable<T> query);
}