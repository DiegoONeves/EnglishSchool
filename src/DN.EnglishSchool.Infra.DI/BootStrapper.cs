using DN.EnglishSchool.Domain.Repositories;
using DN.EnglishSchool.Infra.Data;
using DN.EnglishSchool.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DN.EnglishSchool.Infra.DI
{
    public class BootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Data Access
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<EnglishSchoolContext>();
        }
    }
}
