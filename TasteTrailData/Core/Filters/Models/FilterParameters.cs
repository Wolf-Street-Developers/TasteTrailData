using TasteTrailData.Core.Filters.Specifications;

public class FilterParameters<TEntity>
{
    public required IFilterSpecification<TEntity>? Specification { get; set; }
    
    public int PageNumber { get; set; }
    
    public int PageSize { get; set; }

    public string? SearchTerm { get; set; }
}