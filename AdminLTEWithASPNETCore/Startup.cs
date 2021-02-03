using AdminLTEWithASPNETCore.Data;
using AdminLTEWithASPNETCore.Models.Settings;
using AdminLTEWithASPNETCore.Services;
using IdentityModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTEWithASPNETCore
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
            services.AddControllersWithViews();
            services.AddRazorPages();

            #region Settings
            services.Configure<SmtpCredentialsSettings>(Configuration.GetSection("SmtpCredentials"));
            services.AddScoped(cfg => cfg.GetService<IOptions<SmtpCredentialsSettings>>().Value);

            services.Configure<IdentityServerSettings>(Configuration.GetSection("IdentityAuthentication"));
            services.AddScoped(cfg => cfg.GetService<IOptions<IdentityServerSettings>>().Value);
            #endregion

            #region Setting Db
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ApplicationDbContextConnection")));
            #endregion

            #region Dependency Injection
            services.AddTransient<IEmailSender, EmailSender>();
            #endregion

            #region Authentication and IdentityServer4
            services.AddSession(options =>
            {
                options.Cookie.Name = ".puresourcecode.session";
                options.IdleTimeout = TimeSpan.FromHours(12);
            });

            var idsrv = Configuration.GetSection("IdentityAuthentication").Get<IdentityServerSettings>();
            if (idsrv.UseIdentityServer)
            {
                services.AddAuthentication(options =>
                {
                    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = "oidc";
                })
                .AddCookie(options =>
                {
                    options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                    options.Cookie.Name = ".puresourcecode.cookie";
                })
                .AddOpenIdConnect("oidc", options =>
                {
                    options.Authority = idsrv.IdentityServerUrl;
                    options.ClientId = idsrv.ClientId;
                    options.ClientSecret = idsrv.ClientSecret;

#if DEBUG
                    options.RequireHttpsMetadata = false;
#else
                    options.RequireHttpsMetadata = true;
#endif

                    options.ResponseType = "code";

                    options.Scope.Clear();
                    options.Scope.Add("openid");
                    options.Scope.Add("profile");
                    options.Scope.Add("email");
                    options.Scope.Add("roles");
                    options.Scope.Add("offline_access");

                    options.ClaimActions.MapAllExcept("iss", "nbf", "exp", "aud", "nonce", "iat", "c_hash");
                    options.ClaimActions.MapJsonKey("role", "role", "role");

                    options.GetClaimsFromUserInfoEndpoint = true;
                    options.SaveTokens = true;

                    options.SignedOutRedirectUri = "/";

                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        NameClaimType = JwtClaimTypes.Name,
                        RoleClaimType = JwtClaimTypes.Role,
                    };
                });
            }
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ApplicationDbContext db)
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

            // ensure the database is created
            db.Database.EnsureCreated();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseCookiePolicy();
            app.UseSession();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}