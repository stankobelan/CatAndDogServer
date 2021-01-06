using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatAndDogServer.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CatAndDogServer
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        readonly string CorpsAnotherPolicy = "reactAPP";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: CorpsAnotherPolicy,
                                  builder =>
                                  {
                                      builder.WithOrigins("http://localhost:3000",
                                          "https://localhost:3000",
                                          "http://localhost:3000/",
                                          "https://localhost:3000/")
                                      .AllowAnyHeader()
                                        .AllowAnyMethod();
                                  });
            });
            services.AddControllers();
            services.AddDbContextPool<DataContext>(options =>
                     options.UseSqlServer(Configuration.GetConnectionString("PetDatabase")));
        }

        private void SendWelcomEmail(IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                 
                // Do work that doesn't write to the Response.
                await next();
                // Do other work that doesn't write to the Response.
            });
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                
            });

            app.UseWhen(contex => contex.Request.Method.Equals(HttpMethods.Post) && contex.Request.Path.Value.Contains("contacts"), SendWelcomEmail);

            // use migration files 
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<DataContext>();
                context.Database.Migrate();
            }
        }
    }
}
