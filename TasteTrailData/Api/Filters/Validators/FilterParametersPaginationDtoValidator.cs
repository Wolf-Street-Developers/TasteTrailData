using FluentValidation;
using TasteTrailData.Infrastructure.Filters.Dtos;

namespace TasteTrailData.Api.Filters.Validators;

public class FilterParametersPaginationDtoValidator : AbstractValidator<FilterParametersPaginationDto>
{
    public FilterParametersPaginationDtoValidator()
    {
        RuleFor(fp => fp.PageNumber)
            .NotEmpty()
            .GreaterThan(0);
        
        RuleFor(fp => fp.PageSize)
            .NotEmpty()
            .GreaterThan(0)
            .LessThan(100);
    }
}