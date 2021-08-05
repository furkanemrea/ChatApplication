using ChatApplication.Web.Hubs;
using ChatApplication.Web.Redis;
using ChatApplication.Web.Session;
using EntityLibrary.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;

using System.Linq;

using System.Threading.Tasks;

namespace ChatApplication.Web
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
            services.AddDbContext<ChatprojectdbContext>(i => i.UseSqlServer(@"Data Source=DESKTOP-V678B52\SQLEXPRESS;Initial Catalog=ChatProjectDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            //services.AddDbContext<ChatprojectdbContext>(i => i.UseSqlServer(connectionString,opt=> {
            //    opt.EnableRetryOnFailure();
            //}));
            services.AddSingleton<RedisManager>();
            services.AddSingleton<SessionHelper>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSignalR();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, RedisManager redisService)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            redisService.Connect();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<MessageHub>("/signal/message-hub");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=LoginPage}/{id?}");
            });
        }
    }
}
