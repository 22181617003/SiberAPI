using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SiberAPI.Application.Repositories;
using SiberAPI.Persistance.Contexts;
using SiberAPI.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiberAPI.Persistance
{
    public static class ServiseRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            services.AddDbContext<SiberAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString), ServiceLifetime.Singleton);
            services.AddSingleton<IUserReadRepository, UserReadRepository>();
            services.AddSingleton<IUserWriteRepository, UserWriteRepository>();
        }
    }
}
