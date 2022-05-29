using ClaimsIdentity.Interfaces;
using ClaimsIdentity.Repositories;
using ClaimsIdentity.Services;

namespace ClaimsIdentity
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddProjectService(this
        IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserRepository, UserRepository>();
            return services;
        }
    }
}
