using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using ExaltedOnlineAPI.Controllers;
using ExaltedOnlineAPI.Interfaces;
using ExaltedOnlineAPI.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Localization;
using System.Globalization;
using Microsoft.AspNetCore.Server.IISIntegration;

namespace ExaltedOnlineAPI
{
    /// <summary>
    /// 
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// 
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        ///  This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                builder =>
                {
                    builder.AllowAnyOrigin()//.WithOrigins("http://localhost:60325")
                                .AllowAnyMethod()
                                .AllowAnyHeader();
                    //.AllowCredentials();
                });
            });

            services.AddControllers();

            // Set up dependency injection for controller's logger
            SetInjectionControllerLogger(ref services);

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ExaltedOnline API", Version = "v1" });
            });

            services.AddDbContext<ExaltedDBContext>(op => op.UseSqlServer(Configuration.GetConnectionString("ExaltedDB")));

            services.Configure<IISServerOptions>(options =>
            {
                options.AutomaticAuthentication = true;
            });

            services.Configure<IISOptions>(options =>
            {
                options.ForwardClientCertificate = false;
            });

            services.AddLocalization(o => o.ResourcesPath = "Resources");
            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new[]
                {
                    new CultureInfo("en-US")
                };

                options.DefaultRequestCulture = new RequestCulture("en-US", "en-US");

                // You must explicitly state which cultures your application supports.
                // These are the cultures the app supports for formatting 
                // numbers, dates, etc.
                options.SupportedCultures = supportedCultures;

                // These are the cultures the app supports for UI strings, 
                // i.e. we have localized resources for.
                options.SupportedUICultures = supportedCultures;
            });

            services.AddScoped<IAuthRepository, AuthRepository>();

            

            services.AddAuthentication(IISDefaults.AuthenticationScheme);

        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors("CorsPolicy");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseAuthorization();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "ExaltedOnline API V1");
            });

            app.UseRouting();

            

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

            

        }

        private static void SetInjectionControllerLogger(ref IServiceCollection services)
        {
            services.AddScoped<ILogger, Logger<CharmsController>>();
            services.AddScoped<ILogger, Logger<UsersController>>();
        }

    }
}
