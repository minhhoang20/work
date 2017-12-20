using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.EntityFrameworkCore;
using ProductTrack.Models;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using Microsoft.AspNetCore.Authentication.MicrosoftAccount;

[assembly: OwinStartup(typeof(ProductTrack.App_Start.Startup))]

namespace ProductTrack.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ProductTrackEntities"].ToString();
            services.AddDbContext<ProductTrackContext>(options => options.UseSqlServer(connectionString));

            services.AddMvc();
        }
    }
}
