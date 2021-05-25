using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TheCraftShop.Models;

namespace TheCraftShop
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var USING_SQL = false;

            //adding DbContext, sql server and refer to the connection string in appsettings.json
            services.AddDbContext<AppDbContext>(options =>
            {
                if (USING_SQL)
                {
                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
                }
                //added in memory database
                else
                {
                    options.UseInMemoryDatabase("handicrafts");
                }

            });

            //Bring in support for working with MVC
            services.AddControllersWithViews();

            //register my interface (repositorys) and implementation in service collection
            services.AddScoped<IHandicraftRepository, HandicraftRepository>();
            services.AddScoped<ICraftMethodRepository, CraftMethodRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //enabels to show exeptions
                app.UseDeveloperExceptionPage();
            }
            //redirect http requests to https
            app.UseHttpsRedirection();

            //serve static files. e.g. images, css in wwwroot-directory
            app.UseStaticFiles();

            //enables routing request to correct endpoint
            app.UseRouting();

            //respond to incomming requests
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
