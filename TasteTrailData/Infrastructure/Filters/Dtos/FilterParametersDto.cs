using TasteTrailData.Core.Filters.Enums;

namespace TasteTrailData.Infrastructure.Filters.Dtos;

public class FilterParametersDto
{
    public required FilterType? Type { get; set; }
    
    public int PageNumber { get; set; }
    
    public int PageSize { get; set; }
}