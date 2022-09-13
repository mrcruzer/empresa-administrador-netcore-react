using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmpresaAdministrador.Infrastructure.Persistence;
using EmpresaAdministrador.Infrastructure.Identity;
using EmpresaAdministrador.Core.Application;
using EmpresaAdministrador.Presentation.WebApi.Extensions;
using MediatR;

namespace EmpresaAdministrador.Presentation.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddPersistenceLayer(Configuration);
            services.AddIdentityLayer(Configuration);
            services.AddApplicationLayer(Configuration);
            services.AddSwaggerExtension();
            services.AddApiVersioningExtension();

            //services.AddMediatR(typeof(Startup));


            services.AddControllers(opt =>
            {
                opt.Filters.Add(new ProducesAttribute("application/json"));
            }).ConfigureApiBehaviorOptions(opt =>
            {
                opt.SuppressInferBindingSourcesForParameters = true;
                opt.SuppressMapClientErrors = true;
            }).AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );
            services.AddHealthChecks();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHttpMethodOverride();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseHealthChecks("/health");

            app.UseSwaggerExtension();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
