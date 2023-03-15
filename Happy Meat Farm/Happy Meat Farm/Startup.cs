using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using Microsoft.Extensions.Options;
using Happy_Meat_Farm.Models;
using Happy_Meat_Farm.Data;
using Happy_Meat_Farm.Interface;

namespace Happy_Meat_Farm
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
            ////services.Configure<MyDatabaseSettings>(
            ////Configuration.GetSection(nameof(MyDatabaseSettings)));

            ////services.AddSingleton<MyDatabaseSettings>(sp =>
            ////sp.GetRequiredService<IOptions<MyDatabaseSettings>>().Value);

            //services.AddSingleton<IMongoClient, MongoClient>(s =>
            //{

            //    var uri = s.GetRequiredService<IConfiguration>()["MongoUri"];
            //    return new MongoClient(uri);
            //});
            services.AddControllersWithViews();
            services.AddTransient<INhanVien, NhanVienDBContext>();

            services.Configure<Settings>(options =>
            {
                 options.ConnectionString = Configuration.GetSection("MongoDB:ConnectionString").Value;
                 options.Database = Configuration.GetSection("MongoDB:Database").Value;
            });
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    //pattern: "{controller=NhanVien}/{action=Login}/{id?}");
                    pattern: "{controller=NhanVien}/{action=Login}/{id?}");
                    //pattern: "{controller=Home}/{action=Index}/{id?}");

            });
        }
    }
}
