namespace TasteTrailData.Infrastructure.Filters.Dtos;

public class PaginationSearchParametersDto
{
    public int PageNumber { get; set; }

    public int PageSize { get; set; }

    public string? SearchTerm { get; set; }
}