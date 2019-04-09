using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Finalizer.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Logging;
using Finalizer.Services;
using SmartyStreets;

namespace Finalizer
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
            services.AddTransient(serviceProvider =>
            {
                string connectionString = Configuration.GetConnectionString("ABCConnection");
                System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
                return connection;
            });
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddTransient<SendGrid.ISendGridClient>((s) =>
            {
                return new SendGrid.SendGridClient(Configuration.GetValue<string>("sendgrid:key"));
            });

            services.AddTransient<IEmailSender>((s) => { return new EmailService(
                s.GetService<SendGrid.ISendGridClient>(),
                s.GetService<ILogger<EmailService>>()
                );
            });

            services.AddTransient<Braintree.IBraintreeGateway>((s) =>
            {
                return new Braintree.BraintreeGateway(
                    Configuration.GetValue<string>("Braintree:Environment"),
                    Configuration.GetValue<string>("Braintree:MerchantId"),
                    Configuration.GetValue<string>("Braintree:PublicKey"),
                    Configuration.GetValue<string>("Braintree:PrivateKey")
                );
            });

            services.AddTransient<SmartyStreets.ClientBuilder>((s) =>
            {
                return new SmartyStreets.ClientBuilder(Configuration.GetValue<string>("smarty:AuthID"),
                    Configuration.GetValue<string>("smarty:AuthToken"));
            });

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection"))
                            //options.UseInMemoryDatabase("default")
                            );


            services.AddDefaultIdentity<RegisteredUser>((config) => { config.SignIn.RequireConfirmedEmail = true; })
                .AddRoles<IdentityRole>()   //Turn on Role Support
                
                .AddDefaultUI()
                
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
