using Infrastructure.Repositories;
using ApplicationCore.Contracts.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Movieshop.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration config)
        {
                Configuration= config;
        }
        public void ConfigureServices(IServiceCollection service)
        {
            service.AddControllers();
           service.AddDbContext<MovieShopDbContext>( option=> {
               option.UseSqlServer(Configuration.GetConnectionString("MovieShopDB"));
           });
            //service.AddScoped<IMovieRepository, MovieRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) { 
            app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            
            app.UseEndpoints(endpoints => {
               endpoints.MapControllers();
            });

        }
    }
}
