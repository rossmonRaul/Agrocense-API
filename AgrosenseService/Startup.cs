using Agrosense.Service.BusinessLogic;
using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Usuario;
using Agrosense.Service.BusinessLogic.Servicios;
using Agrosense.Service.DataAccess;
//using DataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

//namespace Agrosense.Service
namespace AgrosenseService
{
    public class Startup
    {

        private IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews();
            services.AddInfrastructura(Configuration);
            services.AddAplicacion(Configuration);

            services.AddSwaggerGen(c =>
            {
                c.IgnoreObsoleteActions();
                c.IgnoreObsoleteProperties();
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Agrosense.Service", Version = "v1" });
            });

            // Configuración de CORS en un proyecto ASP.NET Core
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });
            //services.AddScoped<IServicioUsuario, ServicioUsuario>();
            /* string conString = this.Configuration.GetConnectionString("BD");
             connectionstring = conString;*/

            // In production, the React files will be served from this directory
            /* services.AddSpaStaticFiles(configuration =>
             {
                 configuration.RootPath = "swagger/ui";
             });*/
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
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

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            // app.UseSpaStaticFiles();

            app.UseRouting();

            app.UseCors();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            }); 

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
            });

           // app.UseSwaggerUI(x => { x.RoutePrefix = "swagger/ui"; });

            /*app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "swagger";

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
            });*/
        }
    }
}
