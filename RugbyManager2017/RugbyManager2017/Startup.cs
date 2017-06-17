using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RugbyManager2017.Models;

namespace RugbyManager2017
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
            services.AddDbContext<PlayerContext>(opt => opt.UseInMemoryDatabase());
			services.AddMvc();
		}

		public void Configure(IApplicationBuilder app)
		{
			app.UseMvc();
		}
	}
}