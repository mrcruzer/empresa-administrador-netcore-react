using EmpresaAdministrador.Core.Application.Interfaces.Services;
//using EmpresaAdministrador.Core.Application.Services;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaAdministrador.Core.Application
{
    public static class AServiceRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            #region dependency injections
            /*services.AddTransient(typeof(IGenericService<,>), typeof(GenericService<,,>));
            services.AddTransient<INationalityService, NationalityService>();*/
            //services.AddTransient<IUserService, UserService>();
            #endregion
        }
    }
}
