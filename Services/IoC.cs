using Microsoft.Extensions.DependencyInjection;
using Services.Interfaces;
using Services.Services;

namespace Services
{
    public static class IoC
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IHttpService, HttpService>();
            services.AddTransient<IBookService, BookService>();
            return services;
        }
    }
}