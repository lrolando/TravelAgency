using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using RulesBusiness.Commission;
using RulesBusiness.Commission.TypeOfClient;
using DataAccess.Repository;
using DataAccess.Models.DTO;
using DataAccess;
using Microsoft.AspNetCore.Http;

namespace TravelAgency
{
    public class Startup
    {
        readonly string MiCors = "MiCors";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<AppDBContexts>();

            services.AddCors(options => {
                options.AddPolicy(name: MiCors,
                                  builder => {
                                      builder.WithHeaders("*");
                                      builder.WithOrigins("*");
                                      builder.WithMethods("*");
                                  });
            });

            services.AddControllers();
            //services.AddControllers(options =>
            //            options.Filters.Add(new HttpResponseExceptionFilter()));

            services.AddScoped<AppDBContexts, AppDBContexts>();
            services.AddScoped<IDBRepository, DBRepository>();
            services.AddScoped<ICommission, Commission>();
            services.AddScoped<ICommissionResult, CommissionResult>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {

                app.UseExceptionHandler("/error-local-development");

                //app.UseDeveloperExceptionPage();
            }
            else
            {

                app.UseExceptionHandler("/error");

            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(MiCors);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
