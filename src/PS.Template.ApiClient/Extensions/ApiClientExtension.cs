using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PS.Template.ApiClient.ApiClient;
using PS.Template.ApiClient.ApiClient.Interfaces;

namespace PS.Template.ApiClient.Extensions
{
    public static class ApiClientExtension
    {
        public static IServiceCollection AddApiClient(this IServiceCollection services, IConfiguration configuration)
        {
            var UrlBase = configuration.GetSection("Url").Value;

            services.AddTransient<ICursoApiClient>(provider => new CursoApiClient(UrlBase));
            return services;
        }
    }
}
