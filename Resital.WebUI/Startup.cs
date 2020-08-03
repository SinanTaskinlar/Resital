using System;
using AutoMapper;
using BLL.Abstract;
using BLL.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Resital.BLL.Abstract;
using Resital.BLL.Services;
using Resital.Core.Data.UnitOfWork;
using Resital.DAL;
using Resital.Mapping;
using Web.Identity;
using AppContext = Web.Identity.AppContext;

namespace Resital.WebUI
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
            services.AddDbContext<AppContext>(options =>
                options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Resital;Trusted_Connection=True;"));

            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<AppContext>()
                .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                //password
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireNonAlphanumeric = false;

                //Lockout
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.AllowedForNewUsers = true;

                //User
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedPhoneNumber = false;
            });

            services.ConfigureApplicationCookie(options =>
            {
                options.LogoutPath = "/Index";
                options.LoginPath = "/Account/Login";
                options.AccessDeniedPath = "/Account/AccessDenied";
                options.Cookie = new CookieBuilder
                { 
                    HttpOnly = true,
                    Name = ".Resital.Cookie"
                };
            });


            services.AddControllersWithViews();
            services.AddMvc();
            services.AddControllersWithViews();

            services.AddSingleton<DbContext, ResitalDbContext>();
            services.AddSingleton<IUnitOfWork, UnitOfWork>();
            services.AddSingleton<ICityService, CityService>();
            services.AddSingleton<ICompanyService, CompanyService>();
            services.AddSingleton<ICompanyTypeService, CompanyTypeService>();
            services.AddSingleton<IVehicleService, VehicleService>();
            services.AddSingleton<IRoomService, RoomService>();
            services.AddSingleton<IRoomLocationService, RoomLocationService>();
            services.AddSingleton<IRoomTypeService, RoomTypeService>();
            services.AddSingleton<ICartService, CartService>();

            var mappingConfig = new MapperConfiguration(mc => mc.AddProfile(new MapperProfile()));
            var mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
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
            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}