using Microsoft.Extensions.DependencyInjection;

namespace TasteTrailData.Api.Common.Extensions.ServiceCollection;

public static class InitCorsMethod
{
    public static void InitCors(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddCors(options =>
        {
            options.AddPolicy("AllowAllOrigins", builder =>
            {
                builder.WithOrigins(
                    "http://localhost",
                    "http://localhost:5137",
                    "http://20.218.160.138:80",
                    "http://20.218.160.138"
                )
                .AllowAnyHeader()
                .AllowAnyMethod();
            });
        });
    }
}