using System;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using BS.App.Implementation;
using BS.App.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BS.Services
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
       
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            }));

            //Create your Auto-fac Container
            var containerBuilder = new ContainerBuilder();

            //Register your own services within Auto-fac
            containerBuilder.RegisterType<VisitanteApp>().As<IVisitanteApp>();
            containerBuilder.RegisterType<SiteMenuApp>().As<ISiteMenuApp>();

            //Put the framework services into Auto-fac
            containerBuilder.Populate(services);

            //Build and return the Auto-fac collection
            var container = containerBuilder.Build();
            return container.Resolve<IServiceProvider>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
                app.UseHsts();

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}