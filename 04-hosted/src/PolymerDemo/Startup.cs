using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace PolymerDemo
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddCors();
		}

		public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
		{
			loggerFactory.AddConsole();

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseBrowserLink();
			app.UseCors(x => x.AllowAnyOrigin());
			app.UseDefaultFiles();
			app.UseStaticFiles();
			app.UseStatusCodePages();
		}
	}
}
