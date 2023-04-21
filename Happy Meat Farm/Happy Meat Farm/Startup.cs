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
using Happy_Meat_Farm.Controllers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Happy_Meat_Farm.Services;
using Microsoft.IdentityModel.Tokens;
using System.Text;

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
            services.AddSingleton<IMongoClient>(sp => sp.GetRequiredService<IOptions<MongoClient>>().Value);

            services.AddScoped<TTB_Interface, TTBRepository>();
            services.AddScoped<IThuoc, ThuocDBContext>();
            services.AddScoped<IThucAn, ThucAnDBContext>();
            services.AddScoped<INhanVien, NhanVienDBContext>();
            services.AddScoped<NhanVienServices>();


            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })

            .AddJwtBearer(options =>
             {
                 options.RequireHttpsMetadata = false;
                 options.SaveToken = true;
                 options.TokenValidationParameters = new TokenValidationParameters
                 {
                     ValidateIssuerSigningKey = true,
                     //IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Configuration["Jwt:Key"])),
                     //ValidateIssuer = false,
                     //ValidateAudience = false,
                     ValidateIssuer = true,
                     ValidateAudience = true,
                     ValidateLifetime = true,
                     ValidIssuer = "https://example.com",
                     ValidAudience = "https://example.com",
                     IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("YOUR_SECRET_KEY_HERE"))

                 };
             });

            services.AddSingleton<IMongoClient>(new MongoClient("mongodb://localhost:5001"));
            services.AddControllersWithViews();
            services.AddTransient<INhanVien, NhanVienDBContext>();
            services.AddTransient<IBayDan, BayDanDBContext>();
            services.AddTransient<ICaThe, CaTheDBContext>();
            services.AddTransient<IThucAn, ThucAnDBContext>();
            services.AddTransient<TTB_Interface, TTBRepository>();
            services.AddTransient<IThuoc, ThuocDBContext>();
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
                    //pattern: "{controller=Auth}/{action=Login}/{id?}");
                    pattern: "{controller=Home}/{action=Index}/{id?}");

            });
            app.UseAuthentication();

        }
    }
}
