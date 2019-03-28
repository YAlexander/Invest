using System.Text;
using Invest.Site.Core.Configuration;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;

namespace Invest.Site
{
	public class Startup
	{
		public Startup (IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		public void ConfigureServices (IServiceCollection services)
		{
			var appSettingsSection = Configuration.GetSection("AppSettings");
			services.Configure<AppSettings>(appSettingsSection);

			services.Configure<CookiePolicyOptions>(options =>
			{
				options.CheckConsentNeeded = context => true;
			});

			services.AddMvc().AddNewtonsoftJson();

			AppSettings appSettings = appSettingsSection.Get<AppSettings>();
			byte[] key = Encoding.ASCII.GetBytes(appSettings.Secret);
			services.AddAuthentication(x =>
				{
					x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
					x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
				})
				.AddJwtBearer(x =>
				{
					x.RequireHttpsMetadata = true;
					x.SaveToken = true;
					x.TokenValidationParameters = new TokenValidationParameters
					{
						ValidateIssuerSigningKey = true,
						IssuerSigningKey = new SymmetricSecurityKey(key),
						ValidateIssuer = false,
						ValidateAudience = false
					};
				});
		}

		public void Configure (IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				app.UseHsts();
			}

			app.UseCors(x => x
				.AllowAnyOrigin()
				.AllowAnyMethod()
				.AllowAnyHeader());

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting(routes =>
			{
				routes.MapAreaControllerRoute(
					name: "areas",
					areaName: "Admin",
					template: "Admin/{controller=Dashboard}/{action=Index}/{id?}"
				);

				routes.MapControllerRoute(
					name: "default",
					template: "{controller=Home}/{action=Index}/{id?}");
				routes.MapRazorPages();
			});

			app.UseCookiePolicy();
			app.UseAuthorization();
		}
	}
}
