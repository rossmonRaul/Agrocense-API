
//using Dominio.Interfaces.Aplicacion.EtapaTallerCo;

using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Usuario;
using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Empresa;
using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Finca;
using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Parcela;
using Agrosense.Service.BusinessLogic.Servicios;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
//using Dominio.Interfaces.
using System;
using System.Collections.Generic;
using System.Text;
using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Fertilizantes;
using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Suelo;
using Agrosense.Service.BusinessLogic.Interface.Aplicacion.Cultivos;


namespace Agrosense.Service.BusinessLogic
{
    public static class InyeccionDependencias
    {
        public static IServiceCollection AddAplicacion(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddScoped<IServicioEtapaTallerCo, ServicioEtapasTallerCo>();
            services.AddScoped<IServicioUsuario, ServicioUsuario>();
            services.AddScoped<IServicioEmpresa, ServicioEmpresa>();
            services.AddScoped<IServicioFinca, ServicioFinca>();
            services.AddScoped<IServicioParcela, ServicioParcela>();
            services.AddScoped<IServicioManejoFertilizantes, ServicioManejoFertilizantes>();
            services.AddScoped<IServicioMedicionesSuelo, ServicioMedicionesSuelo>();
            services.AddScoped<IServicioCultivos, ServicioCutivos>();

            return services;
        }
    }
}

