using FluentValidation;
using TasteTrailData.Infrastructure.Filters.Dtos;

namespace TasteTrailData.Api.Filters.Validators;

public class PaginationSearchParametersDtoValidators : AbstractValidator<PaginationSearchParametersDto>
{
    public PaginationSearchParametersDtoValidators()
    {
        RuleFor(fp => fp.PageNumber)
            .NotEmpty()
            .GreaterThan(0);
        
        RuleFor(fp => fp.PageSize)
            .NotEmpty()
            .GreaterThan(0)
            .LessThan(100);

        RuleFor(fp => fp.SearchTerm)
            .MaximumLength(500);
    }
}
