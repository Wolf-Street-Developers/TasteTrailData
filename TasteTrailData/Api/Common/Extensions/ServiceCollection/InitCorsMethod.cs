using Microsoft.Extensions.DependencyInjection;

namespace TasteTrailData.Api.Common.Extensions.ServiceCollection;

public static class InitCorsMethod
{
    public static void InitCors(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddCors(options =>
        {
            options.AddPolicy(name: "LocalHostPolicy", policyBuilder =>
            {
                policyBuilder
                    .WithOrigins("http://localhost")
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });

            options.AddPolicy(name: "BlazorPolicy", policyBuilder =>
            {
                policyBuilder
                    .WithOrigins("http://20.218.160.138")
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });

            options.AddPolicy(name: "BlazorPublishPolicy", policyBuilder =>
            {
                policyBuilder
                    .WithOrigins("http://20.218.160.138:80")
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });
        });
    }
}