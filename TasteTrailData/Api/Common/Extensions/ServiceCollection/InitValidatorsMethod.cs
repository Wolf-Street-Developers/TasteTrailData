using System.Reflection;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace TasteTrailData.Api.Common.Extensions.ServiceCollection;

public static class InitValidatorsMethod
{
    public static void AddValidators(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
    }
}