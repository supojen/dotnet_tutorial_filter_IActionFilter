using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using FilterTutorial.Filters;
using FilterTutorial.Model;

namespace FilterTutorial
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // If you want to use the Action Filter in Global Level,
            // then you need to register the Action-Filter-Class inside Add Controller method
            services.AddControllersWithViews(
                config => {
                    config.Filters.Add(new GlobalActionFilter());
            });
            
            
            // If you want to use the Action Filter in Controller or Action Level 
            // You need to register the Action-Filter-Class first
            services.AddTransient<ActionFilterEx1>();
            services.AddTransient<ActionFilterEx2>();
            services.AddTransient<ControllerActionFilter>();
            services.AddTransient<ValidateActionFilter>();

            services.AddSingleton<IMovieService,InMemoryMovieService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();


    
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
