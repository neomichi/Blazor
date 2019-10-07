using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BlazorApp.Web.Data;
using BlazorApp.Data.Service;
using BlazorApp.Data;
using BlazorApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using BlazorApp.Data.Services;
using System.Net.Http;

namespace BlazorApp.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration.GetConnectionString("PostgreSQL");

            services.AddEntityFrameworkNpgsql()
                .AddDbContext<MyDbContext>((options => options.UseNpgsql(connectionString)));

            services.AddIdentity<ApplicationUser, ApplicationRole>()
                .AddEntityFrameworkStores<MyDbContext>()                
                .AddDefaultTokenProviders();
            //services.AddTransient<UserManager<ApplicationUser>>();
            //services.AddTransient<RoleManager<ApplicationUser>>();
            //services.AddTransient<SignInManager<ApplicationUser>>();
            
            services.AddScoped<IDbInitializer, DbInitializer>();

            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
              services.AddScoped<ITestService, TestService>();

            //services.AddScoped<IHttpClientFactory>();
           // services.AddHttpClient();

           // services.AddHttpClient<ITestService, ITestService>(
                //client =>            
                //client.BaseAddress = new Uri(@"https://localhost:5001/")
                //);
              //.AddPolicyHandler(GetRetryPolicy())
            
              
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IDbInitializer dbInitializer)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseCookiePolicy();
            app.UseAuthentication();     
            app.UseAuthorization();
            //Generate EF Core Seed
            dbInitializer.Initialize().Wait();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
