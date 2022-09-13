using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using EmpresaAdministrador.Core.Application.Interfaces.Repositories;
using EmpresaAdministrador.Infrastructure.Persistence.Contexts;
using EmpresaAdministrador.Infrastructure.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaAdministrador.Infrastructure.Persistence
{
    public static class PServiceRegistration
    {
        public static void AddPersistenceLayer(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<EmpresaContext>(
                opt => opt.UseSqlServer(
                    configuration.GetConnectionString("EmpresaConnection"),
                    migration => migration.MigrationsAssembly(typeof(EmpresaContext).Assembly.FullName)));

            #region Dependency Injections
            service.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            service.AddTransient<INationalityRepository, NationalityRepository>();
            service.AddTransient<IJobTitleRepository, JobTitleRepository>();
            service.AddTransient<IJobCategoryRepository, JobCategoryRepository>();
            #endregion
        }
    }
}
