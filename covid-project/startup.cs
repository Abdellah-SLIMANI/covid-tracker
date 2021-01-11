using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace covid_project
{
    class startup
    {
        public void ConfigurationServices(IServiceCollection  service)
        {

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            app.UseEndpoints(endPoints =>
            {
                endPoints.MapGet("/persons", async context =>
                {
                    await context.Response.WriteAsync("Persons here");
                });
            });

            app.UseEndpoints(endPoints =>
            {
                endPoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync(Persistance.FindAll());
                });
            });
        }
    }
}

