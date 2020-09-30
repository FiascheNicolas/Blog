using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Data;
using Blog.Data.FileManager;
using Blog.Data.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Blog
{
    public class Startup
    {
        //Carga la configuracion de appsettings.json
        private IConfiguration _config;
        public Startup(IConfiguration config)
        {
            _config = config;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(_config["DefaultConnection"]));
            services.AddTransient<IRepository, Repository>();
            services.AddTransient<IFileManager, FileManager>();
            services.AddIdentity<IdentityUser, IdentityRole>(options => 
            {
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 6;
            })
                //.AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>();

            services.ConfigureApplicationCookie(options => {
                options.LoginPath = "/Auth/login";
            });
            services.AddMvc(options =>
            {
                options.CacheProfiles.Add("Monthly", new Microsoft.AspNetCore.Mvc.CacheProfile { Duration = 60*60*24*7*4});
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
            }
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvcWithDefaultRoute();
        }
    }
}
