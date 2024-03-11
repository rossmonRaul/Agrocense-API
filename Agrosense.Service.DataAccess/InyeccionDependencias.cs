using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Agrosense.Service.DataAccess.StoredProcedures;
using Microsoft.Extensions.DependencyInjection;
using Agrosense.Service.DataAccess.Interface.Infraestructura;


namespace Agrosense.Service.DataAccess
{
    public static class InyeccionDependencias
    {
        public static IServiceCollection AddInfrastructura(this IServiceCollection services, IConfiguration configuration)
        {
            //contexto BD
            services.AddScoped<IContextoBD, ContextoBD>();

            //repositorios de cada CRUD
            //services.AddScoped<IRepositorioCanales, RepositorioCanales>();
            services.AddScoped<IRepositorioUsuario, RepositorioUsuario>();
            services.AddScoped<IRepositorioEmpresa, RepositorioEmpresa>();
            services.AddScoped<IRepositorioFinca, RepositorioFinca>();
            services.AddScoped<IRepositorioParcela, RepositorioParcela>();
            services.AddScoped<IRepositorioManejoFertilizantes, RepositorioManejoFertilizantes>();
            services.AddScoped<IRepositorioMedicionesSuelo, RepositorioMedicionesSuelo>();

            return services;
        }
    }
}
