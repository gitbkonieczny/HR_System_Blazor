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
using HUDEwiBlazor.Data;
using Microsoft.EntityFrameworkCore;
using HUDEwiBlazor.Interfaces;
using HUDEwiBlazor.Classes;
using Syncfusion.Blazor;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.ProtectedBrowserStorage;
using AutoMapper;

namespace HUDEwiBlazor
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
            services.AddMvc();
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSyncfusionBlazor();
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper); 
            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.AddSignalR(e =>
            {
                e.MaximumReceiveMessageSize = 1024000000;
            });

            services.Configure<RequestLocalizationOptions>(options =>
            {
                // define the list of cultures your app will support
                var supportedCultures = new List<CultureInfo>()
                {
                    new CultureInfo("pl"),
                    new CultureInfo("de"),
                    new CultureInfo("en-US")
                };
                // set the default culture
                options.DefaultRequestCulture = new RequestCulture("pl");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
                options.RequestCultureProviders = new List<IRequestCultureProvider>() {
                 new QueryStringRequestCultureProvider() // Here, You can also use other localization provider
                };
            });
            services.AddSingleton(typeof(ISyncfusionStringLocalizer), typeof(Localization));

            services.AddSession();
            services.AddProtectedBrowserStorage();

            services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("HrHudConnection")), ServiceLifetime.Transient);

            services.AddTransient<ISecurity, Security>();
            services.AddTransient<IEmailService, EmailService>();
            services.AddTransient<IScheduleService, ScheduleService>();
            services.AddTransient<IHolidayApiService, HolidayApiService>();
            services.AddTransient<IDayActionsService, DayActionsService>();
            services.AddTransient<IWorkCardService, WorkCardService>();
            services.AddTransient<IOrganizationService, OrganizationService>();
            services.AddTransient<IImageProcessing, ImageProcessing>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzE0MjcyQDMxMzgyZTMyMmUzMGRIeFFhUll0NkFYVmpPbWhlMnlUb2FseDZnZ3QrRUQyM3VHMUxYZ214UHc9");

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
            app.UseRequestLocalization();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
