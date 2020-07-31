using System.ServiceModel;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using SoapCore;
using Streamer.Dodpv1.Models;
using Streamer.Dodpv1.Services;

namespace Streamer
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.TryAddSingleton<IDODPMobile, DODPMobile>();
            services.AddMvc(o => o.EnableEndpointRouting = false);
            services.AddSoapCore();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseSoapEndpoint<IDODPMobile>("/DodpMobile/Service.asmx", new BasicHttpBinding(), SoapSerializer.XmlSerializer);

            app.UseMvc();
        }
    }
}
