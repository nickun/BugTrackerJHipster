using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace BugTracker.Configuration
{
    public static class AutoMapperStartup
    {
        public static IServiceCollection AddAutoMapperModule(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup));
            return services;
        }
    }
}
